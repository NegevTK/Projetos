#include <DHT.h>
#define rele 2
#define dht_pin A5
#define solo_pin A6
#define dht_type DHT11
DHT my_dht(dht_pin, dht_type);
int umidade = 0;
void setup() {
   Serial.begin(9600);
   pinMode(rele, OUTPUT);
   my_dht.begin();
}
void loop() { 
  umidade = analogRead (solo_pin);
  int porcentagem = map(umidade, 1023, 0, 0, 100);
  if(porcentagem < 70){
    digitalWrite(rele, HIGH);
  } else{
    digitalWrite(rele, LOW);
  }
  String info = (String(my_dht.readTemperature()) + ":" + String(my_dht.readHumidity()) + ":" + String(porcentagem));
  Serial.println(info);
  delay(1000);
}
