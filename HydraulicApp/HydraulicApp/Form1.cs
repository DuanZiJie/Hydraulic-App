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

        private void determineHorsepowerButton_Click(object sender, EventArgs e)
        {
            double pressure;
            double flow;

            if (Double.TryParse(pressureTextBox.Text, out pressure) && Double.TryParse(flowRatePowerTextBox.Text, out flow))
                label1.Text = label1.Text + Basic.Horsepower(pressure, flow).ToString("F2") + " hp";
        }

        private void determinePressureButton_Click(object sender, EventArgs e)
        {
            double area;
            double force;

            if(Double.TryParse(areaTextBox.Text, out area) && (Double.TryParse(forceTextBox.Text, out force)))
                pressureAnswerTextBox.Text = pressureAnswerTextBox.Text + Basic.FluidPressure(force, area).ToString("F2") + " PSI";
        }

        private void determineVelocityButton_Click(object sender, EventArgs e)
        {
            double area;
            double flowRate;

            if (Double.TryParse(flowRateVelocityTextBox.Text, out flowRate) && Double.TryParse(flowRateVelocityTextBox.Text, out area))
                velocityAnswerTextBox.Text = velocityAnswerTextBox.Text + Misc.FluidVelocity(flowRate, area).ToString("F2") + " feet per second";
        }

        private void determineFlowRateButton_Click(object sender, EventArgs e)
        {
            double volume;
            double time;

            if (Double.TryParse(enterTimeTextBox.Text, out time) && Double.TryParse(enterVolumeTextBox.Text, out volume))
                flowrateAnswerLabel.Text = flowrateAnswerLabel.Text + Basic.FluidFlowRate(volume, time).ToString("F2") + " GPM";
        }
    }
}
