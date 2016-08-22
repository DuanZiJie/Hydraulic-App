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
        string HorsepowerLabelText = "The Horsepower is: ";
        string PressureLabelText = "The Pressure is: ";
        string VelocityLabelText = "The velocity is: ";
        string FlowrateLabelText = "The Flowrate is: ";

        static double TempArea { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(double area)
        {
            areaTextBox.Text =  area.ToString("F2");
        }

        private void determineHorsepowerButton_Click(object sender, EventArgs e)
        {
            double pressure;
            double flow;

            if (Double.TryParse(pressureTextBox.Text, out pressure) && Double.TryParse(flowRatePowerTextBox.Text, out flow))
                label1.Text = HorsepowerLabelText + Basic.Horsepower(pressure, flow).ToString("F2") + " hp";
        }

        private void determinePressureButton_Click(object sender, EventArgs e)
        {
            double area;
            double force;

            if(Double.TryParse(areaTextBox.Text, out area) && (Double.TryParse(forceTextBox.Text, out force)))
                pressureAnswerTextBox.Text = PressureLabelText + Basic.FluidPressure(force, area).ToString("F2") + " PSI";
        }

        private void determineVelocityButton_Click(object sender, EventArgs e)
        {
            double area;
            double flowRate;

            if (Double.TryParse(flowRateVelocityTextBox.Text, out flowRate) && Double.TryParse(flowRateVelocityTextBox.Text, out area))
                velocityAnswerTextBox.Text = VelocityLabelText + Misc.FluidVelocity(flowRate, area).ToString("F2") + " feet per second";
        }

        private void determineFlowRateButton_Click(object sender, EventArgs e)
        {
            double volume;
            double time;

            if (Double.TryParse(enterTimeTextBox.Text, out time) && Double.TryParse(enterVolumeTextBox.Text, out volume))
                flowrateAnswerLabel.Text = FlowrateLabelText + Basic.FluidFlowRate(volume, time).ToString("F2") + " GPM";
        }

        private void areaCalcLabel_Click(object sender, EventArgs e)
        {
            AreaForm temp = new AreaForm();

            temp.ShowDialog(this);
            areaTextBox.Text = temp.NewArea.ToString("F2");

            temp.Dispose();
            //areaTextBox.Text = TempArea.ToString("F3");  
        }
    }
}
