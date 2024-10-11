//Curtin University
//Mechatronics Engineering

// This driver handles serial transmission of data.
// Each command or response is sent as a four byte package, formatted as follows:
// <startByte><commandByte><dataByte><checkByte>
// The start byte identifies the first byte of a new message. Ideally this value would be reserved for the start byte 
// but as that is not possible the build of the message will be confirmed using a check sum.
// The command byte allows selection of which port to interact with.
// The data byte is the value set to or read from a port, this is the main information that needs to be transmitted.
// The check sum allows for confirmation that the correct four bytes have been received as a message. This is useful as it 
// confirm that the end of the message has been reached and that no bytes were lost during the transmission.

//Declare variables for storing the port values. 
byte output1 = 50;
byte output2 = 50;
byte input1 = 0;
byte input2 = 0;
byte mode = 0;
byte speedR = 50;
byte speedL = 50;
char State = "";  //variable to store the current state to be serialy communicated with the GUI

//Declare variables for each byte of the message.
byte startByte = 0;
byte commandByte = 0;
byte dataByte = 0;
byte checkByte = 0;
byte iteration = 0;
byte dutyRight = 0;
byte dutyLeft = 0;
byte previousState = 0;
byte state = 0; // 0-Moving forward, 1-blackcrossed on the right, 2-black crossed on the left, 3-completely out
byte speedFR = 90; //Forward constant speed Right motor
byte speedFL = 90; //Forward constant speed Left motor

int durationL = 0;
int durationR = 0; 
int SensorR_ref = 0;
int SensorL_ref = 0;
int checksum2 = 0;
double lastsend = 0;


//Declare variable for calculating the check sum which is used to confirm that the correct bytes were identified as the four message bytes.
byte checkSum = 0;
byte commandByte1 = 0;
byte commandByte2 = 0;

//Declare a constant for the start byte ensuring that the value is static.
const byte START = 255;

//Declare constants to enumerate the port values.
const byte INPUT1 = 0;
const byte INPUT2 = 1;
const byte OUTPUT1 = 2;
const byte OUTPUT2 = 3;
const byte ModeDrive = 4;
const byte Setthreshhold = 5;
const byte difference = 15;


const byte DACPIN1[8] = {6,7,8,9,5,4,3,2};
const byte DACPIN2[8] = {A2,A3,A4,A5,A1,A0,11,10};
const byte SENSOR1 = A6; //Right Sensor
const byte SENSOR2 = A7;  //Left Sensor

void outputToDAC1( byte data ) //loop through lookup table of Arduino pins connected to DAC and write correct bit to each
{
  data = bitFlip(data);
  for( int i = 0; i<=7; i++ )
  {
    digitalWrite( DACPIN1[i] , ((data>>i)&1 ? HIGH : LOW));
  }
}

void outputToDAC2( byte data ) //loop through lookup table of Arduino pins connected to DAC and write correct bit to each
{
  for( int i = 0; i<=7; i++ )
  {
    digitalWrite( DACPIN2[i] , ((data>>i)&1 ? HIGH : LOW));
  }
}

void setReference()  // sets the reference limit unique to the surface it is placed on initially on a black surface.
{
  delay(50);
  SensorL_ref = analogRead(SENSOR2) - difference;
  SensorR_ref = analogRead(SENSOR1) - difference;
}

void initDACs() //loop through lookup table of Arduino pins connected to DAC and set to output mode
{
  for( int i = 0; i<=7; i++ )
  {
    pinMode( DACPIN1[i] , OUTPUT);
    pinMode( DACPIN2[i] , OUTPUT);
  }
  outputToDAC1(50); //R
  outputToDAC2(50); //L
}

//Setup initialises pins as inputs or outputs and begins the serial.
void setup() 
{
  initDACs();
  Serial.begin(9600);
  setReference();
}

//Main program manages setting/reading of ports via serial.
void loop() 
{


  if (Serial.available() >= 4) // Check that a full package of four bytes has arrived in the buffer.
  {
    startByte = Serial.read(); // Get the first available byte from the buffer, assuming that it is the start byte.

    if(startByte == START) // Confirm that the first byte was the start byte, otherwise begin again checking the next byte.
    {
      //Read the remaining three bytes of the package into the respective variables.
      commandByte = Serial.read();
      dataByte = Serial.read();
      checkByte = Serial.read();

      checkSum = startByte + commandByte + dataByte; // Calculate the check sum, this is also calculated in visual studio and is sent as he final byte of the package.

      if(checkByte == checkSum) //Confirm that the calculated and sent check sum match, if so it is safe to process the data.
      {
        //Check the command byte to determine which port is being called and respond accordingly.           
        switch(commandByte)
        {
          
          case OUTPUT1: //For Output 1 the value of the data byte is written to pins in DACPIN1.
          {
            output1 = dataByte;    //The value of the data byte is stored in variable output 1, this step is redundant as the value could be written directly to the port.
  
          } 
          break;
          case OUTPUT2: //For Output 1 the value of the data byte is written to pins in DACPIN2.
          {
            output2 = dataByte;  
            
          }
          break;
          case ModeDrive: // The mode(Auto or manual) selection is controlled by the GUI
          {
            mode = dataByte; // 1== auto 0 == manual
          }
          break;
          case Setthreshhold:
          {
            SensorL_ref = analogRead(SENSOR2) - difference;
            SensorR_ref = analogRead(SENSOR1) - difference;
          }
        }
      }
    }    
  }



  if (lastsend<=millis()) // a timer sets the data transfer rate to periodically send data 
  {
    //The current state of automated motion is sent to the GUI to be displayed to the user.

    if (state == 0)
    {
      State = "F";
    }
    if (state == 1)
    {
      State = "r";
    }
    if (state == 2)
    {
      State = "l";
    }
    if (state == 3)
    {
      State = "R";
    }
    if (state == 4)
    {
      State = "L";
    }
    commandByte1 = speedR;
    commandByte2 = speedL;
    Serial.write(START); //Send the start byte indicating the start of a package.
    Serial.write(commandByte1); //send data
    Serial.write(commandByte2); //Send data
    Serial.write(State);
    int checkSum2 = START + commandByte1 + commandByte2 + State; //Calculate the check sum.
    Serial.write(checkSum2); //Send the check sum.


    lastsend = millis() + 40;// data transfers occur every 40 ms

  }



  if (mode == 1) // runs if mode is set to auto(1)
  {
    // checks which state it currently is and runs that part of the code. This method ensures
    //  that every loop runs the bare minimum of lines helping with response time

    if (state == 0)
    {
        moveForward();
    }
    if (state == 1)
    {
        moveRight();
    }
    if (state == 2)
    {
        moveLeft();
    }
    if (state == 3)
    {
        turnRight();
    }
    if (state == 4)
    {
        turnLeft();
    }
  
  }
  else
  {
    // with mode set to manual the data recievd from teh GUI sets the mototr speeds
    speedR = output2;
    speedL = output1;
    outputToDAC2(output2);
    outputToDAC1(output1);
  }

}


void moveRight()
{
  //Serial.print("sway right");
  //check if the state of sensors has changed
  if ((analogRead(SENSOR1)<(SensorR_ref)) && (analogRead(SENSOR2)<(SensorL_ref)))
  {
    previousState = state;
    state = 0;
    speedR = speedFR;
    speedL = speedFL;
  }
  if ((analogRead(SENSOR1)>(SensorR_ref)) && (analogRead(SENSOR2)>(SensorL_ref)))
  {
    previousState = state;
    state = 3;
    speedR = 85;
    speedL = 20;
  }
  
  outputToDAC1(speedR); //R
  outputToDAC2(speedL); //L
}

void moveLeft()
{

  //Sway left

  //Serial.print("sway left");

  // Are both the sensors reading white?
  if ((analogRead(SENSOR1)<(SensorR_ref)) && (analogRead(SENSOR2)<(SensorL_ref)))
  {
    // sensors reading white means the robot is on track and shoykd return to moving forwards
    previousState = state;
    state = 0;    // sets state to move forward by the next loop
    speedR = speedFR;
    speedL = speedFL;
  }
  if ((analogRead(SENSOR1)>(SensorR_ref)) && (analogRead(SENSOR2)>(SensorL_ref)))
  {
    previousState = state;
    state = 4;  // sets the state t
    speedR = 20;
    speedL = 85;
  }

  // set the motor speeds as soon as the sesnor recieves the changes to improve the response time 
  outputToDAC1(speedR); //R
  outputToDAC2(speedL); //L

}

void turnRight()
{
  // Turning right
  //Serial.print("turn right");

  // check if the sensor is back to showing the left sensor as black and the right sensor as white
  if ((analogRead(SENSOR1)<(SensorR_ref)) && (analogRead(SENSOR2)>(SensorL_ref)))
  {
    previousState = state;
    //Return to state 1 which was to sway right and slowly return to the forwards motion state
    state = 1;
    speedR = 85;
    speedL = 60;
  }
  if ((analogRead(SENSOR1)<(SensorR_ref)) && (analogRead(SENSOR2)<(SensorL_ref)))
  {
    previousState = state;
    //A fail safe in case the something goes wrong and the robot is back on the track
    state = 0;
    speedR = speedFR;
    speedL = speedFL;
  }
  
  // set the motor speeds as soon as the sesnor recieves the changes to improve the response time 
  outputToDAC1(speedR); //R
  outputToDAC2(speedL); //L

}

void turnLeft()
{
  //Turning Left
  //Serial.print("turn left");

  //check if the sensor is back to showing the right sensor as black and the left sensor as white
  if ((analogRead(SENSOR1)>(SensorR_ref)) && (analogRead(SENSOR2)<(SensorL_ref)))
  {
    previousState = state;
    state = 2;    // return to state 2 to sway left and slowly return to the track
    speedR = 60;
    speedL = 85;
  }
  if ((analogRead(SENSOR1)<(SensorR_ref)) && (analogRead(SENSOR2)<(SensorL_ref)))
  {
    previousState = state;
    state = 0;    // fail safe incase something goes wrong and the robot is on the white line
    speedR = speedFR;
    speedL = speedFL;
  }

  // set the motor speeds as soon as the sesnor recieves the changes to improve the response time 
  outputToDAC1(speedR); //R
  outputToDAC2(speedL); //L

}

void moveForward()
{
  
  //Serial.print("moving forward");
  // Moving fowards

  // check if the right sensor is reading black(robot moving away from the line towards the right) 
  if (analogRead(SENSOR1)>(SensorR_ref))
  {

    previousState = state;
    state = 2;    // go to state 2 that makes the robot turn to the left(sway to the left)
    speedR = 60;
    speedL = 85;
  }
  else
  {
    //if not check if the left sensor is reading black(robot is swaying to the left)
    if (analogRead(SENSOR2)>(SensorL_ref))
    {

      previousState = state;
      state = 1;    // go to state 1 that makes the robot turn to the right(sway to the righ)
      speedR = 85;
      speedL = 60;
    }
  }

  // set the motor speeds as soon as the sesnor recieves the changes to improve the response time
  outputToDAC1(speedR); //R
  outputToDAC2(speedL); //L

}
//Function to reverse the order of the bits.
byte bitFlip(byte value)
{
       byte bFlip = 0;
       byte j=7;
       for (byte i=0; i<8; i++) { 
         bitWrite(bFlip, i, bitRead(value, j));
         j--;
       }
       return bFlip;
}
