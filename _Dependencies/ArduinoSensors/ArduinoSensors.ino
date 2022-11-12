// --- Temperature ---
float logR;
const float R = 10000;
const float c1 = 1.009249522e-03, c2 = 2.378405444e-04, c3 = 2.019202697e-07;

// --- Voltage ---
const float VOLT_R1 = 100000.0; // Resistor 1 value
const float VOLT_R2 = 10000.0;  // Resistor 2 value
const float VOLT_REF = 5.0;     

// --- Protocol ---
bool pinActive[6] = { true, false, false, true, false, false };
const char EMPTY[1] = "";
const char SEPERATOR[2] = "|";
const char TERMINATOR[2]  = ";";
int pinToChange = -1;

void setup() {
  Serial.begin(9600);
}

float temperature(int pin) {
  logR = log(R * (1023.0 / (float)analogRead(pin) - 1.0));
  return (1.0 / (c1 + c2*logR + c3*logR*logR*logR)) - 273.15;
}

float voltage(int pin) {
  return (analogRead(pin) * VOLT_REF) / 1024.0 / (VOLT_R2/(VOLT_R1+VOLT_R2));
}

void loop() {

  while (Serial.available() > 0) {
    pinToChange = Serial.read();
    pinActive[pinToChange] = !pinActive[pinToChange];
  }
  
  pinActive[0] ? Serial.print(temperature(A0)) : Serial.print(EMPTY);
  Serial.print(SEPERATOR);
  pinActive[1] ? Serial.print(temperature(A1)) : Serial.print(EMPTY);
  Serial.print(SEPERATOR);
  pinActive[2] ? Serial.print(temperature(A2)) : Serial.print(EMPTY);
  Serial.print(SEPERATOR);
  pinActive[3] ? Serial.print(voltage(A3)) : Serial.print(EMPTY);
  Serial.print(SEPERATOR);
  pinActive[4] ? Serial.print(voltage(A4)) : Serial.print(EMPTY);
  Serial.print(SEPERATOR);
  pinActive[5] ? Serial.print(voltage(A5)) : Serial.print(EMPTY);
  Serial.print(TERMINATOR);

  delay(250);
}
