using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoRoverKata
{
    public class Rover
    {
        public Rover(int x, int y, char heading)
        {
            X = 0;
            Y = y;
            Heading = heading;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public char Heading { get; set; }

        public void Command(char cmd)
        {
            switch (cmd)
            {
                case 'F':
                    Y += 1;
                    break;
                case 'B':
                    Y -= 1;
                    break;
                case 'R':
                    switch (Heading)
                    {
                        case 'N':
                            Heading = 'E';
                            break;
                        case 'E':
                            Heading = 'S';
                            break;
                        case 'S':
                            Heading = 'W';
                            break;
                        default:
                            Heading = 'N';
                            break;
                    }
                    break;
                case 'L':
                    if (Heading == 'N')
                    {
                        Heading = 'W';
                    }
                    else
                    {
                        Heading = 'N';
                    }
                    break;
            }
        }
    }
}
