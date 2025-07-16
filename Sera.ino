#include <DHT.h>

// Pini pentru senzori
#define pin_i 4    // INTERIOR
#define pin_e 12   // EXTERIOR

#define DHTTYPE DHT11

DHT interior(pin_i, DHTTYPE);
DHT exterior(pin_e, DHTTYPE);

// LED-uri și componente
int buton = 2;    
int led = 13;     // LED roșu general (ON/OFF sistem)

int ledr_e = 11;
int ledg_e = 10;
int ledb_e = 9;

int ledr_i = 6;
int ledg_i = 5;
int ledb_i = 3;

int buzz = 8;     // difuzor

volatile int stare = 0;  // flag pentru starea sistemului (on/off)

float t_exterior;   
float t_interior;

void setup() {
  pinMode(led, OUTPUT);      
  pinMode(ledr_e, OUTPUT);
  pinMode(ledr_i, OUTPUT);
  pinMode(ledg_e, OUTPUT);
  pinMode(ledg_i, OUTPUT);
  pinMode(ledb_i, OUTPUT);
  pinMode(ledb_e, OUTPUT);
  
  pinMode(buton, INPUT_PULLUP);
  
  attachInterrupt(digitalPinToInterrupt(buton), buttonPressed, FALLING);

  interior.begin();
  exterior.begin();
  
  Serial.begin(9600);
}

void buttonPressed() {
  //delay(50);            // debounce simplu
  stare = !stare;       // comută sistemul on/off
}

void loop() {
  if (stare == 1) {
    digitalWrite(led, LOW);  // sistem activ → LED roșu oprit

    //Serial.println("ON");

    t_interior = interior.readTemperature();
    float h_interior = interior.readHumidity();
    
    t_exterior = exterior.readTemperature();
    float h_exterior = exterior.readHumidity();


    Serial.print(t_interior);
     Serial.print(",");
     Serial.print(h_interior);
     Serial.print(",");                 //afisare separata pentru C# ca sa pot sa preiau varaiabilele mai usor
     Serial.print(t_exterior);
     Serial.print(",");
     Serial.println(h_interior);

    
    // Afișare pe serial
    /*Serial.print("Temperatura interior (C): ");
    Serial.println(t_interior, 2);
    Serial.print("Umiditate interior (%): ");
    Serial.println(h_interior, 2);
                                                      //afisare temperata interior/exterio ; afisare umiditate interior/ecterio
    Serial.print("Temperatura exterior (C): ");
    Serial.println(t_exterior, 2);
    Serial.print("Umiditate exterior (%): ");
    Serial.println(h_exterior, 2);*/

    delay(500);

   
    if (t_exterior < 28) {
      digitalWrite(ledb_e, HIGH);
      digitalWrite(ledr_e, LOW);        //daca temp exterior < 28 -> led albastru  on restul off
      digitalWrite(ledg_e, LOW);
    } 
    else if (t_exterior > 30) 
    {
      digitalWrite(ledr_e, HIGH);
      digitalWrite(ledb_e, LOW);      //daca temp exterior > 30 -> led rosu on restul off
      digitalWrite(ledg_e, LOW);
    } 
    else
    {
      digitalWrite(ledg_e, HIGH);
      digitalWrite(ledr_e, LOW);      //in rest led verde on restul off
      digitalWrite(ledb_e, LOW);
    }

   
    if (t_interior < 22) 
    {
      digitalWrite(ledb_i, HIGH);
      digitalWrite(ledr_i, LOW);        //la fel dar cu temp interiorara
      digitalWrite(ledg_i, LOW);
      tone(buzz, 600, 300);           //difuzorul este pornit
    } 
      else if (t_interior > 28) {
      digitalWrite(ledr_i, HIGH);
      digitalWrite(ledb_i, LOW);
      digitalWrite(ledg_i, LOW);
      tone(buzz, 800, 200);
    }
    else 
    {
      digitalWrite(ledg_i, HIGH);
      digitalWrite(ledr_i, LOW);
      digitalWrite(ledb_i, LOW);
    }

  } else {
    digitalWrite(led, HIGH);          // LED roșu aprins
    digitalWrite(ledr_e, LOW);
    digitalWrite(ledr_i, LOW);
    digitalWrite(ledg_e, LOW);
    digitalWrite(ledg_i, LOW);        //restul led-urilor off
    digitalWrite(ledb_e, LOW);
    digitalWrite(ledb_i, LOW);
    noTone(buzz);
    //Serial.println("OFF");

    delay(500);                  
  }
}
