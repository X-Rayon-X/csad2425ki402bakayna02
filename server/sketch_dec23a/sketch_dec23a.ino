void setup() {
  Serial.begin(9600);  // Ініціалізація серійного порту
}

void loop() {
  if (Serial.available() > 0) {
    String input = Serial.readStringUntil('\n');  // Читання рядка від комп'ютера
    input.trim();  // Видалення зайвих пробілів

    // Модифікація рядка
    String modifiedString = input + " - modified";  

    // Відправлення зміненої строки назад на комп'ютер
    Serial.println(modifiedString);  

    delay(100);  // Чекати перед наступним циклом
  }
}
