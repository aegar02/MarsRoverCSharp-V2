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

        [TestMethod] //Test 5

        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("", commands);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Message name is required.", ex.Message);
            }

        }

        [TestMethod] //Test 6
        public void ConstructorSetsName()
        {
            Message message1 = new Message("Name", commands);
            Assert.AreEqual(message1.Name, "Name");
        }

        [TestMethod] //Test 7
        public void ConstructorSetsCommandsField()
        {
            Message message2 = new Message("Name", commands);
            Assert.AreEqual(message2.Commands, commands);
        }

    }

    
}
