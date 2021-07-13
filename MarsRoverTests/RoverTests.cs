using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void ConstructorSetsDefaultPosition()
        {
            Rover newRover = new Rover(5);
            Assert.AreEqual(newRover.Position, 5);
        }

        [TestMethod]
        public void ConstructorSetsDefaultMode()
        {
            Rover newRover = new Rover(5);
            Assert.AreEqual(newRover.Mode, "Normal");
        }

        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover newRover = new Rover(0);
            Assert.AreEqual(newRover.GeneratorWatts, 110);
        }

        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        { 
            Rover newRover = new Rover(98382, "MODE_CHANGE");
            Assert.AreEqual(newRover.Mode, "Low Power");
   
        }

        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Rover newRover = new Rover(98382, "MODE_CHANGE");
            Assert.AreEqual(newRover.Position, 0);

        }

        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
            Rover newRover = new Rover(98382, "NORMAL");
            Assert.AreEqual(newRover.Position, 98382);
        }
        
    }   
}
