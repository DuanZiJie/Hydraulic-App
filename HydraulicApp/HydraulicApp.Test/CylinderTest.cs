using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HydraulicApp.Test
{
    [TestFixture]
    public class CylinderTest
    {
        [Test]
        public void ShouldDetermineCylinderSpeedCapEnd()
        {
            double flowrate = 30.0;
            double area = 50.265482457436691815402294132472; // This is dia 8 inches
            Assert.That(Cylinder.CylinderSpeed(flowrate, area), Is.EqualTo(2.2977994908892389101632593336907));
        }
        [Test]
        public void ShouldDetermneCylinderSpeedRodEnd()
        {
            double flowrate = 30.0;
            double pistonArea = 50.265482457436691815402294132472; // This is dia 8 inches
            double rodArea = 12.566370614359172953850573533118; // This is dia 4 inches
            Assert.That(Cylinder.CylinderSpeedRodEnd(flowrate, pistonArea, rodArea), Is.EqualTo(3.063732654518985213551012444921));
        }
    }
}
