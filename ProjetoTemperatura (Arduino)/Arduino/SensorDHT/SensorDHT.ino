#include <DHT.h>
#define dht_pin 5
#define dht_type DHT11

DHT my_dht(dht_pin, dht_type);

void setup()
{
  Serial.begin(9600);
  my_dht.begin();
}

void loop()
{
  String info = String(my_dht.readTemperature()) + ":" + String(my_dht.readHumidity());
  Serial.println(info);
  delay(1000);
}
