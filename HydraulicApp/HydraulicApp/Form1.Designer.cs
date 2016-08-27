namespace HydraulicApp
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
            this.determineHorsePowerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowRateGroupBox = new System.Windows.Forms.GroupBox();
            this.determineFlowRateButton = new System.Windows.Forms.Button();
            this.enterTimeTextBox = new System.Windows.Forms.TextBox();
            this.enterVolumeTextBox = new System.Windows.Forms.TextBox();
            this.flowrateAnswerLabel = new System.Windows.Forms.Label();
            this.enterTimeFlowrate = new System.Windows.Forms.Label();
            this.enterVolumeLabelFlowrate = new System.Windows.Forms.Label();
            this.velocityGroupBox = new System.Windows.Forms.GroupBox();
            this.areaVelocityCalcLabel = new System.Windows.Forms.Label();
            this.determineVelocityButton = new System.Windows.Forms.Button();
            this.areaVelocityTextBox = new System.Windows.Forms.TextBox();
            this.flowRateVelocityTextBox = new System.Windows.Forms.TextBox();
            this.velocityAnswerTextBox = new System.Windows.Forms.Label();
            this.areaLabel2 = new System.Windows.Forms.Label();
            this.flowrateLabel2 = new System.Windows.Forms.Label();
            this.pressureGroupBox = new System.Windows.Forms.GroupBox();
            this.areaCalcLabel = new System.Windows.Forms.Label();
            this.determinePressureButton = new System.Windows.Forms.Button();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.forceTextBox = new System.Windows.Forms.TextBox();
            this.pressureAnswerTextBox = new System.Windows.Forms.Label();
            this.enterAreaLabel = new System.Windows.Forms.Label();
            this.enterForceLabel = new System.Windows.Forms.Label();
            this.horsepowerGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowRatePowerTextBox = new System.Windows.Forms.TextBox();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DetermiineHorsepowerFromBTUButton = new System.Windows.Forms.Button();
            this.enterBTUTextBox = new System.Windows.Forms.TextBox();
            this.BTUToHorsepowerAnswerLabel = new System.Windows.Forms.Label();
            this.enterBTULabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.determineCoolingButton = new System.Windows.Forms.Button();
            this.surfaceAreaCoolingTextBox = new System.Windows.Forms.TextBox();
            this.tempDiffCoolingTextbox = new System.Windows.Forms.TextBox();
            this.coolingCapacityAnswerLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.heatByPressureDropAnswerTextBox = new System.Windows.Forms.Label();
            this.determineHeatByPressureButton = new System.Windows.Forms.Button();
            this.flowrateHeatTextBox = new System.Windows.Forms.TextBox();
            this.pressureDropTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowRateGroupBox.SuspendLayout();
            this.velocityGroupBox.SuspendLayout();
            this.pressureGroupBox.SuspendLayout();
            this.horsepowerGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // determineHorsePowerbutton
            // 
            this.determineHorsePowerbutton.Location = new System.Drawing.Point(235, 22);
            this.determineHorsePowerbutton.Name = "determineHorsePowerbutton";
            this.determineHorsePowerbutton.Size = new System.Drawing.Size(115, 39);
            this.determineHorsePowerbutton.TabIndex = 2;
            this.determineHorsePowerbutton.Text = "Determine Horsepower";
            this.determineHorsePowerbutton.UseVisualStyleBackColor = true;
            this.determineHorsePowerbutton.Click += new System.EventHandler(this.determineHorsepowerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Horsepower is: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 443);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowRateGroupBox);
            this.tabPage1.Controls.Add(this.velocityGroupBox);
            this.tabPage1.Controls.Add(this.pressureGroupBox);
            this.tabPage1.Controls.Add(this.horsepowerGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fluid";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowRateGroupBox
            // 
            this.flowRateGroupBox.Controls.Add(this.determineFlowRateButton);
            this.flowRateGroupBox.Controls.Add(this.enterTimeTextBox);
            this.flowRateGroupBox.Controls.Add(this.enterVolumeTextBox);
            this.flowRateGroupBox.Controls.Add(this.flowrateAnswerLabel);
            this.flowRateGroupBox.Controls.Add(this.enterTimeFlowrate);
            this.flowRateGroupBox.Controls.Add(this.enterVolumeLabelFlowrate);
            this.flowRateGroupBox.Location = new System.Drawing.Point(440, 20);
            this.flowRateGroupBox.Name = "flowRateGroupBox";
            this.flowRateGroupBox.Size = new System.Drawing.Size(380, 100);
            this.flowRateGroupBox.TabIndex = 7;
            this.flowRateGroupBox.TabStop = false;
            this.flowRateGroupBox.Text = "Flowrate";
            // 
            // determineFlowRateButton
            // 
            this.determineFlowRateButton.Location = new System.Drawing.Point(235, 22);
            this.determineFlowRateButton.Name = "determineFlowRateButton";
            this.determineFlowRateButton.Size = new System.Drawing.Size(106, 39);
            this.determineFlowRateButton.TabIndex = 5;
            this.determineFlowRateButton.Text = "Determine Flowrate";
            this.determineFlowRateButton.UseVisualStyleBackColor = true;
            this.determineFlowRateButton.Click += new System.EventHandler(this.determineFlowRateButton_Click);
            // 
            // enterTimeTextBox
            // 
            this.enterTimeTextBox.Location = new System.Drawing.Point(120, 45);
            this.enterTimeTextBox.Name = "enterTimeTextBox";
            this.enterTimeTextBox.Size = new System.Drawing.Size(87, 20);
            this.enterTimeTextBox.TabIndex = 4;
            // 
            // enterVolumeTextBox
            // 
            this.enterVolumeTextBox.Location = new System.Drawing.Point(120, 19);
            this.enterVolumeTextBox.Name = "enterVolumeTextBox";
            this.enterVolumeTextBox.Size = new System.Drawing.Size(87, 20);
            this.enterVolumeTextBox.TabIndex = 3;
            // 
            // flowrateAnswerLabel
            // 
            this.flowrateAnswerLabel.AutoSize = true;
            this.flowrateAnswerLabel.Location = new System.Drawing.Point(6, 76);
            this.flowrateAnswerLabel.Name = "flowrateAnswerLabel";
            this.flowrateAnswerLabel.Size = new System.Drawing.Size(85, 13);
            this.flowrateAnswerLabel.TabIndex = 2;
            this.flowrateAnswerLabel.Text = "The Flowrate is: ";
            this.flowrateAnswerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterTimeFlowrate
            // 
            this.enterTimeFlowrate.AutoSize = true;
            this.enterTimeFlowrate.Location = new System.Drawing.Point(6, 48);
            this.enterTimeFlowrate.Name = "enterTimeFlowrate";
            this.enterTimeFlowrate.Size = new System.Drawing.Size(103, 13);
            this.enterTimeFlowrate.TabIndex = 1;
            this.enterTimeFlowrate.Text = "Enter Time (minutes)";
            // 
            // enterVolumeLabelFlowrate
            // 
            this.enterVolumeLabelFlowrate.AutoSize = true;
            this.enterVolumeLabelFlowrate.Location = new System.Drawing.Point(6, 22);
            this.enterVolumeLabelFlowrate.Name = "enterVolumeLabelFlowrate";
            this.enterVolumeLabelFlowrate.Size = new System.Drawing.Size(93, 13);
            this.enterVolumeLabelFlowrate.TabIndex = 0;
            this.enterVolumeLabelFlowrate.Text = "Enter Volume (gal)";
            // 
            // velocityGroupBox
            // 
            this.velocityGroupBox.Controls.Add(this.areaVelocityCalcLabel);
            this.velocityGroupBox.Controls.Add(this.determineVelocityButton);
            this.velocityGroupBox.Controls.Add(this.areaVelocityTextBox);
            this.velocityGroupBox.Controls.Add(this.flowRateVelocityTextBox);
            this.velocityGroupBox.Controls.Add(this.velocityAnswerTextBox);
            this.velocityGroupBox.Controls.Add(this.areaLabel2);
            this.velocityGroupBox.Controls.Add(this.flowrateLabel2);
            this.velocityGroupBox.Location = new System.Drawing.Point(20, 260);
            this.velocityGroupBox.Name = "velocityGroupBox";
            this.velocityGroupBox.Size = new System.Drawing.Size(380, 100);
            this.velocityGroupBox.TabIndex = 6;
            this.velocityGroupBox.TabStop = false;
            this.velocityGroupBox.Text = "Velocity";
            // 
            // areaVelocityCalcLabel
            // 
            this.areaVelocityCalcLabel.AutoSize = true;
            this.areaVelocityCalcLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.areaVelocityCalcLabel.Location = new System.Drawing.Point(213, 48);
            this.areaVelocityCalcLabel.Name = "areaVelocityCalcLabel";
            this.areaVelocityCalcLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.areaVelocityCalcLabel.Size = new System.Drawing.Size(13, 13);
            this.areaVelocityCalcLabel.TabIndex = 6;
            this.areaVelocityCalcLabel.Text = "?";
            this.areaVelocityCalcLabel.UseMnemonic = false;
            this.areaVelocityCalcLabel.Click += new System.EventHandler(this.areaCalcVelocityLabel_Click);
            // 
            // determineVelocityButton
            // 
            this.determineVelocityButton.Location = new System.Drawing.Point(235, 22);
            this.determineVelocityButton.Name = "determineVelocityButton";
            this.determineVelocityButton.Size = new System.Drawing.Size(109, 39);
            this.determineVelocityButton.TabIndex = 5;
            this.determineVelocityButton.Text = "Determine Velocity";
            this.determineVelocityButton.UseVisualStyleBackColor = true;
            this.determineVelocityButton.Click += new System.EventHandler(this.determineVelocityButton_Click);
            // 
            // areaVelocityTextBox
            // 
            this.areaVelocityTextBox.Location = new System.Drawing.Point(120, 45);
            this.areaVelocityTextBox.Name = "areaVelocityTextBox";
            this.areaVelocityTextBox.Size = new System.Drawing.Size(87, 20);
            this.areaVelocityTextBox.TabIndex = 4;
            // 
            // flowRateVelocityTextBox
            // 
            this.flowRateVelocityTextBox.Location = new System.Drawing.Point(120, 19);
            this.flowRateVelocityTextBox.Name = "flowRateVelocityTextBox";
            this.flowRateVelocityTextBox.Size = new System.Drawing.Size(87, 20);
            this.flowRateVelocityTextBox.TabIndex = 3;
            // 
            // velocityAnswerTextBox
            // 
            this.velocityAnswerTextBox.AutoSize = true;
            this.velocityAnswerTextBox.Location = new System.Drawing.Point(6, 76);
            this.velocityAnswerTextBox.Name = "velocityAnswerTextBox";
            this.velocityAnswerTextBox.Size = new System.Drawing.Size(81, 13);
            this.velocityAnswerTextBox.TabIndex = 2;
            this.velocityAnswerTextBox.Text = "The velocity is: ";
            // 
            // areaLabel2
            // 
            this.areaLabel2.AutoSize = true;
            this.areaLabel2.Location = new System.Drawing.Point(6, 48);
            this.areaLabel2.Name = "areaLabel2";
            this.areaLabel2.Size = new System.Drawing.Size(86, 13);
            this.areaLabel2.TabIndex = 1;
            this.areaLabel2.Text = "Enter Area (in^2)";
            // 
            // flowrateLabel2
            // 
            this.flowrateLabel2.AutoSize = true;
            this.flowrateLabel2.Location = new System.Drawing.Point(6, 22);
            this.flowrateLabel2.Name = "flowrateLabel2";
            this.flowrateLabel2.Size = new System.Drawing.Size(108, 13);
            this.flowrateLabel2.TabIndex = 0;
            this.flowrateLabel2.Text = "Enter Flowrate (GPM)";
            // 
            // pressureGroupBox
            // 
            this.pressureGroupBox.Controls.Add(this.areaCalcLabel);
            this.pressureGroupBox.Controls.Add(this.determinePressureButton);
            this.pressureGroupBox.Controls.Add(this.areaTextBox);
            this.pressureGroupBox.Controls.Add(this.forceTextBox);
            this.pressureGroupBox.Controls.Add(this.pressureAnswerTextBox);
            this.pressureGroupBox.Controls.Add(this.enterAreaLabel);
            this.pressureGroupBox.Controls.Add(this.enterForceLabel);
            this.pressureGroupBox.Location = new System.Drawing.Point(20, 140);
            this.pressureGroupBox.Name = "pressureGroupBox";
            this.pressureGroupBox.Size = new System.Drawing.Size(380, 100);
            this.pressureGroupBox.TabIndex = 5;
            this.pressureGroupBox.TabStop = false;
            this.pressureGroupBox.Text = "Pressure";
            // 
            // areaCalcLabel
            // 
            this.areaCalcLabel.AutoSize = true;
            this.areaCalcLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.areaCalcLabel.Location = new System.Drawing.Point(213, 48);
            this.areaCalcLabel.Name = "areaCalcLabel";
            this.areaCalcLabel.Size = new System.Drawing.Size(13, 13);
            this.areaCalcLabel.TabIndex = 6;
            this.areaCalcLabel.Text = "?";
            this.areaCalcLabel.Click += new System.EventHandler(this.areaCalcLabel_Click);
            // 
            // determinePressureButton
            // 
            this.determinePressureButton.Location = new System.Drawing.Point(235, 22);
            this.determinePressureButton.Name = "determinePressureButton";
            this.determinePressureButton.Size = new System.Drawing.Size(115, 35);
            this.determinePressureButton.TabIndex = 5;
            this.determinePressureButton.Text = "Determine Pressure";
            this.determinePressureButton.UseVisualStyleBackColor = true;
            this.determinePressureButton.Click += new System.EventHandler(this.determinePressureButton_Click);
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(120, 45);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(87, 20);
            this.areaTextBox.TabIndex = 4;
            // 
            // forceTextBox
            // 
            this.forceTextBox.Location = new System.Drawing.Point(120, 19);
            this.forceTextBox.Name = "forceTextBox";
            this.forceTextBox.Size = new System.Drawing.Size(87, 20);
            this.forceTextBox.TabIndex = 3;
            // 
            // pressureAnswerTextBox
            // 
            this.pressureAnswerTextBox.AutoSize = true;
            this.pressureAnswerTextBox.Location = new System.Drawing.Point(6, 76);
            this.pressureAnswerTextBox.Name = "pressureAnswerTextBox";
            this.pressureAnswerTextBox.Size = new System.Drawing.Size(85, 13);
            this.pressureAnswerTextBox.TabIndex = 2;
            this.pressureAnswerTextBox.Text = "The pressure is: ";
            // 
            // enterAreaLabel
            // 
            this.enterAreaLabel.AutoSize = true;
            this.enterAreaLabel.Location = new System.Drawing.Point(6, 48);
            this.enterAreaLabel.Name = "enterAreaLabel";
            this.enterAreaLabel.Size = new System.Drawing.Size(86, 13);
            this.enterAreaLabel.TabIndex = 1;
            this.enterAreaLabel.Text = "Enter Area (in^2)";
            // 
            // enterForceLabel
            // 
            this.enterForceLabel.AutoSize = true;
            this.enterForceLabel.Location = new System.Drawing.Point(6, 22);
            this.enterForceLabel.Name = "enterForceLabel";
            this.enterForceLabel.Size = new System.Drawing.Size(84, 13);
            this.enterForceLabel.TabIndex = 0;
            this.enterForceLabel.Text = "Enter Force (lbs)";
            // 
            // horsepowerGroupBox
            // 
            this.horsepowerGroupBox.Controls.Add(this.label3);
            this.horsepowerGroupBox.Controls.Add(this.label2);
            this.horsepowerGroupBox.Controls.Add(this.flowRatePowerTextBox);
            this.horsepowerGroupBox.Controls.Add(this.pressureTextBox);
            this.horsepowerGroupBox.Controls.Add(this.label1);
            this.horsepowerGroupBox.Controls.Add(this.determineHorsePowerbutton);
            this.horsepowerGroupBox.Location = new System.Drawing.Point(20, 20);
            this.horsepowerGroupBox.Name = "horsepowerGroupBox";
            this.horsepowerGroupBox.Size = new System.Drawing.Size(380, 100);
            this.horsepowerGroupBox.TabIndex = 4;
            this.horsepowerGroupBox.TabStop = false;
            this.horsepowerGroupBox.Text = "Horsepower";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Flowrate (GPM)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Pressure (PSI)";
            // 
            // flowRatePowerTextBox
            // 
            this.flowRatePowerTextBox.Location = new System.Drawing.Point(120, 45);
            this.flowRatePowerTextBox.Name = "flowRatePowerTextBox";
            this.flowRatePowerTextBox.Size = new System.Drawing.Size(87, 20);
            this.flowRatePowerTextBox.TabIndex = 1;
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Location = new System.Drawing.Point(120, 19);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(87, 20);
            this.pressureTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thermal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DetermiineHorsepowerFromBTUButton);
            this.groupBox3.Controls.Add(this.enterBTUTextBox);
            this.groupBox3.Controls.Add(this.BTUToHorsepowerAnswerLabel);
            this.groupBox3.Controls.Add(this.enterBTULabel);
            this.groupBox3.Location = new System.Drawing.Point(20, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BTU to Horsepower";
            // 
            // DetermiineHorsepowerFromBTUButton
            // 
            this.DetermiineHorsepowerFromBTUButton.Location = new System.Drawing.Point(235, 22);
            this.DetermiineHorsepowerFromBTUButton.Name = "DetermiineHorsepowerFromBTUButton";
            this.DetermiineHorsepowerFromBTUButton.Size = new System.Drawing.Size(75, 23);
            this.DetermiineHorsepowerFromBTUButton.TabIndex = 5;
            this.DetermiineHorsepowerFromBTUButton.Text = "Determine Horsepower";
            this.DetermiineHorsepowerFromBTUButton.UseVisualStyleBackColor = true;
            this.DetermiineHorsepowerFromBTUButton.Click += new System.EventHandler(this.DetermiineHorsepowerFromBTUButton_Click);
            // 
            // enterBTUTextBox
            // 
            this.enterBTUTextBox.Location = new System.Drawing.Point(120, 19);
            this.enterBTUTextBox.Name = "enterBTUTextBox";
            this.enterBTUTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterBTUTextBox.TabIndex = 3;
            // 
            // BTUToHorsepowerAnswerLabel
            // 
            this.BTUToHorsepowerAnswerLabel.AutoSize = true;
            this.BTUToHorsepowerAnswerLabel.Location = new System.Drawing.Point(6, 48);
            this.BTUToHorsepowerAnswerLabel.Name = "BTUToHorsepowerAnswerLabel";
            this.BTUToHorsepowerAnswerLabel.Size = new System.Drawing.Size(10, 13);
            this.BTUToHorsepowerAnswerLabel.TabIndex = 1;
            this.BTUToHorsepowerAnswerLabel.Text = "-";
            // 
            // enterBTULabel
            // 
            this.enterBTULabel.AutoSize = true;
            this.enterBTULabel.Location = new System.Drawing.Point(6, 22);
            this.enterBTULabel.Name = "enterBTULabel";
            this.enterBTULabel.Size = new System.Drawing.Size(78, 13);
            this.enterBTULabel.TabIndex = 0;
            this.enterBTULabel.Text = "Enter BTU/HR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.determineCoolingButton);
            this.groupBox2.Controls.Add(this.surfaceAreaCoolingTextBox);
            this.groupBox2.Controls.Add(this.tempDiffCoolingTextbox);
            this.groupBox2.Controls.Add(this.coolingCapacityAnswerLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(20, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tank Cooling Capacity";
            // 
            // determineCoolingButton
            // 
            this.determineCoolingButton.Location = new System.Drawing.Point(235, 22);
            this.determineCoolingButton.Name = "determineCoolingButton";
            this.determineCoolingButton.Size = new System.Drawing.Size(90, 55);
            this.determineCoolingButton.TabIndex = 5;
            this.determineCoolingButton.Text = "Determine Cooling Capacity";
            this.determineCoolingButton.UseVisualStyleBackColor = true;
            this.determineCoolingButton.Click += new System.EventHandler(this.determineCoolingButton_Click);
            // 
            // surfaceAreaCoolingTextBox
            // 
            this.surfaceAreaCoolingTextBox.Location = new System.Drawing.Point(120, 45);
            this.surfaceAreaCoolingTextBox.Name = "surfaceAreaCoolingTextBox";
            this.surfaceAreaCoolingTextBox.Size = new System.Drawing.Size(100, 20);
            this.surfaceAreaCoolingTextBox.TabIndex = 4;
            // 
            // tempDiffCoolingTextbox
            // 
            this.tempDiffCoolingTextbox.Location = new System.Drawing.Point(120, 19);
            this.tempDiffCoolingTextbox.Name = "tempDiffCoolingTextbox";
            this.tempDiffCoolingTextbox.Size = new System.Drawing.Size(100, 20);
            this.tempDiffCoolingTextbox.TabIndex = 3;
            // 
            // coolingCapacityAnswerLabel
            // 
            this.coolingCapacityAnswerLabel.AutoSize = true;
            this.coolingCapacityAnswerLabel.Location = new System.Drawing.Point(6, 76);
            this.coolingCapacityAnswerLabel.Name = "coolingCapacityAnswerLabel";
            this.coolingCapacityAnswerLabel.Size = new System.Drawing.Size(124, 13);
            this.coolingCapacityAnswerLabel.TabIndex = 2;
            this.coolingCapacityAnswerLabel.Text = "The Cooling Capacity is: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Enter Surf. Area (sqft)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter Temp Diff (°F)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.heatByPressureDropAnswerTextBox);
            this.groupBox1.Controls.Add(this.determineHeatByPressureButton);
            this.groupBox1.Controls.Add(this.flowrateHeatTextBox);
            this.groupBox1.Controls.Add(this.pressureDropTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heat Caused by Pressure Loss";
            // 
            // heatByPressureDropAnswerTextBox
            // 
            this.heatByPressureDropAnswerTextBox.AutoSize = true;
            this.heatByPressureDropAnswerTextBox.Location = new System.Drawing.Point(6, 76);
            this.heatByPressureDropAnswerTextBox.Name = "heatByPressureDropAnswerTextBox";
            this.heatByPressureDropAnswerTextBox.Size = new System.Drawing.Size(10, 13);
            this.heatByPressureDropAnswerTextBox.TabIndex = 5;
            this.heatByPressureDropAnswerTextBox.Text = "-";
            // 
            // determineHeatByPressureButton
            // 
            this.determineHeatByPressureButton.Location = new System.Drawing.Point(235, 22);
            this.determineHeatByPressureButton.Name = "determineHeatByPressureButton";
            this.determineHeatByPressureButton.Size = new System.Drawing.Size(90, 33);
            this.determineHeatByPressureButton.TabIndex = 4;
            this.determineHeatByPressureButton.Text = "Determine Heat";
            this.determineHeatByPressureButton.UseVisualStyleBackColor = true;
            this.determineHeatByPressureButton.Click += new System.EventHandler(this.determineHeatByPressureButton_Click);
            // 
            // flowrateHeatTextBox
            // 
            this.flowrateHeatTextBox.Location = new System.Drawing.Point(120, 45);
            this.flowrateHeatTextBox.Name = "flowrateHeatTextBox";
            this.flowrateHeatTextBox.Size = new System.Drawing.Size(100, 20);
            this.flowrateHeatTextBox.TabIndex = 3;
            // 
            // pressureDropTextBox
            // 
            this.pressureDropTextBox.Location = new System.Drawing.Point(120, 19);
            this.pressureDropTextBox.Name = "pressureDropTextBox";
            this.pressureDropTextBox.Size = new System.Drawing.Size(100, 20);
            this.pressureDropTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter Flowrate (GPM)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Press. Drop (PSI)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Hydraulic Test";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowRateGroupBox.ResumeLayout(false);
            this.flowRateGroupBox.PerformLayout();
            this.velocityGroupBox.ResumeLayout(false);
            this.velocityGroupBox.PerformLayout();
            this.pressureGroupBox.ResumeLayout(false);
            this.pressureGroupBox.PerformLayout();
            this.horsepowerGroupBox.ResumeLayout(false);
            this.horsepowerGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button determineHorsePowerbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.TextBox flowRatePowerTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox horsepowerGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox pressureGroupBox;
        private System.Windows.Forms.Button determinePressureButton;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox forceTextBox;
        private System.Windows.Forms.Label pressureAnswerTextBox;
        private System.Windows.Forms.Label enterAreaLabel;
        private System.Windows.Forms.Label enterForceLabel;
        private System.Windows.Forms.GroupBox velocityGroupBox;
        private System.Windows.Forms.Button determineVelocityButton;
        private System.Windows.Forms.TextBox areaVelocityTextBox;
        private System.Windows.Forms.TextBox flowRateVelocityTextBox;
        private System.Windows.Forms.Label velocityAnswerTextBox;
        private System.Windows.Forms.Label areaLabel2;
        private System.Windows.Forms.Label flowrateLabel2;
        private System.Windows.Forms.GroupBox flowRateGroupBox;
        private System.Windows.Forms.Button determineFlowRateButton;
        private System.Windows.Forms.TextBox enterTimeTextBox;
        private System.Windows.Forms.TextBox enterVolumeTextBox;
        private System.Windows.Forms.Label flowrateAnswerLabel;
        private System.Windows.Forms.Label enterTimeFlowrate;
        private System.Windows.Forms.Label enterVolumeLabelFlowrate;
        private System.Windows.Forms.Label areaCalcLabel;
        private System.Windows.Forms.Label areaVelocityCalcLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label heatByPressureDropAnswerTextBox;
        private System.Windows.Forms.Button determineHeatByPressureButton;
        private System.Windows.Forms.TextBox flowrateHeatTextBox;
        private System.Windows.Forms.TextBox pressureDropTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox surfaceAreaCoolingTextBox;
        private System.Windows.Forms.TextBox tempDiffCoolingTextbox;
        private System.Windows.Forms.Label coolingCapacityAnswerLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button determineCoolingButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox enterBTUTextBox;
        private System.Windows.Forms.Label BTUToHorsepowerAnswerLabel;
        private System.Windows.Forms.Label enterBTULabel;
        private System.Windows.Forms.Button DetermiineHorsepowerFromBTUButton;
    }
}

