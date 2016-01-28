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
    }
}
