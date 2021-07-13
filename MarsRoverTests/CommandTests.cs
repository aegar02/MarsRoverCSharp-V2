using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using System;

namespace MarsRoverTests
{
    [TestClass]
    public class CommandTests
    {

        [TestMethod] //Test 1
        public void ArgumentNullExceptionThrownIfCommandTypeIsNullOrEmpty()
        {
            try
            {
                new Command("");
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Command type required.", ex.Message);
            }
        }

        [TestMethod] //Test 2
        public void ConstructorSetsCommandType()
        {
            Command newCommand = new Command("MOVE", 0);
            Assert.AreEqual(newCommand.CommandType, "MOVE");
        }

        [TestMethod] //Test 3
        public void ConstructorSetsInitialNewPositionValue()
        {
            Command newCommand = new Command("MOVE", 20);
            Assert.AreEqual(newCommand.NewPostion, 20);
        }

        [TestMethod] //Test 4
        public void ConstructorSetsInitialNewModeValue()
        {
            Command newCommand = new Command("MODE_CHANGE", "LOW_POWER");
            Assert.AreEqual(newCommand.NewMode, "LOW_POWER");
        }
    }
}
