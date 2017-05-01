using System;
using System.Collections.Generic;

namespace PathFinding
{
    public class Maze
    {
        public int[,] Data { get; private set; }

        public Maze()
        {
            Data = new int[,]  {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1},
        {1, 1, 1, 1, 0, 3, 0, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1},
        {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
        }
        public Maze(int[,] data)
        {
            Data = data;
        }
        List<Position> list = new List<Position>();

        public void PrintingMaze()
        {
            for (int y = 0; y <= Data.GetUpperBound(0); y++)
            {
                Console.WriteLine();
                for (int x = 0; x <= Data.GetUpperBound(1); x++)
                {
                    int current = Data[y, x];
                    if (current == 0)
                    {
                        Console.Write("   ");
                    }
                    else if (current == 4)
                    {
                        Console.Write("goa");
                    }
                    else if (current == 3)
                    {
                        Console.Write("orz");
                    }
                    else if (current == 1)
                    {
                        PrintWall(y, x);
                    }
                    else if (current == 2)
                    {
                        PrintTrace(y, x);
                    }
                }
            }
        }
        public void PrintTrace(int y, int x)
        {

            bool Up = (y > 0 && Data[y - 1, x] == 2);
            bool Down = (y <= Data.GetUpperBound(0) - 1 && Data[y + 1, x] == 2);
            bool Left = (x > 0 && Data[y, x - 1] == 2);
            bool Right = (x <= Data.GetUpperBound(1) - 1 && Data[y, x + 1] == 2);

            if (Up && Down && Left && Right)
            {
                Console.Write("─┼─");
            }
            else if (!Up && Down && !Left && Right)
            {
                Console.Write(" ┌ ");
            }
            else if (!Up && Down && Left && !Right)
            {
                Console.Write(" ┐ ");
            }
            else if (Up && !Down && !Left && Right)
            {
                Console.Write(" └ ");
            }
            else if (Up && !Down && Left && !Right)
            {
                Console.Write(" ┘ ");
            }
            else if (Up && !Down && Left && Right)
            {
                Console.Write("─┴─");
            }
            else if (!Up && Down && Left && Right)
            {
                Console.Write("─┬─");
            }
            else if (Up && Down && !Left && Right)
            {
                Console.Write(" ├─");
            }
            else if (Up && Down && Left && !Right)
            {
                Console.Write("─┤ ");
            }
            else if (!Up && !Down && (Left || Right))
            {
                Console.Write("───");
            }
            else if ((Up || Down) && !Left && !Right)
            {
                Console.Write(" │ ");
            }
        }
        public void PrintWall(int y, int x)
        {
            bool isUpWall = (y > 0 && Data[y - 1, x] == 1);
            bool isDownWall = (y <= Data.GetUpperBound(0) - 1 && Data[y + 1, x] == 1);
            bool isLeftWall = (x > 0 && Data[y, x - 1] == 1);
            bool isRightWall = (x <= Data.GetUpperBound(1) - 1 && Data[y, x + 1] == 1);
            if (isLeftWall && isUpWall && !isRightWall && !isDownWall)
            {
                Console.Write("═╝ ");
            }
            else if (isLeftWall && isDownWall && !isRightWall && !isUpWall)
            {
                Console.Write("═╗ ");
            }
            else if (isRightWall && isUpWall && !isLeftWall && !isDownWall)
            {
                Console.Write(" ╚═");
            }
            else if (isRightWall && isDownWall && !isLeftWall && !isUpWall)
            {
                Console.Write(" ╔═");
            }
            else if (isUpWall && isLeftWall && isDownWall && !isRightWall)
            {
                Console.Write("═╣ ");
            }
            else if (isRightWall && isUpWall && isDownWall && !isLeftWall)
            {
                Console.Write(" ╠═");
            }
            else if (isUpWall && isRightWall && isLeftWall && !isDownWall)
            {
                Console.Write("═╩═");
            }
            else if (isLeftWall && isRightWall && isDownWall && !isUpWall)
            {
                Console.Write("═╦═");
            }
            else if (isUpWall && isDownWall && isLeftWall && isRightWall)
            {
                Console.Write("═╬═");
            }
            else if ((isRightWall && isLeftWall && !isUpWall && !isDownWall) || isRightWall || isLeftWall)
            {
                Console.Write("═══");
            }
            else if ((isUpWall && isDownWall && !isLeftWall && !isRightWall) || isUpWall || isDownWall)
            {
                Console.Write(" ║ ");
            }

        }
        public void Adress(int search, int[] array)
        {
            for (int y = 0; y < Data.GetUpperBound(0); y++)
            {
                for (int x = 0; x < Data.GetUpperBound(1); x++)
                {
                    int currentPos = Data[y, x];
                    if (currentPos == search)
                    {
                        array[0] = y;
                        array[1] = x;
                    }
                }
            }
        }
        public Position findingPath(Position start, Position end)
        {
            var begining = new Position(start.Y, start.X, 0);
            int times = 0;
            list.Add(begining);
            while (true)
            {
                Position currentNode = list[times];
                Console.WriteLine("current is" + currentNode);

                var nodeAbove = new Position(currentNode.Y - 1, currentNode.X, currentNode.Steps + 1);
                if (nodeAbove.Y >= 0 && Data[nodeAbove.Y, nodeAbove.X] != 1)
                {
                    Console.WriteLine(nodeAbove + "up");
                    Insert(nodeAbove);
                    if (nodeAbove.X == start.X && nodeAbove.Y == start.Y)
                    {
                        break;
                    }
                }
                var nodeDown = new Position(currentNode.Y + 1, currentNode.X, currentNode.Steps + 1);
                if (nodeDown.Y <= Data.GetUpperBound(0) && Data[nodeDown.Y, nodeDown.X] != 1)
                {
                    Console.WriteLine(nodeDown + "down");
                    Insert(nodeDown);

                    if (nodeDown.X == start.X && nodeDown.Y == start.Y)
                    {
                        break;
                    }
                }
                var nodeLeft = new Position(currentNode.Y, currentNode.X - 1, currentNode.Steps + 1);
                if (nodeLeft.X >= 0 && Data[nodeLeft.Y, nodeLeft.X] != 1)
                {
                    Console.WriteLine(nodeLeft + "left");

                    Insert(nodeLeft);

                    if (nodeLeft.X == end.X && nodeLeft.Y == end.Y)
                    {
                        break;
                    }
                }
                var nodeRight = new Position(currentNode.Y, currentNode.X + 1, currentNode.Steps + 1);
                if (nodeRight.X <= Data.GetUpperBound(1) && Data[nodeRight.Y, nodeRight.X] != 1)
                {
                    Console.WriteLine(nodeRight + "right");

                    Insert(nodeRight);
                    if (nodeRight.X == end.X && nodeRight.Y == end.Y)
                    {
                        break;
                    }
                }
                times++;
            }
            return FindPath(start);

        }
        public Position FindPath(Position nextMove)
        {
            Position Current = list[list.Count - 1];

            for (int y = list.Count - 2; y >= 0; y--)
            {
                Position last = list[y];
                int distanceX = Math.Abs(Current.X - last.X);
                int distanceY = Math.Abs(Current.Y - last.Y);
                bool steps = (Current.Steps - 1 == last.Steps);
                // Console.WriteLine("list" + list[i]);
                // Console.WriteLine("inside array ;is " + last);

                if (steps)
                {
                    if (
                        (distanceX == 0 && distanceY == 1) ||
                        (distanceY == 0 && distanceX == 1)
                    )
                    {
                        Data[Current.Y, Current.X] = 2;
                        Console.WriteLine("you are" + Current.Y + Current.X);
                        Current = last;
                    }
                    if (nextMove.Steps + 1 == Current.Steps)
                    {
                        break; ;
                    }
                }

            }
            return nextMove;
        }
        public void Insert(Position current)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Y == current.Y && list[i].X == current.X)
                {
                    Console.WriteLine("false\t" + list[i].Y + list[i].X);
                    Console.WriteLine("false\t" + current.Y + current.X);
                    return;
                }
            }
            Console.WriteLine("sucess\t" + current);
            list.Add(current);
            // current.plus();
        }
        public bool CanMove(int x, int y)
        {
            if (Data[y, x] == 0)
            {
                return true;
            }
            return false;
        }
        public void Move(Direction direction)
        {
            bool Up = direction == Direction.Up;
            bool Down = direction == Direction.Down;
            bool Left = direction == Direction.Left;
            bool Right = direction == Direction.Right;

            for (int y = 0; y < Data.GetUpperBound(0); y++)
            {
                for (int x = 0; x < Data.GetUpperBound(1); x++)
                {
                    int currentPos = Data[y, x];
                    if (currentPos != 3)
                    {
                        continue;
                    }
                    Data[y, x] = 0;
                    if (Up && CanMove(y - 1, x))
                    {
                        Data[y - 1, x] = 3;
                        return;
                    }
                    if (Down && CanMove(y + 1, x))
                    {
                        Data[y + 1, x] = 3;
                        return;
                    }
                    if (Left && CanMove(y, x - 1))
                    {
                        Data[y, x - 1] = 3;
                        return;
                    }
                    if (Right && CanMove(y, x + 1))
                    {
                        Data[y, x + 1] = 3;
                        return;
                    }
                }
            }
        }
    }
}

//   public void findingPath(int[] startPos, int[] GoalPos)
//         {
//             var begining = new Position(startPos[0], startPos[1], 0);
//             int times = 0;
//             list.Add(begining);
//             while (true)
//             {
//                 Position currentNode = list[times];
//                 Console.WriteLine("current is" + currentNode);

//                 var nodeAbove = new Position(currentNode.Y - 1, currentNode.X, currentNode.Steps + 1);
//                 if (nodeAbove.Y >= 0 && Data[nodeAbove.Y, nodeAbove.X] != 1)
//                 {
//                     Console.WriteLine(nodeAbove + "up");
//                     Insert(nodeAbove);
//                     if (nodeAbove.X == GoalPos[1] && nodeAbove.Y == GoalPos[0])
//                     {
//                         break;
//                     }
//                 }
//                 var nodeDown = new Position(currentNode.Y + 1, currentNode.X, currentNode.Steps + 1);
//                 if (nodeDown.Y <= Data.GetUpperBound(0) && Data[nodeDown.Y, nodeDown.X] != 1)
//                 {
//                     Console.WriteLine(nodeDown + "down");
//                     Insert(nodeDown);

//                     if (nodeDown.X == GoalPos[1] && nodeDown.Y == GoalPos[0])
//                     {
//                         break;
//                     }
//                 }
//                 var nodeLeft = new Position(currentNode.Y, currentNode.X - 1, currentNode.Steps + 1);
//                 if (nodeLeft.X >= 0 && Data[nodeLeft.Y, nodeLeft.X] != 1)
//                 {
//                     Console.WriteLine(nodeLeft + "left");

//                     Insert(nodeLeft);

//                     if (nodeLeft.X == GoalPos[1] && nodeLeft.Y == GoalPos[0])
//                     {
//                         break;
//                     }
//                 }
//                 var nodeRight = new Position(currentNode.Y, currentNode.X + 1, currentNode.Steps + 1);
//                 if (nodeRight.X <= Data.GetUpperBound(1) && Data[nodeRight.Y, nodeRight.X] != 1)
//                 {
//                     Console.WriteLine(nodeRight + "right");

//                     Insert(nodeRight);
//                     if (nodeRight.X == GoalPos[1] && nodeRight.Y == GoalPos[0])
//                     {
//                         break;
//                     }
//                 }
//                 times++;
//             }
//             FindPath();

//         }
//         public void FindPath()
//         {
//             Position Current = list[list.Count - 1];

//             for (int y = list.Count - 2; y >= 0; y--)
//             {
//                 Position last = list[y];
//                 int distanceX = Math.Abs(Current.X - last.X);
//                 int distanceY = Math.Abs(Current.Y - last.Y);
//                 bool steps = (Current.Steps - 1 == last.Steps);
//                 // Console.WriteLine("list" + list[i]);
//                 // Console.WriteLine("inside array ;is " + last);

//                 if (steps)
//                 {
//                     if (
//                         (distanceX == 0 && distanceY == 1) ||
//                         (distanceY == 0 && distanceX == 1)
//                     )
//                     {
//                         Data[Current.Y, Current.X] = 2;
//                         Console.WriteLine("you are" + Current.Y + Current.X);
//                         Current = last;
//                     }
//                 }
//             }
//         }
//         public void Insert(Position current)
//         {
//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (list[i].Y == current.Y && list[i].X == current.X)
//                 {
//                     Console.WriteLine("false\t" + list[i].Y + list[i].X);
//                     Console.WriteLine("false\t" + current.Y + current.X);
//                     return;
//                 }
//             }
//             Console.WriteLine("sucess\t" + current);
//             list.Add(current);
//             // current.plus();
//         }
// using System;
// using System.Collections.Generic;

// namespace PathFinding
// {
//     public class Maze
//     {
//         List<Position> list = new List<Position>();
//         public int[,] maze = {
//         {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
//         {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
//         {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
//         {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
//         {1, 1, 1, 0, 0, 1, 0, 1, 1, 0, 1, 1},
//         {1, 1, 1, 1, 0, 3, 0, 0, 0, 1, 1, 1},
//         {1, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1},
//         {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
//         {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
//         {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
//         {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
//         {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
//         };
//         // public int[,] maze =  {
//         //     {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
//         //     {1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//         //     {1, 3, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//         //     {1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//         //     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//         //     {1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1},
//         //     {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//         //     {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//         //     {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//         //     {1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
//         //     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 1},
//         //     {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
//         // };
//         public void PrintingMaze()
//         {
//             for (int y = 0; y <= maze.GetUpperBound(0); y++)
//             {
//                 Console.WriteLine();
//                 for (int x = 0; x <= maze.GetUpperBound(1); x++)
//                 {
//                     int current = maze[y, x];
//                     if (current == 0)
//                     {
//                         Console.Write("   ");
//                     }
//                     else if (current == 4)
//                     {
//                         Console.Write("goa");
//                     }
//                     else if (current == 3)
//                     {
//                         Console.Write("orz");
//                     }
//                     else if (current == 1)
//                     {
//                         PrintWall(y, x);
//                     }
//                     else if (current == 2)
//                     {
//                         PrintTrace(y, x);
//                     }
//                 }
//             }
//         }
//         public void PrintTrace(int y, int x)
//         {

//             bool Up = (y > 0 && maze[y - 1, x] == 2);
//             bool Down = (y <= maze.GetUpperBound(0) - 1 && maze[y + 1, x] == 2);
//             bool Left = (x > 0 && maze[y, x - 1] == 2);
//             bool Right = (x <= maze.GetUpperBound(1) - 1 && maze[y, x + 1] == 2);

//             if (Up && Down && Left && Right)
//             {
//                 Console.Write("─┼─");
//             }
//             else if (!Up && Down && !Left && Right)
//             {
//                 Console.Write(" ┌ ");
//             }
//             else if (!Up && Down && Left && !Right)
//             {
//                 Console.Write(" ┐ ");
//             }
//             else if (Up && !Down && !Left && Right)
//             {
//                 Console.Write(" └ ");
//             }
//             else if (Up && !Down && Left && !Right)
//             {
//                 Console.Write(" ┘ ");
//             }
//             else if (Up && !Down && Left && Right)
//             {
//                 Console.Write("─┴─");
//             }
//             else if (!Up && Down && Left && Right)
//             {
//                 Console.Write("─┬─");
//             }
//             else if (Up && Down && !Left && Right)
//             {
//                 Console.Write(" ├─");
//             }
//             else if (Up && Down && Left && !Right)
//             {
//                 Console.Write("─┤ ");
//             }
//             else if (!Up && !Down && (Left || Right))
//             {
//                 Console.Write("───");
//             }
//             else if ((Up || Down) && !Left && !Right)
//             {
//                 Console.Write(" │ ");
//             }
//         }
//         public void PrintWall(int y, int x)
//         {
//             bool isUpWall = (y > 0 && maze[y - 1, x] == 1);
//             bool isDownWall = (y <= maze.GetUpperBound(0) - 1 && maze[y + 1, x] == 1);
//             bool isLeftWall = (x > 0 && maze[y, x - 1] == 1);
//             bool isRightWall = (x <= maze.GetUpperBound(1) - 1 && maze[y, x + 1] == 1);
//             if (isLeftWall && isUpWall && !isRightWall && !isDownWall)
//             {
//                 Console.Write("═╝ ");
//             }
//             else if (isLeftWall && isDownWall && !isRightWall && !isUpWall)
//             {
//                 Console.Write("═╗ ");
//             }
//             else if (isRightWall && isUpWall && !isLeftWall && !isDownWall)
//             {
//                 Console.Write(" ╚═");
//             }
//             else if (isRightWall && isDownWall && !isLeftWall && !isUpWall)
//             {
//                 Console.Write(" ╔═");
//             }
//             else if (isUpWall && isLeftWall && isDownWall && !isRightWall)
//             {
//                 Console.Write("═╣ ");
//             }
//             else if (isRightWall && isUpWall && isDownWall && !isLeftWall)
//             {
//                 Console.Write(" ╠═");
//             }
//             else if (isUpWall && isRightWall && isLeftWall && !isDownWall)
//             {
//                 Console.Write("═╩═");
//             }
//             else if (isLeftWall && isRightWall && isDownWall && !isUpWall)
//             {
//                 Console.Write("═╦═");
//             }
//             else if (isUpWall && isDownWall && isLeftWall && isRightWall)
//             {
//                 Console.Write("═╬═");
//             }
//             else if ((isRightWall && isLeftWall && !isUpWall && !isDownWall) || isRightWall || isLeftWall)
//             {
//                 Console.Write("═══");
//             }
//             else if ((isUpWall && isDownWall && !isLeftWall && !isRightWall) || isUpWall || isDownWall)
//             {
//                 Console.Write(" ║ ");
//             }

//         }
//         public void Adress(int search, int[] array)
//         {
//             for (int y = 0; y < maze.GetUpperBound(0); y++)
//             {
//                 for (int x = 0; x < maze.GetUpperBound(1); x++)
//                 {
//                     int currentPos = maze[y, x];
//                     if (currentPos == search)
//                     {
//                         array[0] = y;
//                         array[1] = x;
//                     }
//                 }
//             }
//         }
//         public void findingPath(int[] startPos, int[] GoalPos)
//         {
//             var begining = new Position(startPos[0], startPos[1], 0);
//             int times = 0;
//             list.Add(begining);
//             while (true)
//             {
//                 Position currentNode = list[times];
//                 Console.WriteLine("current is" + currentNode);

//                 var nodeAbove = new Position(currentNode.Y - 1, currentNode.X, currentNode.Steps + 1);
//                 if (nodeAbove.Y >= 0 && maze[nodeAbove.Y, nodeAbove.X] != 1)
//                 {
//                     Console.WriteLine(nodeAbove +"up");
//                     Insert(nodeAbove);
//                     if (nodeAbove.X == GoalPos[1] && nodeAbove.Y == GoalPos[0])
//                     {
//                         break;
//                     }
//                 }
//                 var nodeDown = new Position(currentNode.Y + 1, currentNode.X, currentNode.Steps + 1);
//                 if (nodeDown.Y <= maze.GetUpperBound(0)  && maze[nodeDown.Y, nodeDown.X] != 1)
//                 {   
//                     Console.WriteLine(nodeDown+"down");
//                     Insert(nodeDown);

//                     if (nodeDown.X == GoalPos[1] && nodeDown.Y == GoalPos[0])
//                     {
//                         break;
//                     }
//                 }
//                 var nodeLeft = new Position(currentNode.Y, currentNode.X - 1, currentNode.Steps + 1);
//                 if (nodeLeft.X >= 0 && maze[nodeLeft.Y, nodeLeft.X] != 1)
//                 {
//                     Console.WriteLine(nodeLeft +"left");

//                     Insert(nodeLeft);

//                     if (nodeLeft.X == GoalPos[1] && nodeLeft.Y == GoalPos[0])
//                     {
//                         break;
//                     }
//                 }
//                 var nodeRight = new Position(currentNode.Y, currentNode.X + 1, currentNode.Steps + 1);
//                 if (nodeRight.X <= maze.GetUpperBound(1)  && maze[nodeRight.Y, nodeRight.X] != 1)
//                 {   Console.WriteLine(nodeRight+ "right");

//                     Insert(nodeRight);
//                     if (nodeRight.X == GoalPos[1] && nodeRight.Y == GoalPos[0])
//                     {
//                         break;
//                     }
//                 }
//                 times++;
//             }
//             FindPath();

//         }
//         public void FindPath()
//         {
//             Position Current = list[list.Count - 1];

//             for (int y = list.Count -2; y >= 0; y--)
//             {
//                 Position last = list[y];
//                 int distanceX = Math.Abs(Current.X - last.X);
//                 int distanceY = Math.Abs(Current.Y - last.Y);
//                 bool steps = (Current.Steps - 1 == last.Steps);
//                 // Console.WriteLine("list" + list[i]);
//                 // Console.WriteLine("inside array ;is " + last);

//                 if (steps)
//                 {
//                     if (
//                         (distanceX == 0 && distanceY == 1) ||
//                         (distanceY == 0 && distanceX == 1)
//                     )
//                     {
//                         maze[Current.Y, Current.X] = 2;
//                         Console.WriteLine("you are" + Current.Y + Current.X);
//                         Current = last;
//                     }
//                 }
//             }
//         }
//         public void Insert(Position current)
//         {
//             for (int i = 0; i < list.Count; i++)
//             {
//                 if (list[i].Y == current.Y && list[i].X == current.X)
//                 {
//                    Console.WriteLine("false\t" + list[i].Y +  list[i].X);
//                    Console.WriteLine("false\t" + current.Y +  current   .X);


//                     return;
//                 }
//             }
//             Console.WriteLine("sucess\t" + current);
//             list.Add(current);
//             // current.plus();
//         }

//     }
// }

