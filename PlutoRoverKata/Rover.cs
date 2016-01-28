using System;
using System.Collections.Generic;
using System.Data;

namespace PlutoRoverKata
{
    public class Rover
    {
        readonly Dictionary<char, char> rightTurnHeadingMap = new Dictionary<char, char>
        {
            { 'N', 'E' },
            { 'E', 'S' },
            { 'S', 'W' },
            { 'W', 'N' }
        };

        readonly Dictionary<char, char> leftTurnHeadingMap = new Dictionary<char, char>
        {
            { 'N', 'W' },
            { 'W', 'S' },
            { 'S', 'E' },
            { 'E', 'N' }
        };
        
        public Rover(int x, int y, char heading)
        {
            X = x;
            Y = y;
            Heading = heading;
            XMax = 100;
            YMax = 100;
        }

        public Rover(int x, int y, char heading, int xmax, int ymax) : this(x, y, heading)
        {
            XMax = xmax;
            YMax = ymax;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public char Heading { get; set; }
        public int XMax { get; set; }
        public int YMax { get; set; }

        public void Command(char cmd)
        {
            switch (cmd)
            {
                case 'F':
                    switch (Heading)
                    {
                        case 'N':
                            Y += 1;
                            break;
                        case 'S':
                            Y -= 1;
                            break;
                        case 'W':
                            X -= 1;
                            break;
                        default:
                            X += 1;
                            break;
                    }
                    break;
                case 'B':
                    switch (Heading)
                    {
                        case 'N':
                            Y -= 1;
                            break;
                        case 'S':
                            Y += 1;
                            break;
                        case 'E':
                            X -= 1;
                            break;
                        default:
                            X += 1;
                            break;
                    }
                    break;
                case 'R':
                    Heading = rightTurnHeadingMap[Heading];
                    break;
                case 'L':
                    Heading = leftTurnHeadingMap[Heading];
                    break;
            }

            if (X < 0)
            {
                X = XMax;
            }

            if (Y < 0)
            {
                Y = YMax;
            }
        }

        public void Command(string commands)
        {
            foreach (var cmd in commands)
            {
                Command(cmd);
            }
        }
    }
}
