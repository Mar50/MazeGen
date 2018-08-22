using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML;
using SFML.Graphics;
using SFML.Window;

namespace MazeGen
{
    class Program
    {
        public static Node[,] finalMaze;

        static void Main(string[] args)
        {
            finalMaze = Maze.GenerateMaze(10,10);

            Node.GetSurroundingNodes(finalMaze[0, 5]);
            //RenderWindow window = new RenderWindow(new VideoMode(800, 600), "Maze Gen");
            //window.SetVerticalSyncEnabled(true);

            //Event sfmlEvent = new Event();

            //while (window.IsOpen)
            //{
            //    //window.Clear(new Color(Color.Black));
            //    //window.Draw()

            //    if (sfmlEvent.Type == EventType.Closed)
            //    {
            //        window.Close();
            //    }
            //}
            //window.Close();
        }
    }
}
