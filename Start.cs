using System;

namespace PathFinding
{
    class Mainclass {
        private static void RunTest()
        {
            Console.WriteLine("[Test]");
             var TestMaze = new TestMaze();
            try
            {
                 TestMaze.TestMoveUp();
                 TestMaze.TestMoveDown();
                 TestMaze.TestMoveRight();
                 TestMaze.TestMoveLeft();
                 TestMaze.
                 TestPathFinding();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private static void FindPath()
        {
            var Maze = new Maze();
            Maze.PrintingMaze();
            int [] Goal= {1,1};
            int [] start = {1,1};

            Maze.Adress(3, start);
            Maze.Adress(4, Goal);
            // Console.WriteLine(Goal[0],Goal[1]);
            // Console.WriteLine(start[0], start[1]);
            Console.WriteLine("\n"+"goal Y," + "" + Goal[0] + ",goal X," +  "" +Goal[1] + "");
            Console.WriteLine("start Y," + ""+ start[0]+ ""+ ",start X" + "" + start[1] + "");

            // Maze.findingPath(start , Goal);
            Maze.PrintingMaze();
            Console.ReadKey();
        }                       

        public static void Main(string[] args) {
        //   FindPath();
            RunTest();
          Console.ReadKey();
        }
    }
}