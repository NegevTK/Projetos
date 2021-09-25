#include <LiquidCrystal.h> 
#include <DHT.h>
#define dht_pin A5
#define dht_type DHT11
DHT my_dht(dht_pin, dht_type);
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
void setup() {
   Serial.begin(9600);
   my_dht.begin();
   lcd.begin(16,2); 
   lcd.clear();
}

void loop() { 
  String temperatura = String(my_dht.readTemperature()); 
  String umidade = String(my_dht.readHumidity()); 
  String info = ((temperatura) + ":" + (umidade));
  Serial.println(info);
  lcd.setCursor(0,0);
  lcd.print("Temp: " + temperatura + (char)223 + "C");
  lcd.setCursor(0,1);
  lcd.print("Umid: " + umidade + "%");
  delay(600000);
}
