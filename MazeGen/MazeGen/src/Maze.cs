using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGen
{
    class Maze
    {
        public static int m_mazeWidth = 10;
        public static int m_mazeHeight = 10;

        public static Node[,] GenerateMaze(int _width, int _height)
        {
            Node[,] m_tempMaze = new Node[_width, _height];

            for (int j = 0; j < _width; j++)
            {
                for (int i = 0; i < _height; i++)
                {
                    m_tempMaze[i,j] = new Node(i,j);
                }
            }
            return m_tempMaze;
        }
    }
}
