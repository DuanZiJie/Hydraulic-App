using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicApp
{
    static class Misc
    {
        static public double LeverTorque(double leverLength, double pullPounds)
        {
            return leverLength * pullPounds;
        }

        static public double AreaOfPiston(double pistonDia)
        {
            return Math.Pow(Math.PI * (pistonDia / 2), 2);
        }

        static public double FluidVelocity(double flow, double area)
        {
            return (0.3208 * flow) / area;
        }

        static public double KilowattsToHeat(double weight, double specificHeat, double temperatureDifference)
        {
            return (weight * specificHeat * temperatureDifference) / 3413;
        }
    }
}
