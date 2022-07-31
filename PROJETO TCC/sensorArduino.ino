#include <DHT.h>
#define rele 2
#define dht_pin A5
#define solo_pin A6
#define dht_type DHT11
DHT my_dht(dht_pin, dht_type);

int percent = 0;

void setup() {
   Serial.begin(9600);
   pinMode(rele, OUTPUT);
   my_dht.begin();
}

void loop() { 
  percent = convertToPercent(analogRead (solo_pin));
  if(percent < 70){
    digitalWrite(rele, HIGH);
  } else{
    digitalWrite(rele, LOW);
  }
  String info = (String(my_dht.readTemperature()) + ":" + String(my_dht.readHumidity()) + ":" + String(percent));
  Serial.println(info);
  delay(10000);
}

int convertToPercent(int value)
{
int percentValue = 0;
percentValue = map(value, 1023, 465, 0, 100);
return percentValue;
}
