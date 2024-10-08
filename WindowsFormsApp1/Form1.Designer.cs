namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.statusBox1 = new System.Windows.Forms.TextBox();
            this.IOtimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SensorRight = new System.Windows.Forms.Button();
            this.SensorLeft = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.RightLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PCB = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.Button();
            this.RightTrack = new System.Windows.Forms.Button();
            this.LeftTrack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ForwardLabel = new System.Windows.Forms.Label();
            this.BackLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.PortName = "COM9";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 123);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(206, 24);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Manual";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // statusBox1
            // 
            this.statusBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox1.Location = new System.Drawing.Point(30, 44);
            this.statusBox1.Name = "statusBox1";
            this.statusBox1.Size = new System.Drawing.Size(206, 28);
            this.statusBox1.TabIndex = 4;
            // 
            // IOtimer
            // 
            this.IOtimer.Enabled = true;
            this.IOtimer.Interval = 10;
            this.IOtimer.Tick += new System.EventHandler(this.IOtimer_tick_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Black;
            this.progressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar2.Location = new System.Drawing.Point(44, 163);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(206, 22);
            this.progressBar2.TabIndex = 10;
            this.progressBar2.Value = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "AUTO/Manual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ForwardButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.LeftButton);
            this.panel1.Controls.Add(this.RightButton);
            this.panel1.Location = new System.Drawing.Point(102, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 206);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Keyboard Control Shadow";
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ForwardButton.Enabled = false;
            this.ForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardButton.Location = new System.Drawing.Point(153, 56);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(125, 58);
            this.ForwardButton.TabIndex = 0;
            this.ForwardButton.Text = "Forward/W";
            this.ForwardButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackButton.Enabled = false;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(153, 120);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 58);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Backwards/S";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // LeftButton
            // 
            this.LeftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LeftButton.Enabled = false;
            this.LeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.Location = new System.Drawing.Point(33, 120);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(114, 58);
            this.LeftButton.TabIndex = 2;
            this.LeftButton.Text = "Left/A";
            this.LeftButton.UseVisualStyleBackColor = false;
            // 
            // RightButton
            // 
            this.RightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RightButton.Enabled = false;
            this.RightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.ForeColor = System.Drawing.Color.Black;
            this.RightButton.Location = new System.Drawing.Point(284, 120);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(114, 58);
            this.RightButton.TabIndex = 3;
            this.RightButton.Text = "Right/D";
            this.RightButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motor Duty Cycles";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.SensorRight);
            this.panel2.Controls.Add(this.SensorLeft);
            this.panel2.Location = new System.Drawing.Point(21, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 219);
            this.panel2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "and Sensor Readings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(195, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "L";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "L";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "R";
            // 
            // SensorRight
            // 
            this.SensorRight.BackColor = System.Drawing.Color.Black;
            this.SensorRight.Enabled = false;
            this.SensorRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SensorRight.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SensorRight.Location = new System.Drawing.Point(158, 80);
            this.SensorRight.Name = "SensorRight";
            this.SensorRight.Size = new System.Drawing.Size(31, 33);
            this.SensorRight.TabIndex = 12;
            this.SensorRight.UseVisualStyleBackColor = false;
            // 
            // SensorLeft
            // 
            this.SensorLeft.BackColor = System.Drawing.Color.Black;
            this.SensorLeft.Enabled = false;
            this.SensorLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SensorLeft.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SensorLeft.Location = new System.Drawing.Point(91, 80);
            this.SensorLeft.Name = "SensorLeft";
            this.SensorLeft.Size = new System.Drawing.Size(31, 33);
            this.SensorLeft.TabIndex = 11;
            this.SensorLeft.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(21, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 124);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.statusBox1);
            this.panel4.ForeColor = System.Drawing.Color.Coral;
            this.panel4.Location = new System.Drawing.Point(341, 506);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 96);
            this.panel4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(62, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Current State";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.LeftLabel);
            this.panel5.Controls.Add(this.RightLabel);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.PCB);
            this.panel5.Controls.Add(this.Body);
            this.panel5.Controls.Add(this.RightTrack);
            this.panel5.Controls.Add(this.LeftTrack);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.ForwardLabel);
            this.panel5.Controls.Add(this.BackLabel);
            this.panel5.Location = new System.Drawing.Point(341, 237);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 251);
            this.panel5.TabIndex = 16;
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftLabel.ForeColor = System.Drawing.Color.White;
            this.LeftLabel.Location = new System.Drawing.Point(48, 109);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(48, 51);
            this.LeftLabel.TabIndex = 8;
            this.LeftLabel.Text = "<";
            // 
            // RightLabel
            // 
            this.RightLabel.AutoSize = true;
            this.RightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightLabel.ForeColor = System.Drawing.Color.White;
            this.RightLabel.Location = new System.Drawing.Point(182, 109);
            this.RightLabel.Name = "RightLabel";
            this.RightLabel.Size = new System.Drawing.Size(51, 54);
            this.RightLabel.TabIndex = 7;
            this.RightLabel.Text = ">";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(118, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // PCB
            // 
            this.PCB.BackColor = System.Drawing.Color.Green;
            this.PCB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PCB.Enabled = false;
            this.PCB.Location = new System.Drawing.Point(118, 92);
            this.PCB.Name = "PCB";
            this.PCB.Size = new System.Drawing.Size(41, 67);
            this.PCB.TabIndex = 4;
            this.PCB.UseVisualStyleBackColor = false;
            // 
            // Body
            // 
            this.Body.Enabled = false;
            this.Body.Location = new System.Drawing.Point(118, 102);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(41, 86);
            this.Body.TabIndex = 1;
            this.Body.UseVisualStyleBackColor = true;
            // 
            // RightTrack
            // 
            this.RightTrack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RightTrack.Enabled = false;
            this.RightTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightTrack.Location = new System.Drawing.Point(153, 110);
            this.RightTrack.Name = "RightTrack";
            this.RightTrack.Size = new System.Drawing.Size(19, 61);
            this.RightTrack.TabIndex = 3;
            this.RightTrack.UseVisualStyleBackColor = false;
            // 
            // LeftTrack
            // 
            this.LeftTrack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeftTrack.Enabled = false;
            this.LeftTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftTrack.Location = new System.Drawing.Point(103, 110);
            this.LeftTrack.Name = "LeftTrack";
            this.LeftTrack.Size = new System.Drawing.Size(19, 61);
            this.LeftTrack.TabIndex = 2;
            this.LeftTrack.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Motion Visualization";
            // 
            // ForwardLabel
            // 
            this.ForwardLabel.AutoSize = true;
            this.ForwardLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForwardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardLabel.ForeColor = System.Drawing.Color.White;
            this.ForwardLabel.Location = new System.Drawing.Point(113, 44);
            this.ForwardLabel.Name = "ForwardLabel";
            this.ForwardLabel.Size = new System.Drawing.Size(59, 69);
            this.ForwardLabel.TabIndex = 9;
            this.ForwardLabel.Text = "^";
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackLabel.ForeColor = System.Drawing.Color.White;
            this.BackLabel.Location = new System.Drawing.Point(119, 180);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(40, 46);
            this.BackLabel.TabIndex = 10;
            this.BackLabel.Text = "v";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 617);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Line following robot GUI";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TextBox statusBox1;
        private System.Windows.Forms.Timer IOtimer;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Body;
        private System.Windows.Forms.Button RightTrack;
        private System.Windows.Forms.Button PCB;
        private System.Windows.Forms.Button LeftTrack;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.Label RightLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ForwardLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.Button SensorLeft;
        private System.Windows.Forms.Button SensorRight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

