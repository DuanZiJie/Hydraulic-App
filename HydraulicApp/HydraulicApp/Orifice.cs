using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicApp
{
    class Orifice
    {
        static double SpecificGravity = 0.8; // This value is only for hydraulic fluid.
        double GPM { get; set; }
        double Flowrate { get; set; }
        double PressureDrop { get; set; }
        double OrificeDia { get; set; }
        double CDValue { get; set; }
        string CDValueString { get; set; }

        static double[] OrificeValues = { .62, .98, .61, .82, .97, .54, .72 };
        static string[] OrificeDescriptions = { "KnifeEdge" , "Rounded" , "ShortL", "LongL" , "RoundedL", "InletShortL", "InletLongL" };

        public Orifice()
        {

        }

        public Orifice(double GPM, double Flowrate, double OrificeDia, string CDValueString)
        {
            this.GPM = GPM;
            this.Flowrate = Flowrate;
            this.OrificeDia = OrificeDia;
            try
            {
                this.DetermineCDValue(this);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DetermineCDValue(Orifice orifice)
        {
            try
            {
                this.CDValue = ReturnCDValue(orifice);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        private double ReturnCDValue(Orifice orifice)
        {
            for(int x = 0; x < OrificeDescriptions.Length; ++x)
            {
                if (orifice.CDValueString.Equals(OrificeDescriptions[x]))
                {
                    return OrificeValues[x];
                }
            }
            CDValueException e = new CDValueException();
            throw e;
        }

        static public double SingleOrificePressureDrop(Orifice orifice)
        {
            Orifice tempOrifice = orifice;
            
            return SpecificGravity * Math.Pow(tempOrifice.Flowrate / (29.81 * orifice.CDValue * Math.Pow(tempOrifice.OrificeDia, 2)), 2);
        }
    }
}
