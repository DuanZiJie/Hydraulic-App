using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HydraulicApp.Test
{
    [TestFixture]
    class OrificeTest
    {
        double testFlowrate = 5.0;
        double testOrificeDia = .125;
        string testOrificeShape = "Knife Edge";

        public Orifice CreateTestOrifice()
        {
            Orifice testOrifice = new Orifice(testFlowrate, testOrificeDia, testOrificeShape);

            return testOrifice;
        }

        [Test]
        public void ShouldReturnCDValue()
        {
            Assert.That(CreateTestOrifice().CDValue, Is.EqualTo(.62));
        }
        [Test]
        public void ShouldDeterminePressureDrop()
        {
            Assert.That(Orifice.SingleOrificePressureDrop(CreateTestOrifice()), Is.EqualTo(239.81846151840664755622591284611));
        }
    }
}
