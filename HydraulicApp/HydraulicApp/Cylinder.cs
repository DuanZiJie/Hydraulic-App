using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraulicApp
{
    class Cylinder
    {
        public static double CylinderAreaCapEnd(double diaOfPiston)
        {
            return Math.Pow(Math.PI * diaOfPiston, 2);
        }

        public static double CylinderAreaRodEnd(double diaOfPiston, double diaOfRod)
        {
            return Math.PI * Math.Pow((diaOfPiston/2), 2) - Math.PI * Math.Pow((diaOfRod/2),2);
        }

        public static double CylinderForce(double pressure, double area)
        {
            return pressure * area;
        }
        
        public static double CylinderSpeed(double flowRate, double cylinderArea)
        {
            return (231 * flowRate) / (12 * 60 * cylinderArea);
        }

        public static double CylinderSpeedRodEnd(double flowRate, double pistonArea, double rodArea)
        {
            return (231 * flowRate) / (12 * 60 * (pistonArea - rodArea));
        }

        public static double CylinderVolume(double cylinderStroke, double area)
        {
            return cylinderStroke * area / 231;
        }

        public static double CylinderVolumeRodEnd(double cylinderStroke, double pistonArea, double rodArea)
        {
            return (cylinderStroke * pistonArea / 231) - (cylinderStroke * rodArea / 231);
        }

        public static double CylinderFlowRate(double velocity, double area)
        {
            return (60 * velocity * area) / 231;
        }
    }
}
