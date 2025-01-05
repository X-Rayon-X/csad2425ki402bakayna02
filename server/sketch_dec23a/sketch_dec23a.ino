// Arduino Code
// This code reads a message from the serial port, modifies it, and sends it back.
void setup() {
  Serial.begin(9600); // Default baud rate, ensure this matches the selected baud rate in the Windows Forms application
}

void loop() {
  if (Serial.available() > 0) {
    String receivedMessage = Serial.readStringUntil('\n');
    String modifiedMessage = receivedMessage + " - modified";
    Serial.println(modifiedMessage);
  }
}