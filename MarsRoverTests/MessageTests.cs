using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using System.Collections.Generic;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {

        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };

        [TestMethod]

        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("", commands);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Name is required.", ex.Message);
            }

        }

        [TestMethod]
        public void ConstructorSetsName()
        {
            Message message1 = new Message("Rover", commands);
            Assert.AreEqual(message1.Name, "Rover");
        }

        [TestMethod]
        public void ConstructorSetsCommandsField()
        {
            Message message2 = new Message("Rover", commands);
            Assert.AreEqual(message2.Commands[0], commands[0]);
        }

    }

    
}
