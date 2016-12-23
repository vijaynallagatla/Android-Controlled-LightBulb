

int input;
boolean state=false;

void setup() {
  Serial.begin(9600);
  pinMode(12,OUTPUT);
  Serial.print(state);
}

void loop() {
  // print the string when a newline arrives:
  if (Serial.available()>0) {
      input=Serial.read();
     
     switch(input)
     {
       case '1': digitalWrite(12,HIGH);
                     
                     state=true;
                     Serial.print(state);
                     break;
       case '0': digitalWrite(12,LOW);
                   state=false;
                   Serial.println(state);
                   break;       
     }
  }
}



