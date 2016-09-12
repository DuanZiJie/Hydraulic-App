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
        double GPM = 0.0;
        double Flowrate;
        double PressureDrop;
        double OrificeDia;
        string CDValueString;

        Dictionary<string, double> CDValues = new Dictionary<string, double>();

        public Orifice()
        {
            CDValues.Add("KnifeEdge", 0.62);
            CDValues.Add("Rounded", 0.98);
            CDValues.Add("ShortL", 0.61);
            CDValues.Add("LongL", 0.82);
            CDValues.Add("RoundedL", 0.97);
            CDValues.Add("InletShortL", 0.54);
            CDValues.Add("InletLongL", 0.72);

        }

        static public double SingleOrificePressureDrop(Orifice orifice)
        {
            Orifice tempOrifice = orifice;
            double cDValue = 0.0;
            
            if(tempOrifice.CDValues.TryGetValue(tempOrifice.CDValueString, out cDValue)) { };

            return SpecificGravity * Math.Pow(tempOrifice.Flowrate / (29.81 * cDValue * Math.Pow(tempOrifice.OrificeDia, 2)), 2);
        }
    }
}
