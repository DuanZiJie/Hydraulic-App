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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterDIALabel
            // 
            this.enterDIALabel.AutoSize = true;
            this.enterDIALabel.Location = new System.Drawing.Point(27, 78);
            this.enterDIALabel.Name = "enterDIALabel";
            this.enterDIALabel.Size = new System.Drawing.Size(93, 13);
            this.enterDIALabel.TabIndex = 0;
            this.enterDIALabel.Text = "Enter DIA (inches)";
            // 
            // enterDIATextBox
            // 
            this.enterDIATextBox.Location = new System.Drawing.Point(151, 71);
            this.enterDIATextBox.Name = "enterDIATextBox";
            this.enterDIATextBox.Size = new System.Drawing.Size(85, 20);
            this.enterDIATextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}