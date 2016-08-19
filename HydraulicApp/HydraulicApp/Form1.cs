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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pressure;
            double flow;

            if (Double.TryParse(pressureTextBox.Text, out pressure) && Double.TryParse(flowTextBox.Text, out flow))
                label1.Text = Convert.ToString(Basic.Horsepower(pressure, flow));
        }
    }
}
