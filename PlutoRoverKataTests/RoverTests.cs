using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PlutoRoverKata;

namespace PlutoRoverKataTests
{
    public class RoverTests
    {
        [Test]
        public void Constructor_Valid()
        {
            var rover = new Rover(0, 0, 'N');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual('N', rover.Heading);
        }

        [Test]
        public void Command_Forward_Valid()
        {
            var rover = new Rover(0, 0, 'N');

            rover.Command('F');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(1, rover.Y);
            Assert.AreEqual('N', rover.Heading);
        }

        [Test]
        public void Command_Backward_Valid()
        {
            var rover = new Rover(0, 0, 'N');

            rover.Command('B');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(-1, rover.Y);
            Assert.AreEqual('N', rover.Heading);
        }

        [Test]
        public void Command_ForwardTwice_Valid()
        {
            var rover = new Rover(0, 0, 'N');

            rover.Command('F');
            rover.Command('F');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(2, rover.Y);
            Assert.AreEqual('N', rover.Heading);
        }

        [Test]
        public void Command_ForwardThenBackward_Valid()
        {
            var rover = new Rover(0, 0, 'N');

            rover.Command('F');
            rover.Command('B');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual('N', rover.Heading);
        }

        [Test]
        public void Command_Turn_Valid()
        {
            var rover = new Rover(0, 0, 'N');

            rover.Command('R');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual('E', rover.Heading);
        }

        [Test]
        public void Command_TurnLeft_Valid()
        {
            var rover = new Rover(0, 0, 'N');

            rover.Command('L');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual('W', rover.Heading);
        }

        [Test]
        public void Command_TurnRightTwice_Valid()
        {
            var rover = new Rover(0, 0, 'N');

            rover.Command('R');
            rover.Command('R');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual('S', rover.Heading);
        }

        [Test]
        public void Command_TurnRightThenLeft_Valid()
        {
            var rover = new Rover(0, 0, 'N');

            rover.Command('R');
            rover.Command('L');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual('N', rover.Heading);
        }

        [Test]
        public void Command_TurnRightFromEast_Valid()
        {
            var rover = new Rover(0, 0, 'E');

            rover.Command('R');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual('S', rover.Heading);
        }

        [Test]
        public void Command_TurnRightFromSouth_Valid()
        {
            var rover = new Rover(0, 0, 'S');

            rover.Command('R');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual('W', rover.Heading);
        }

        [Test]
        public void Command_TurnRightFromWest_Valid()
        {
            var rover = new Rover(0, 0, 'W');

            rover.Command('R');

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(0, rover.Y);
            Assert.AreEqual('N', rover.Heading);
        }
    }
}
