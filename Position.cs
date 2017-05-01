using System;

namespace PathFinding
{
    public class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Steps { get; private set; }

        public Position(int y, int x, int step)
        {
            Y = y;
            X = x;
            Steps = step;
        }
        public void Move()
        {
            Steps++;
        }
      
        public override string ToString()
        {
            return "[Path:" + ", Y:" + Y + ", X:" + X + ", Steps: " + Steps + "]";
        }
    }
}