using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicApp
{
    public class Orifice
    {
        static double SpecificGravity = 0.8; // This value is only for hydraulic fluid, but so is this program.
        public double Flowrate { get; set; }
        public double PressureDrop { get; set; }
        public double OrificeDia { get; set; }
        public double CDValue { get; set; }
        public string CDValueString { get; set; }

        static double[] OrificeValues = { .62, .98, .61, .82, .97, .54, .72 };
        static string[] OrificeDescriptions = { "Knife Edge" , "Rounded" , "Short L", "Long L" , "Rounded L", "Inlet Short L", "Inlet Long L" };

        public Orifice()
        {

        }

        public Orifice(double OrificeDia, string CDValueString)
        {
            this.OrificeDia = OrificeDia;
            this.CDValueString = CDValueString;
            try
            {
                this.CDValue = this.ReturnCDValue();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private double ReturnCDValue()
        {
            for(int x = 0; x < OrificeDescriptions.Length; ++x)
            {
                if (this.CDValueString.Equals(OrificeDescriptions[x]))
                {
                    return OrificeValues[x];
                }
            }
            CDValueException e = new CDValueException();
            throw e;
        }

        static public double SingleOrificePressureDrop(Orifice orifice, double flowrate)
        {            
            return SpecificGravity * Math.Pow(flowrate / (29.81 * orifice.CDValue * Math.Pow(orifice.OrificeDia, 2)), 2);
        }

        static public double SingleOrificeFlowrate(Orifice orifice, double pressureDrop)
        {
            return 29.81 * orifice.CDValue * Math.Pow(orifice.OrificeDia, 2) * Math.Sqrt(pressureDrop / SpecificGravity);
        }

        public void SetDiaFromFlowAndPress()
        {
            this.OrificeDia = Math.Sqrt((Flowrate * Math.Sqrt(SpecificGravity / PressureDrop)) / (29.81 * CDValue));
        }
    }
}
