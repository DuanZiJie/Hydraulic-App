using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicApp
{
    static class Basic
    {
        static public double FluidPressure(double force, double area)
        {
            return force / area;
        }

        static public double FluidFlowRate(double volume, double time)
        {
            return volume / time;
        }

        static public double Horsepower(double pressure, double flow)
        {
            return pressure * flow / 1714;
        }

        static public double Compressibility(double bulkModulus)
        {
            return 1 / bulkModulus;
        }

        static public double SpecificGravity(double weight)
        {
            return weight / 62.4283;
        }
    }
}
