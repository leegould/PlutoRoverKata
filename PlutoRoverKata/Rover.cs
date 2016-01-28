using System.Collections.Generic;
using System.Linq;

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
        
        public Rover(int x, int y, char heading, int xmax = 100, int ymax = 100, List<Obstacle> obstacles = null)
        {
            X = x;
            Y = y;
            Heading = heading;
            XMax = xmax;
            YMax = ymax;
            Obstacles = obstacles;
        }
        
        public int X { get; set; }
        public int Y { get; set; }
        public char Heading { get; set; }
        public int XMax { get; set; }
        public int YMax { get; set; }

        public List<Obstacle> Obstacles { get; set; } 

        public void Command(char cmd)
        {
            var newx = X;
            var newy = Y;

            switch (cmd)
            {
                case 'F':
                    switch (Heading)
                    {
                        case 'N':
                            newy += 1;
                            break;
                        case 'S':
                            newy -= 1;
                            break;
                        case 'W':
                            newx -= 1;
                            break;
                        default:
                            newx += 1;
                            break;
                    }
                    break;
                case 'B':
                    switch (Heading)
                    {
                        case 'N':
                            newy -= 1;
                            break;
                        case 'S':
                            newy += 1;
                            break;
                        case 'E':
                            newx -= 1;
                            break;
                        default:
                            newx += 1;
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

            if (newx < 0)
            {
                newx = XMax;
            }

            if (newy < 0)
            {
                newy = YMax;
            }

            if (Obstacles != null && Obstacles.Any(obstacle => obstacle.X == newx && obstacle.Y == newy))
            {
                throw new ObstacleException();
            }

            X = newx;
            Y = newy;
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
