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
            this.velocityGroupBox = new System.Windows.Forms.GroupBox();
            this.determineVelocityButton = new System.Windows.Forms.Button();
            this.areaVelocityTextBox = new System.Windows.Forms.TextBox();
            this.flowRateVelocityTextBox = new System.Windows.Forms.TextBox();
            this.velocityAnswerTextBox = new System.Windows.Forms.Label();
            this.areaLabel2 = new System.Windows.Forms.Label();
            this.flowrateLabel2 = new System.Windows.Forms.Label();
            this.pressureGroupBox = new System.Windows.Forms.GroupBox();
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
            this.flowRateGroupBox = new System.Windows.Forms.GroupBox();
            this.enterVolumeLabelFlowrate = new System.Windows.Forms.Label();
            this.enterTimeFlowrate = new System.Windows.Forms.Label();
            this.flowrateAnswerLabel = new System.Windows.Forms.Label();
            this.enterVolumeTextBox = new System.Windows.Forms.TextBox();
            this.enterTimeTextBox = new System.Windows.Forms.TextBox();
            this.determineFlowRateButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.velocityGroupBox.SuspendLayout();
            this.pressureGroupBox.SuspendLayout();
            this.horsepowerGroupBox.SuspendLayout();
            this.flowRateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // determineHorsePowerbutton
            // 
            this.determineHorsePowerbutton.Location = new System.Drawing.Point(225, 33);
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
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "The horsepower is: ";
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
            // velocityGroupBox
            // 
            this.velocityGroupBox.Controls.Add(this.determineVelocityButton);
            this.velocityGroupBox.Controls.Add(this.areaVelocityTextBox);
            this.velocityGroupBox.Controls.Add(this.flowRateVelocityTextBox);
            this.velocityGroupBox.Controls.Add(this.velocityAnswerTextBox);
            this.velocityGroupBox.Controls.Add(this.areaLabel2);
            this.velocityGroupBox.Controls.Add(this.flowrateLabel2);
            this.velocityGroupBox.Location = new System.Drawing.Point(19, 281);
            this.velocityGroupBox.Name = "velocityGroupBox";
            this.velocityGroupBox.Size = new System.Drawing.Size(363, 102);
            this.velocityGroupBox.TabIndex = 6;
            this.velocityGroupBox.TabStop = false;
            this.velocityGroupBox.Text = "Velocity";
            // 
            // determineVelocityButton
            // 
            this.determineVelocityButton.Location = new System.Drawing.Point(225, 22);
            this.determineVelocityButton.Name = "determineVelocityButton";
            this.determineVelocityButton.Size = new System.Drawing.Size(115, 39);
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
            this.pressureGroupBox.Controls.Add(this.determinePressureButton);
            this.pressureGroupBox.Controls.Add(this.areaTextBox);
            this.pressureGroupBox.Controls.Add(this.forceTextBox);
            this.pressureGroupBox.Controls.Add(this.pressureAnswerTextBox);
            this.pressureGroupBox.Controls.Add(this.enterAreaLabel);
            this.pressureGroupBox.Controls.Add(this.enterForceLabel);
            this.pressureGroupBox.Location = new System.Drawing.Point(19, 158);
            this.pressureGroupBox.Name = "pressureGroupBox";
            this.pressureGroupBox.Size = new System.Drawing.Size(363, 104);
            this.pressureGroupBox.TabIndex = 5;
            this.pressureGroupBox.TabStop = false;
            this.pressureGroupBox.Text = "Pressure";
            // 
            // determinePressureButton
            // 
            this.determinePressureButton.Location = new System.Drawing.Point(225, 26);
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
            this.pressureAnswerTextBox.Location = new System.Drawing.Point(6, 75);
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
            this.enterForceLabel.Location = new System.Drawing.Point(6, 26);
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
            this.horsepowerGroupBox.Location = new System.Drawing.Point(19, 19);
            this.horsepowerGroupBox.Name = "horsepowerGroupBox";
            this.horsepowerGroupBox.Size = new System.Drawing.Size(363, 118);
            this.horsepowerGroupBox.TabIndex = 4;
            this.horsepowerGroupBox.TabStop = false;
            this.horsepowerGroupBox.Text = "Horsepower";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Flowrate (GPM)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Pressure (PSI)";
            // 
            // flowRatePowerTextBox
            // 
            this.flowRatePowerTextBox.Location = new System.Drawing.Point(120, 56);
            this.flowRatePowerTextBox.Name = "flowRatePowerTextBox";
            this.flowRatePowerTextBox.Size = new System.Drawing.Size(87, 20);
            this.flowRatePowerTextBox.TabIndex = 1;
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Location = new System.Drawing.Point(120, 30);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(87, 20);
            this.pressureTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowRateGroupBox
            // 
            this.flowRateGroupBox.Controls.Add(this.determineFlowRateButton);
            this.flowRateGroupBox.Controls.Add(this.enterTimeTextBox);
            this.flowRateGroupBox.Controls.Add(this.enterVolumeTextBox);
            this.flowRateGroupBox.Controls.Add(this.flowrateAnswerLabel);
            this.flowRateGroupBox.Controls.Add(this.enterTimeFlowrate);
            this.flowRateGroupBox.Controls.Add(this.enterVolumeLabelFlowrate);
            this.flowRateGroupBox.Location = new System.Drawing.Point(416, 19);
            this.flowRateGroupBox.Name = "flowRateGroupBox";
            this.flowRateGroupBox.Size = new System.Drawing.Size(363, 118);
            this.flowRateGroupBox.TabIndex = 7;
            this.flowRateGroupBox.TabStop = false;
            this.flowRateGroupBox.Text = "Flowrate";
            // 
            // enterVolumeLabelFlowrate
            // 
            this.enterVolumeLabelFlowrate.AutoSize = true;
            this.enterVolumeLabelFlowrate.Location = new System.Drawing.Point(6, 33);
            this.enterVolumeLabelFlowrate.Name = "enterVolumeLabelFlowrate";
            this.enterVolumeLabelFlowrate.Size = new System.Drawing.Size(103, 13);
            this.enterVolumeLabelFlowrate.TabIndex = 0;
            this.enterVolumeLabelFlowrate.Text = "Enter Volume (GPM)";
            // 
            // enterTimeFlowrate
            // 
            this.enterTimeFlowrate.AutoSize = true;
            this.enterTimeFlowrate.Location = new System.Drawing.Point(6, 59);
            this.enterTimeFlowrate.Name = "enterTimeFlowrate";
            this.enterTimeFlowrate.Size = new System.Drawing.Size(103, 13);
            this.enterTimeFlowrate.TabIndex = 1;
            this.enterTimeFlowrate.Text = "Enter Time (minutes)";
            // 
            // flowrateAnswerLabel
            // 
            this.flowrateAnswerLabel.AutoSize = true;
            this.flowrateAnswerLabel.Location = new System.Drawing.Point(6, 87);
            this.flowrateAnswerLabel.Name = "flowrateAnswerLabel";
            this.flowrateAnswerLabel.Size = new System.Drawing.Size(85, 13);
            this.flowrateAnswerLabel.TabIndex = 2;
            this.flowrateAnswerLabel.Text = "The Flowrate is: ";
            this.flowrateAnswerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterVolumeTextBox
            // 
            this.enterVolumeTextBox.Location = new System.Drawing.Point(120, 30);
            this.enterVolumeTextBox.Name = "enterVolumeTextBox";
            this.enterVolumeTextBox.Size = new System.Drawing.Size(87, 20);
            this.enterVolumeTextBox.TabIndex = 3;
            // 
            // enterTimeTextBox
            // 
            this.enterTimeTextBox.Location = new System.Drawing.Point(120, 56);
            this.enterTimeTextBox.Name = "enterTimeTextBox";
            this.enterTimeTextBox.Size = new System.Drawing.Size(87, 20);
            this.enterTimeTextBox.TabIndex = 4;
            // 
            // determineFlowRateButton
            // 
            this.determineFlowRateButton.Location = new System.Drawing.Point(227, 33);
            this.determineFlowRateButton.Name = "determineFlowRateButton";
            this.determineFlowRateButton.Size = new System.Drawing.Size(106, 39);
            this.determineFlowRateButton.TabIndex = 5;
            this.determineFlowRateButton.Text = "Determine Flowrate";
            this.determineFlowRateButton.UseVisualStyleBackColor = true;
            this.determineFlowRateButton.Click += new System.EventHandler(this.determineFlowRateButton_Click);
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
            this.velocityGroupBox.ResumeLayout(false);
            this.velocityGroupBox.PerformLayout();
            this.pressureGroupBox.ResumeLayout(false);
            this.pressureGroupBox.PerformLayout();
            this.horsepowerGroupBox.ResumeLayout(false);
            this.horsepowerGroupBox.PerformLayout();
            this.flowRateGroupBox.ResumeLayout(false);
            this.flowRateGroupBox.PerformLayout();
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
    }
}

