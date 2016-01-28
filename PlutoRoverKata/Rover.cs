﻿using System.Collections.Generic;

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
                    if (Heading == 'N')
                    {
                        Y += 1;
                    }
                    else if (Heading == 'S')
                    {
                        Y -= 1;
                    }
                    else
                    {
                        X = 1;
                    }
                    break;
                case 'B':
                    Y -= 1;
                    break;
                case 'R':
                    Heading = rightTurnHeadingMap[Heading];
                    break;
                case 'L':
                    Heading = leftTurnHeadingMap[Heading];
                    break;
            }
        }
    }
}
