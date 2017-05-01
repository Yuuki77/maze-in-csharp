using System;
using System.Collections.Generic;

namespace PathFinding
{
    public class TestMaze
    {
        public static void TestMoveUp()
        {
            var data = new int[,] {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 1, 1, 0, 3, 0, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1},
        {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
            var expected = new int[,] {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 3, 0, 1, 1, 0, 1, 1},
        {1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1},
        {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
            Maze maze = new Maze(data);
            maze.PrintingMaze();
            maze.Move(Direction.Up);
            maze.PrintingMaze();
            if (!IsEqual(maze.Data, expected))
            {
                throw new Exception("Move Up doesn't work");
            }

            Console.WriteLine(" * TestMoveUp: OK");
        }
        public static void TestMoveDown()
        {
            var data = new int[,] {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 1, 1, 0, 3, 0, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1},
        {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
            var expected = new int[,] {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 3, 1, 1, 0, 1, 1, 1},
        {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
            Maze maze = new Maze(data);
            maze.PrintingMaze();
            maze.Move(Direction.Down);
            maze.PrintingMaze();
            if (!IsEqual(maze.Data, expected))
            {
                throw new Exception("Move Down doesn't work");
            }

            Console.WriteLine(" * TestMoveDown: OK");
        }
        public static void TestMoveLeft()
        {
            var data = new int[,] {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 1, 1, 0, 3, 0, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1},
        {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
            var expected = new int[,] {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 1, 1, 3, 0, 0, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1},
        {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
            Maze maze = new Maze(data);
            maze.PrintingMaze();
            maze.Move(Direction.Left);
            maze.PrintingMaze();
            if (!IsEqual(maze.Data, expected))
            {
                throw new Exception("Move Left doesn't work");
            }

            Console.WriteLine(" * TestMoveLeft: OK");
        }
        public static void TestMoveRight()
        {
            var data = new int[,] {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 1, 1, 0, 3, 0, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1},
        {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
            var expected = new int[,] {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1},
        {1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 1, 1, 0, 0, 3, 0, 0, 1, 1, 1},
        {1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1},
        {1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1},
        {1, 0, 0, 1, 0, 1, 4, 1, 1, 0, 1, 1},
        {1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1},
        {1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };
            Maze maze = new Maze(data);
            maze.PrintingMaze();
            maze.Move(Direction.Right);
            maze.PrintingMaze();
            if (!IsEqual(maze.Data, expected))
            {
                throw new Exception("Move Right doesn't work");
            }

            Console.WriteLine(" * TestMoveRight: OK");
        }
         public static void TestPathFinding()
        {
            var data = new Position(5,5,0);
            var goal = new Position(8,6,0);
            var expected = new Position(9,6,1);
            Maze maze = new Maze();

            Console.WriteLine("beging" + data);
            // maze.findingPath(goal,data);
            maze.PrintingMaze();
            if (maze.findingPath(goal,data) != expected)
            {
                throw new Exception("TestPathFinding doesn't work");
            }

            Console.WriteLine(" * TestPathFinding: OK");
        }
        private static bool IsEqual(int[,] a, int[,] b)
        {
            for (int y = 0; y < a.GetLength(0); y++)
            {
                for (int x = 0; x < a.GetLength(1); x++)
                {
                    if (a[y, x] != b[y, x])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
         private static bool IsPathRight(Position start, Position end)
        {
            return start.X == end.X && start.Y == end.Y;
        }
    }
}
