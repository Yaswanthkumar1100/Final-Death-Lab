String unity;

#define A 5
#define B 4
#define DOWN 2
#define UP 7

  void Trig(int var) {
    digitalWrite(var, HIGH);
    delay(500);
    digitalWrite(var, LOW);
    delay(500);
    digitalWrite(var, HIGH);
    delay(500);
    digitalWrite(var, LOW);
    delay(500);
    digitalWrite(var, HIGH);
    delay(500);
  }
  
void setup() {
  Serial.begin(9600);
  
  pinMode(A, OUTPUT);
  pinMode(B, OUTPUT);
  pinMode(UP, OUTPUT);
  pinMode(DOWN, OUTPUT);
  pinMode(LED_BUILTIN, OUTPUT);

  digitalWrite(LED_BUILTIN, HIGH);
  delay(500);
  digitalWrite(LED_BUILTIN, LOW);
  delay(500);
  digitalWrite(LED_BUILTIN, HIGH);
  delay(500);
  digitalWrite(LED_BUILTIN, LOW);

}

void loop() {
 

  String unity = Serial.readString();
 

  if (unity == "u")
  {
    digitalWrite(LED_BUILTIN, HIGH);
    Trig(UP);
  }
  if (unity == "d")
  {
    digitalWrite(LED_BUILTIN, HIGH);
    
    Trig(UP);
    delay(20000);
    digitalWrite(LED_BUILTIN, LOW);
    Trig(DOWN);
    
    Trig(B);
    Trig(UP);
    Trig(UP);
    Trig(UP);
    Trig(UP);
    delay(10000);
    Trig(DOWN);
    delay(10000);
    Trig(DOWN);
    delay(10000);
    Trig(DOWN);
    Trig(DOWN);
    Trig(DOWN);
    Trig(A);
  }

  if (unity == "a")
  {
    digitalWrite(LED_BUILTIN, HIGH);
    Trig(A);
  }

  if (unity == "b")
  {
    digitalWrite(LED_BUILTIN, HIGH);
    Trig(B);
  }
  }
     

  
