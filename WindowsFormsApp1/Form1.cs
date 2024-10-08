using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.KeyPressEventHandler;

namespace WindowsFormsApp1
{ 

    public partial class Form1 : Form
    {
        // Declare variables to store inputs and outputs.
        bool runSerial = true;
        bool byteRead = false;
        bool nonNumberEntered = false;
        int Input1 = 0;
        int Input2 = 0;
        int state = 0;
        byte status1 = 0;
        byte status2 = 0;

        byte[] Outputs = new byte[4];
        byte[] Inputs = new byte[5];
        string[] KeysPressed = new string[2];


        const byte START = 255;
        const byte ZERO = 0;

        public Form1()
        {
            KeysPressed[0] = "";
            KeysPressed[1] = "";
            InitializeComponent();
            // Establish connection with serial
            if (runSerial == true)
            {
                if (!serial.IsOpen)                                  // Check if the serial has been connected.
                {
                    try
                    {
                        serial.Open();                               //Try to connect to the serial.
                    }
                    catch
                    {
                        statusBox1.Enabled = false;
                        statusBox1.Text = "ERROR: Failed to connect.";     //If the serial does not connect return an error.
                    }
                    sendIO(2, (byte)50);//L
                    sendIO(3, (byte)50);//R
                }
            }
        }

        private void sendIO(byte PORT, byte DATA)
        {
            Outputs[0] = START;    //Set the first byte to the start value that indicates the beginning of the message.
            Outputs[1] = PORT;     //Set the second byte to represent the port where, Input 1 = 0, Input 2 = 1, Output 1 = 2 & Output 2 = 3. This could be enumerated to make writing code simpler... (see Arduino driver)
            Outputs[2] = DATA;  //Set the third byte to the value to be assigned to the port. This is only necessary for outputs, however it is best to assign a consistent value such as 0 for input ports.
            Outputs[3] = (byte)(START + PORT + DATA); //Calculate the checksum byte, the same calculation is performed on the Arduino side to confirm the message was received correctly.

            if (serial.IsOpen)
            {
                serial.Write(Outputs, 0, 4);         //Send all four bytes to the IO card.                      
            }
        }

        private void Key_Output(string[] Keys)
        {
            ForwardButton.BackColor = Color.LimeGreen;
            BackButton.BackColor = Color.LimeGreen;
            LeftButton.BackColor = Color.LimeGreen;
            RightButton.BackColor = Color.LimeGreen;

            ForwardLabel.ForeColor = Color.White;
            BackLabel.ForeColor = Color.White;
            RightLabel.ForeColor = Color.White;
            LeftLabel.ForeColor = Color.White;

            if ((Keys[0] == "w" && Keys[1] == "a") || (Keys[1] == "w" && Keys[0] == "a")) {
                sendIO(2, (byte)55);//L
                sendIO(3, (byte)70);//R
                ForwardButton.BackColor = Color.ForestGreen;
                LeftButton.BackColor = Color.ForestGreen;
                ForwardLabel.ForeColor = Color.Red;
                LeftLabel.ForeColor = Color.Red;
                statusBox1.Text = "Turning Left Forwards";
            }
            else if ((Keys[0] == "w" && Keys[1] == "d") || (Keys[1] == "w" && Keys[0] == "d"))
            {
                sendIO(2, (byte)70);//L
                sendIO(3, (byte)55);//R
                ForwardButton.BackColor = Color.ForestGreen;
                RightButton.BackColor = Color.ForestGreen;
                ForwardLabel.ForeColor = Color.Red;
                RightLabel.ForeColor = Color.Red;
                statusBox1.Text = "Turning Right Forwards";
            }
            else if ((Keys[0] == "s" && Keys[1] == "d") || (Keys[1] == "s" && Keys[0] == "d"))
            {
                sendIO(2, (byte)30);//L
                sendIO(3, (byte)45);//R
                BackButton.BackColor = Color.ForestGreen;
                RightButton.BackColor = Color.ForestGreen;
                BackLabel.ForeColor = Color.Red;
                RightLabel.ForeColor = Color.Red;
                statusBox1.Text = "Turning Right Backwards";
            }
            else if ((Keys[0] == "s" && Keys[1] == "a") || (Keys[1] == "s" && Keys[0] == "a"))
            {
                sendIO(2, (byte)45);//L
                sendIO(3, (byte)30);//R
                BackButton.BackColor = Color.ForestGreen;
                LeftButton.BackColor = Color.ForestGreen;
                BackLabel.ForeColor = Color.Red;
                LeftLabel.ForeColor = Color.Red;
                statusBox1.Text = "Turning Left Backwards";
            }
            else if (Keys[0] == "w" || Keys[1] == "w")
            {
                sendIO(2, (byte)70);//L
                sendIO(3, (byte)70);//R
                ForwardButton.BackColor = Color.ForestGreen;
                ForwardLabel.ForeColor = Color.Red;
                statusBox1.Text = "Forwards";
            }
            else if (Keys[0] == "s" || Keys[1] == "s")
            {
                sendIO(2, (byte)30);//L
                sendIO(3, (byte)30);//R
                BackButton.BackColor = Color.ForestGreen;
                BackLabel.ForeColor = Color.Red;
                statusBox1.Text = "Backwards";
            }
            else if (Keys[0] == "a" || Keys[1] == "a")
            {
                sendIO(2, (byte)30);//L
                sendIO(3, (byte)70);//R
                LeftButton.BackColor = Color.ForestGreen;
                LeftLabel.ForeColor = Color.Red;
                statusBox1.Text = "Rotate AntiClockwise";
            }
            else if (Keys[0] == "d" || Keys[1] == "d")
            {
                sendIO(2, (byte)70);//L
                sendIO(3, (byte)30);//R
                RightButton.BackColor = Color.ForestGreen;
                RightLabel.ForeColor = Color.Red;
                statusBox1.Text = "Rotate Clockwise";
            }
            else if (Keys[0] == "" && Keys[1] == "")
            {
                sendIO(2, (byte)50);//L
                sendIO(3, (byte)50);//R
                statusBox1.Text = "Stop";
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (KeysPressed[0] == "" || KeysPressed[0] == "s" || KeysPressed[0] == "w")
                {
                    KeysPressed[0] = "w";
                }
                else
                {
                    KeysPressed[1] = "w";
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (KeysPressed[0] == "" || KeysPressed[0] == "w" || KeysPressed[0] == "s")
                {
                    KeysPressed[0] = "s";
                }
                else
                {
                    KeysPressed[1] = "s";
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if ((KeysPressed[0] == "" || KeysPressed[0] == "a") && KeysPressed[1] != "a")
                {
                    KeysPressed[0] = "a";
                }
                else
                {
                    KeysPressed[1] = "a";
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if ((KeysPressed[0] == "" || KeysPressed[0] == "d") && KeysPressed[1] != "d")
                {
                    KeysPressed[0] = "d";
                }
                else
                {
                    KeysPressed[1] = "d";
                }
            }
            if (state == 0)
            {
                Key_Output(KeysPressed);
            }

        }


        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                sendIO(2, (byte)75);//L
                sendIO(3, (byte)75);//R
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                sendIO(2, (byte)50);//L
                sendIO(3, (byte)50);//R
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                sendIO(2, (byte)25);//L
                sendIO(3, (byte)25);//R
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                sendIO(2, (byte)25);//L
                sendIO(3, (byte)75);//R
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (state == 0)
            {
                sendIO(2, (byte)75);//L
                sendIO(3, (byte)25);//R
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (KeysPressed[0] == "w")
                {
                    KeysPressed[0] = "";
                }
                else
                {
                    KeysPressed[1] = "";
                }

            }
            if (e.KeyCode == Keys.S)
            {
                if (KeysPressed[0] == "s")
                {
                    KeysPressed[0] = "";
                }
                else
                {
                    KeysPressed[1] = "";
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if (KeysPressed[0] == "a")
                {
                    KeysPressed[0] = "";
                }
                else
                {
                    KeysPressed[1] = "";
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (KeysPressed[0] == "d")
                {
                    KeysPressed[0] = "";
                }
                else
                {
                    KeysPressed[1] = "";
                }
            }
            if (state == 0)
            {
                Key_Output(KeysPressed);
            }

        }



        private void IOtimer_tick_Tick(object sender, EventArgs e)
        {
            

            if (serial.IsOpen) //Check that a serial connection exists.
            {
                if (serial.BytesToRead >= 5) //Check that the buffer contains a full four byte package.
                {
                    //statusBox.Text = "Incoming"; // A status box can be used for debugging code.
                    Inputs[0] = (byte)serial.ReadByte(); //Read the first byte of the package.
                    if (Inputs[0] == START) //Check that the first byte is in fact the start byte.
                    {

                        //Read the rest of the package.
                        Inputs[1] = (byte)serial.ReadByte();
                        Inputs[2] = (byte)serial.ReadByte();
                        Inputs[3] = (byte)serial.ReadByte();
                        Inputs[4] = (byte)serial.ReadByte();

                        //Calculate the checksum.
                        byte checkSum = (byte)(Inputs[0] + Inputs[1] + Inputs[2] + Inputs[3]);
                     

                        //Check that the calculated check sum matches the checksum sent with the message.
                        if (Inputs[4] == checkSum)
                        {

                            if (state == 1)
                            {
                                ForwardLabel.ForeColor = Color.White;
                                BackLabel.ForeColor = Color.White;
                                RightLabel.ForeColor = Color.White;
                                LeftLabel.ForeColor = Color.White;

                                SensorLeft.BackColor = Color.Black;
                                SensorRight.BackColor = Color.Black;
                                switch (Inputs[3])
                                {
                                    case 38:
                                        statusBox1.Text = "Forwards";
                                        ForwardLabel.ForeColor = Color.Red;
                                        SensorLeft.BackColor = Color.White;
                                        SensorRight.BackColor = Color.White;
                                        break;

                                    case 40:
                                        statusBox1.Text = "Sway Right";
                                        ForwardLabel.ForeColor = Color.Red;
                                        RightLabel.ForeColor = Color.Red;
                                        SensorRight.BackColor = Color.White;
                                        break;

                                    case 42:
                                        statusBox1.Text = "Sway Left";
                                        ForwardLabel.ForeColor = Color.Red;
                                        LeftLabel.ForeColor = Color.Red;
                                        SensorLeft.BackColor = Color.White;
                                        break;

                                    case 44:
                                        statusBox1.Text = "Turning Right";
                                        RightLabel.ForeColor = Color.Red;
                                        break;

                                    case 46:
                                        statusBox1.Text = "Turning Left";
                                        LeftLabel.ForeColor = Color.Red;
                                        break;

                                }
                            }
                            status1 = Inputs[1];
                            status2 = Inputs[2];
                            progressBar1.Value = status1;
                            progressBar2.Value = status2;
                        }
                    }
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (state == 1)
            {
                state = 0;
                button1.Text = "Manual";
                button1.BackColor = Color.Cyan;
            }
            else if (state == 0)
            {
                state = 1;
                button1.Text = "AUTO";
                button1.BackColor = Color.Yellow;
            }
            sendIO(4, (byte)state);
        }
    }
}
