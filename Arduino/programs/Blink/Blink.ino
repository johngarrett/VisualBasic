
int led = 13;

void setup() {  pinMode(led, OUTPUT);}

void loop() {
  four();              
  digitalWrite(led, LOW);   
  delay(2000);  
  two();   
   delay(2000);   
   zero();    
   delay(2000);      
}
void four(){
  digitalWrite(led, HIGH);   delay(1000);  
              
  digitalWrite(led, LOW);   delay(100);         
  
   digitalWrite(led, HIGH);   delay(1000);
              
  digitalWrite(led, LOW);   delay(100);         
  
   digitalWrite(led, HIGH);  delay(1000);
              
  digitalWrite(led, LOW);   delay(100);         
  
   digitalWrite(led, HIGH);   delay(1000); }
 
 void two(){
      digitalWrite(led, HIGH);   delay(1000);  
              
  digitalWrite(led, LOW);   delay(100);         
  
   digitalWrite(led, HIGH);   delay(1000);
    
  }
  void zero(){
     digitalWrite(led, LOW);   delay(1000);  
    }
  
