
#define BaudRate 9600
#define LEDPin 13
char incomingOption;
// the setup function runs once when you press reset or power the board
void setup() {
  // initialize digital pin 13 as an output.
 // pinMode(13, OUTPUT);
 // pinMode(12, OUTPUT);
 //  pinMode(11, OUTPUT);
 pinMode(LEDPin , OUTPUT);
Serial.begin(BaudRate);

}

// the loop function runs over and over again forever
void loop() {
 incomingOption = Serial.read(); 
 
 switch (incomingOption){
  case '1':
  digitalWrite(LEDPin, HIGH);
  break;
   case '0':
  digitalWrite(LEDPin, LOW);
  break;
  }
 
 // digitalWrite(13, HIGH);  
 // delay(1000);           
 // digitalWrite(13, LOW);    
//  delay(1000);    
  //digitalWrite(12, HIGH);  
 // delay(1000);           
 // digitalWrite(12, LOW);    
//  delay(1000);    
//  digitalWrite(11, HIGH);  
//  delay(1000);           
//  digitalWrite(11, LOW);    
//  delay(1000);   

}

