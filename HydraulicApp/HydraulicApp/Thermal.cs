using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicApp
{
    static class Thermal
    {
        static public double ReservoirCoolingCapacity(double tempDifference, double surfaceArea)
        {
            return 2 * tempDifference * surfaceArea;
        }

        static public double HeatInHydOil(double flowRate, double tempDifference)
        {
            return flowRate * tempDifference * 210;
        }

        static public double HeatInFreshWater(double flowRate, double tempDifference)
        {
            return flowRate * 500 * tempDifference;
        }

        static public double HeatCausedByPressureDrop(double flowRate, double pressureDrop)
        {
            return flowRate * 1.485 * pressureDrop;
        }
    }
}
