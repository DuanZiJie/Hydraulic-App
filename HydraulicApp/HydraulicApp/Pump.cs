using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicApp
{
    class Pump
    {
        public double Displacement { get; set; }
        public double MaxPressure { get; set; }
        public double Efficiency { get; set; }
        public double MaxRPM { get; set; }
        public string Name { get; set; }

        public Pump(double displacement, double maxPressure, double maxRPM)
        {
            Displacement = displacement;
            MaxPressure = maxPressure;
            MaxRPM = maxRPM;
        }

        public double PumpOutletFlow(double RPM)
        {
            return RPM * Displacement / 231;
        }

        public void DetermineEffiency(double outputPower, double inputPower)
        {
            Efficiency = outputPower / inputPower * 100; // Efficiency is measured as a percent value, hence the * 100
        }

        public void DeterminePumpDisplacement(double flow, double RPM)
        {
            Displacement = flow * 231 / RPM;
        }

        public double GetMaxPower()
        {
            return MaxPressure * Displacement / 1714;
        }
    }
}
