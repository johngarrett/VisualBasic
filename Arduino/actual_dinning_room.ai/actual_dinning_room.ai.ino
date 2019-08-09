float sensorValue = 0.0f;//this is used to detect any voltage
int led = 13;

void setup() {
sensorValue = analogRead(A0);//the thing is plugged into A0
loop();
}

void loop() {
sensorValue = analogRead(A0);//the thing is plugged into A0
if(sensorValue != 0)
{
    digitalWrite(led, HIGH);   // turn the LED on (HIGH is the voltage level)

}
  else   digitalWrite(led, LOW);   // turn the LED off (HIGH is the voltage level)

}
