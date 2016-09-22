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
        double testPressureDrop = 200.0;

        public Orifice CreateTestOrifice()
        {
            Orifice testOrifice = new Orifice(testOrificeDia, testOrificeShape);

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
            Assert.That(Orifice.SingleOrificePressureDrop(CreateTestOrifice(), testFlowrate), Is.EqualTo(239.81846151840664755622591284611));
        }
        [Test]
        public void ShouldDetermineFlowrate()
        {
            Assert.That(Orifice.SingleOrificeFlowrate(CreateTestOrifice(), testPressureDrop), Is.EqualTo(4.5660818883409391007710898646028));
        }
        [Test]
        public void ShouldSetDia()
        {
            Orifice orfice = CreateTestOrifice();
            orfice.Flowrate = testFlowrate;
            orfice.PressureDrop = testPressureDrop;
            orfice.SetDiaFromFlowAndPress();

            Assert.That(orfice.OrificeDia, Is.EqualTo(0.13080464522696772944222684916371));
        }
    }
}
