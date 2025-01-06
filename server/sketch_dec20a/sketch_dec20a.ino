// Game state variables
String gameMode = "Man vs AI"; // Default game mode
String player1Choice = "";
String player2Choice = "";
String result = "";
// Збережений стан гри
String savedGameMode = "";
String savedPlayer1Choice = "";
String savedPlayer2Choice = "";
String savedResult = "";


// Function to get a random move for AI
String getRandomMove() {
  int randomNum = random(0, 3);
  if (randomNum == 0) return "rock";
  if (randomNum == 1) return "paper";
  return "scissors";
}

// Function to determine the winner
String determineWinner(String move1, String move2) {
  if (move1 == move2) return "draw";
  if ((move1 == "rock" && move2 == "scissors") ||
      (move1 == "scissors" && move2 == "paper") ||
      (move1 == "paper" && move2 == "rock")) {
    return "Player 1 wins";
  }
  return "Player 2 wins";
}

void saveGameState() {
  // Збереження поточного стану гри в окремі змінні
  savedGameMode = gameMode;
  savedPlayer1Choice = player1Choice;
  savedPlayer2Choice = player2Choice;
  savedResult = result;
}

void loadGameState() {
  // Відновлення стану гри із збережених змінних
  gameMode = savedGameMode;
  player1Choice = savedPlayer1Choice;
  player2Choice = savedPlayer2Choice;
  result = savedResult;

  Serial.println(gameMode);
  Serial.println(player1Choice);
  Serial.println(player2Choice);
  Serial.println(result);

}


void setup() {
  Serial.begin(9600);
  randomSeed(analogRead(0)); // Initialize random seed from analog pin
}

void loop() {
  if (Serial.available() > 0) {
    String input = Serial.readStringUntil('\n');
    input.trim(); // Remove any unnecessary whitespace

    // Process the received command
    if (input.startsWith("set_mode")) {
      gameMode = input.substring(9);
      //Serial.println("Mode set to: " + gameMode);
    }
    else if (input.startsWith("play")) {
      int player1Start = input.indexOf("player1") + 8;
      int player1End = input.indexOf(" ", player1Start);
      player1Choice = input.substring(player1Start, player1End);
      
      // Handle different game modes
      if (gameMode == "Man vs AI") {
        player2Choice = getRandomMove();
      } else if (gameMode == "AI vs AI") {
        player1Choice = getRandomMove();
        player2Choice = getRandomMove();
      } else {
        int player2Start = input.indexOf("player2") + 8;
        player2Choice = input.substring(player2Start);
      }

      result = determineWinner(player1Choice, player2Choice);

      // Send the result back to the client
        Serial.println(player1Choice);
        Serial.println(player2Choice);
        Serial.println(result);

    }
    else if (input.startsWith("save")) {
      saveGameState();
    }
    else if (input.startsWith("load")) {
      loadGameState();
    }
    else {
      //Serial.println("Error: Unknown action");
    }
  }
}
