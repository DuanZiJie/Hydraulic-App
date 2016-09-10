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

        string PressureDropHeatLabelText = "The Added Heat is: ";
        string CoolingCapityLabelText = "The Cooling Capacity is: ";
        string BTUToHorsepowerLabelText = "The Horsepower is: ";
        string HeatInFreshWaterLabelText = "The Heat is: ";

        string AreaLabelText = "The Area is: ";
        string CylinderSpeedAnswerText = "The Speed is: ";
        string VolumeLabelText = "The Volume is: ";

        public Form1()
        {
            InitializeComponent();
            heatByPressureDropAnswerTextBox.Text = PressureDropHeatLabelText;
            BTUToHorsepowerAnswerLabel.Text = BTUToHorsepowerLabelText;
            heatInWaterAnswer.Text = HeatInFreshWaterLabelText;
            areaOfRodEndAnswerLabel.Text = AreaLabelText;
            cylSpeedAnswerLabel.Text = CylinderSpeedAnswerText;
            cylSpeedRodEndAnswerLabel.Text = CylinderSpeedAnswerText;
            cylinderVolumeCapEndAnswerLabel.Text = VolumeLabelText;
            cylinderVolumeRodEndAnswerLabel.Text = VolumeLabelText;
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

            if (Double.TryParse(flowRateVelocityTextBox.Text, out flowRate) && Double.TryParse(areaVelocityTextBox.Text, out area))
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
        }

        private void areaCalcVelocityLabel_Click(object sender, EventArgs e)
        {
            AreaForm temp = new AreaForm();
            temp.ShowDialog(this);
            areaVelocityTextBox.Text = temp.NewArea.ToString("F2");
            temp.Dispose();
        }

        private void areaCalcCylSpeedlabel_Click(object sender, EventArgs e)
        {
            AreaForm temp = new AreaForm();
            temp.ShowDialog(this);
            areaCylSpeedTextBox.Text = temp.NewArea.ToString("F2");
            temp.Dispose();
        }

        private void areaCalcPistonAreaLabel_Click(object sender, EventArgs e)
        {
            AreaForm temp = new AreaForm();
            temp.ShowDialog(this);
            pistonAreaRodSpeedTextBox.Text = temp.NewArea.ToString("F2");
            temp.Dispose();
        }

        private void areaCalcRodLabel_Click(object sender, EventArgs e)
        {
            AreaForm temp = new AreaForm();
            temp.ShowDialog(this);
            rodAreaTextBox.Text = temp.NewArea.ToString("F2");
            temp.Dispose();
        }

        private void capEndVolumeAreaLabel_Click(object sender, EventArgs e)
        {
            AreaForm temp = new AreaForm();
            temp.ShowDialog(this);
            enterPistonAreaVolumeTextBox.Text = temp.NewArea.ToString("F2");
            temp.Dispose();
        }
        private void rodEndCapVolumeAreaLabel_Click(object sender, EventArgs e)
        {
            AreaForm temp = new AreaForm();
            temp.ShowDialog(this);
            pistonAreaRodEndTextBox.Text = temp.NewArea.ToString("F2");
            temp.Dispose();
        }
        private void rodEndRodVolumeAreaLabel_Click(object sender, EventArgs e)
        {
            AreaForm temp = new AreaForm();
            temp.ShowDialog(this);
            rodAreaVolumeTextBox.Text = temp.NewArea.ToString("F2");
            temp.Dispose();
        }

        private void determineHeatByPressureButton_Click(object sender, EventArgs e)
        {
            double PressureDrop;
            double Flowrate;

            if (Double.TryParse(pressureDropTextBox.Text, out PressureDrop) && (Double.TryParse(flowrateHeatTextBox.Text, out Flowrate)))
                heatByPressureDropAnswerTextBox.Text = PressureDropHeatLabelText + Thermal.HeatCausedByPressureDrop(Flowrate, PressureDrop).ToString("F2") + " BTU/HR";
        }

        private void determineCoolingButton_Click(object sender, EventArgs e)
        {
            double TempDifference;
            double SurfaceArea;

            if (Double.TryParse(tempDiffCoolingTextbox.Text, out TempDifference) && (Double.TryParse(surfaceAreaCoolingTextBox.Text, out SurfaceArea)))
                coolingCapacityAnswerLabel.Text = CoolingCapityLabelText + Thermal.ReservoirCoolingCapacity(TempDifference, SurfaceArea).ToString("F2") + " BTU/HR";
        }

        private void DetermiineHorsepowerFromBTUButton_Click(object sender, EventArgs e)
        {
            double BTU;

            if (Double.TryParse(enterBTUTextBox.Text, out BTU))
                BTUToHorsepowerAnswerLabel.Text = BTUToHorsepowerLabelText + Thermal.BTUToHorsepower(BTU).ToString("F2") + " HP";

        }

        private void DetermineHeatInWaterBUtton_Click(object sender, EventArgs e)
        {
            double TempDiff;
            double Flowrate;

            if (Double.TryParse(tempDiffWaterTextBox.Text, out TempDiff) && (Double.TryParse(flowrateHeatInWaterTextBox.Text, out Flowrate)))
                heatInWaterAnswer.Text = HeatInFreshWaterLabelText + Thermal.HeatInFreshWater(Flowrate, TempDiff).ToString("F2") + " BTU/HR";
        }

        private void determineAreaOfRodEndButton_Click(object sender, EventArgs e)
        {
            double DiaOfCylinder;
            double DiaOfRod;

            if (Double.TryParse(cylinderDiaTextBox.Text, out DiaOfCylinder) && Double.TryParse(cylinderRodDiaTextBox.Text, out DiaOfRod))
                areaOfRodEndAnswerLabel.Text = AreaLabelText + Cylinder.CylinderAreaRodEnd(DiaOfCylinder, DiaOfRod).ToString("F2") + " in^2";
        }

        private void determineCylSpeedButton_Click(object sender, EventArgs e)
        {
            double Flowrate;
            double Area;

            if(Double.TryParse(flowrateCylSpedTextBox.Text, out Flowrate) && Double.TryParse(areaCylSpeedTextBox.Text, out Area))
            {
                cylSpeedAnswerLabel.Text = CylinderSpeedAnswerText + Cylinder.CylinderSpeed(Flowrate, Area).ToString("F2") + " feet per second";
            }
        }

        private void determineCylinderSpeedRodEnd_Click(object sender, EventArgs e)
        {
            double Flowrate;
            double PistonArea;
            double RodArea;

            if(Double.TryParse(flowrateRodEndTextBox.Text, out Flowrate) && Double.TryParse(pistonAreaRodSpeedTextBox.Text, out PistonArea) && Double.TryParse(rodAreaTextBox.Text, out RodArea))
                cylSpeedRodEndAnswerLabel.Text = CylinderSpeedAnswerText + Cylinder.CylinderSpeedRodEnd(Flowrate, PistonArea, RodArea).ToString("F2") + " feet per second";
        }

        private void determineVolumeRodEndButton_Click(object sender, EventArgs e)
        {
            double Stroke;
            double Area;

            if (Double.TryParse(cylinderStrokeTextBox.Text, out Stroke) && Double.TryParse(enterPistonAreaVolumeTextBox.Text, out Area))
                cylinderVolumeCapEndAnswerLabel.Text = VolumeLabelText + Cylinder.CylinderVolume(Stroke, Area).ToString("F2") + " Gallons";

        }

        private void determineVolumeRodEndButton_Click_1(object sender, EventArgs e)
        {
            double Stroke;
            double PistonArea;
            double RodArea;

            if (Double.TryParse(cylinderStrokeRodEndTextBox.Text, out Stroke) && Double.TryParse(pistonAreaRodEndTextBox.Text, out PistonArea) && Double.TryParse(rodAreaVolumeTextBox.Text, out RodArea))
                cylinderVolumeRodEndAnswerLabel.Text = VolumeLabelText + Cylinder.CylinderVolumeRodEnd(Stroke, PistonArea, RodArea).ToString("F2") + " Gallons";
        }
    }
}
