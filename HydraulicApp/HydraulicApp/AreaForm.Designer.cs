namespace HydraulicApp
{
    partial class AreaForm
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
            this.enterDIALabel = new System.Windows.Forms.Label();
            this.enterDIATextBox = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enterDIAWarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterDIALabel
            // 
            this.enterDIALabel.AutoSize = true;
            this.enterDIALabel.Location = new System.Drawing.Point(26, 36);
            this.enterDIALabel.Name = "enterDIALabel";
            this.enterDIALabel.Size = new System.Drawing.Size(93, 13);
            this.enterDIALabel.TabIndex = 0;
            this.enterDIALabel.Text = "Enter DIA (inches)";
            // 
            // enterDIATextBox
            // 
            this.enterDIATextBox.Location = new System.Drawing.Point(145, 36);
            this.enterDIATextBox.Name = "enterDIATextBox";
            this.enterDIATextBox.Size = new System.Drawing.Size(85, 20);
            this.enterDIATextBox.TabIndex = 1;
            this.enterDIATextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterDIATextBox_KeyDown);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(79, 118);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(99, 23);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pressing Continue will pass the calculated\r\narea in the previous window";
            // 
            // enterDIAWarningLabel
            // 
            this.enterDIAWarningLabel.AutoSize = true;
            this.enterDIAWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.enterDIAWarningLabel.Location = new System.Drawing.Point(142, 20);
            this.enterDIAWarningLabel.Name = "enterDIAWarningLabel";
            this.enterDIAWarningLabel.Size = new System.Drawing.Size(113, 13);
            this.enterDIAWarningLabel.TabIndex = 4;
            this.enterDIAWarningLabel.Text = "Please enter a number";
            this.enterDIAWarningLabel.Visible = false;
            // 
            // AreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.enterDIAWarningLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.enterDIATextBox);
            this.Controls.Add(this.enterDIALabel);
            this.Name = "AreaForm";
            this.Text = "Area Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterDIALabel;
        private System.Windows.Forms.TextBox enterDIATextBox;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enterDIAWarningLabel;
    }
}