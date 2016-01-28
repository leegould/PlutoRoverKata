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
            Heading = 'N';
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
                    if (Heading == 'N')
                    {
                        Heading = 'E';
                    }
                    else
                    {
                        Heading = 'S';
                    }
                    break;
                case 'L':
                    Heading = 'W';
                    break;
            }
        }
    }
}
