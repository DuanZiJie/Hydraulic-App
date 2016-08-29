using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydraulicApp
{
    public partial class AreaForm : Form
    {
        public double NewArea { get; set; }

        public AreaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double DIA;

            if (Double.TryParse(enterDIATextBox.Text, out DIA))
            {
                NewArea = Basic.AreaOfCircle(DIA);
                this.Hide();
            }
            else
            {
                enterDIAWarningLabel.Show();
            }
        }
    }
}
