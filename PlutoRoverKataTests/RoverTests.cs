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
        public class ConstructorTests
        {
            [Test]
            public void Constructor_Valid()
            {
                var rover = new Rover(0, 0, 'N');

                Assert.AreEqual(0, rover.X);
                Assert.AreEqual(0, rover.Y);
                Assert.AreEqual('N', rover.Heading);
            }
        }

        public class MovementTests
        {
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
                Assert.AreEqual(100, rover.Y);
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
            public void Command_ForwardFromNonOrigin_Valid()
            {
                var rover = new Rover(1, 1, 'N');

                rover.Command('F');

                Assert.AreEqual(1, rover.X);
                Assert.AreEqual(2, rover.Y);
                Assert.AreEqual('N', rover.Heading);
            }
        }

        public class HeadingTests
        {
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

            [Test]
            public void Command_TurnLeftFromWest_Valid()
            {
                var rover = new Rover(0, 0, 'W');

                rover.Command('L');

                Assert.AreEqual(0, rover.X);
                Assert.AreEqual(0, rover.Y);
                Assert.AreEqual('S', rover.Heading);
            }

            [Test]
            public void Command_TurnLeftFromSouth_Valid()
            {
                var rover = new Rover(0, 0, 'S');

                rover.Command('L');

                Assert.AreEqual(0, rover.X);
                Assert.AreEqual(0, rover.Y);
                Assert.AreEqual('E', rover.Heading);
            }

            [Test]
            public void Command_TurnLeftFromEast_Valid()
            {
                var rover = new Rover(0, 0, 'E');

                rover.Command('L');

                Assert.AreEqual(0, rover.X);
                Assert.AreEqual(0, rover.Y);
                Assert.AreEqual('N', rover.Heading);
            }
        }

        public class MovementAndHeadingsTests
        {
            [Test]
            public void Command_TurnRightFromNorth_MoveForward_Valid()
            {
                var rover = new Rover(0, 0, 'N');

                rover.Command('R');
                rover.Command('F');
                rover.Command('F');

                Assert.AreEqual(2, rover.X);
                Assert.AreEqual(0, rover.Y);
                Assert.AreEqual('E', rover.Heading);
            }

            [Test]
            public void Command_TurnRightFromNorthTwice_MoveForward_Valid()
            {
                var rover = new Rover(0, 0, 'N');

                rover.Command('R');
                rover.Command('R');
                rover.Command('F');

                Assert.AreEqual(0, rover.X);
                Assert.AreEqual(100, rover.Y);
                Assert.AreEqual('S', rover.Heading);
            }

            [Test]
            public void Command_TurnRightFromNorthThreeTimes_MoveForwardTwice_Valid()
            {
                var rover = new Rover(0, 0, 'N');

                rover.Command('R');
                rover.Command('R');
                rover.Command('R');
                rover.Command('F');
                rover.Command('F');

                Assert.AreEqual(99, rover.X);
                Assert.AreEqual(0, rover.Y);
                Assert.AreEqual('W', rover.Heading);
            }

            [Test]
            public void Command_TurnLeftFromNorth_MoveBackward_Valid()
            {
                var rover = new Rover(0, 0, 'N');

                rover.Command('L');
                rover.Command('B');
                rover.Command('B');

                Assert.AreEqual(2, rover.X);
                Assert.AreEqual(0, rover.Y);
                Assert.AreEqual('W', rover.Heading);
            }

            [Test]
            public void Command_TurnLeftFromNorthTwice_MoveBackward_Valid()
            {
                var rover = new Rover(0, 0, 'N');

                rover.Command('L');
                rover.Command('L');
                rover.Command('B');

                Assert.AreEqual(0, rover.X);
                Assert.AreEqual(1, rover.Y);
                Assert.AreEqual('S', rover.Heading);
            }

            [Test]
            public void Command_TurnLeftFromNorthThreeTimes_MoveBackwardsTwice_Valid()
            {
                var rover = new Rover(0, 0, 'N');

                rover.Command('L');
                rover.Command('L');
                rover.Command('L');
                rover.Command('B');
                rover.Command('B');

                Assert.AreEqual(99, rover.X);
                Assert.AreEqual(0, rover.Y);
                Assert.AreEqual('E', rover.Heading);
            }
        }

        public class SequenceOfCommandsTests
        {
            [Test]
            public void Command_Sequence_Valid()
            {
                var rover = new Rover(0, 0, 'N');

                rover.Command("FFRFF");

                Assert.AreEqual(2, rover.X);
                Assert.AreEqual(2, rover.Y);
                Assert.AreEqual('E', rover.Heading);
            }
        }

        public class VaryingMaxGridSizeTests
        {
            [Test]
            public void Command_SequenceVaryingGridSize_Valid()
            {
                var rover = new Rover(0, 0, 'N', 200, 200);

                rover.Command("RRFF");

                Assert.AreEqual(0, rover.X);
                Assert.AreEqual(199, rover.Y);
                Assert.AreEqual('S', rover.Heading);
            }
        }

        public class ObstacleTests
        {
            [Test]
            public void Command_Sequence_WithObstacles_Throws()
            {
                var obstacles = new List<Obstacle> { new Obstacle { X = 0, Y = 2 } };
                var rover = new Rover(0, 0, 'N', 200, 200, obstacles);

                Assert.Throws<ObstacleException>(() => rover.Command("FF"));

                Assert.AreEqual(0, rover.X);
                Assert.AreEqual(1, rover.Y);
                Assert.AreEqual('N', rover.Heading);
            }
        }
    }
}
