
#define BaudRate 9600
char incomingOption;

void setup() {
  
 pinMode(13, OUTPUT); //Green
 pinMode(12, OUTPUT); //Red
 pinMode(11, OUTPUT); //Yellow

Serial.begin(BaudRate);

}


void loop() {
 incomingOption = Serial.read(); 
 
 switch (incomingOption){
  case '4' :
   digitalWrite(13, LOW);
  digitalWrite(12, LOW);
  digitalWrite(11, LOW);
  break;
  case '1': //Green
  digitalWrite(13, HIGH);
  digitalWrite(12, LOW);
  digitalWrite(11, LOW);
  break;
   case '2': //Yellow
  digitalWrite(11, HIGH);
    digitalWrite(12, LOW);
  digitalWrite(13, LOW);
  break; //Red
     case '3':
  digitalWrite(12, HIGH);
    digitalWrite(13, LOW);
  digitalWrite(11, LOW);
  break;
  }  

}

