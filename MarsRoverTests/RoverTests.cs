using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod] //Test 8
        public void ConstructorSetsDefaultPosition()
        {
            Rover newRover = new Rover(5);
            Assert.AreEqual(newRover.Position, 5);
        }

        [TestMethod] //Test 9
        public void ConstructorSetsDefaultMode()
        {
            Rover newRover = new Rover(5);
            Assert.AreEqual(newRover.Mode, "NORMAL");
        }

        [TestMethod] //Test 10
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover newRover = new Rover(5);
            Assert.AreEqual(newRover.GeneratorWatts, 110, .001);
        }

        [TestMethod] //Test 11
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER") };
            Message newMessage = new Message("Rover", commands);
            Rover newRover = new Rover(98382, "MODE_CHANGE");
            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(newRover.Mode, "LOW_POWER");
   
        }

        [TestMethod] //Test 12
        public void DoesNotMoveInLowPower()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER") };
            Message newMessage = new Message("Rover", commands);
            Rover newRover = new Rover(0, "MODE_CHANGE");
            Assert.AreEqual(newRover.Position, 0);

        }

        [TestMethod] //Test 13
        public void PositionChangesFromMoveCommand()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER") };
            Message newMessage = new Message("Rover", commands);
            Rover newRover = new Rover(5000);
            Assert.AreEqual(newRover.Position, 5000);
        }
        
    }   
}
