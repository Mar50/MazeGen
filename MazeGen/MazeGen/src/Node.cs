using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGen
{
    class Node
    {
        public Node(int _xPos, int _yPos)
        {
            xPos = _xPos;
            yPos = _yPos;
        }

        public int xPos;
        public int yPos;

        bool beenVisited = false;

        bool m_northWall;
        bool m_eastWall;
        bool m_southWall;
        bool m_westWall;

        public static List<Node> GetSurroundingNodes(Node currentNode)
        {
            List<Node> surroundingNodes = new List<Node>();

            //TR CORNER
            if (currentNode.xPos > Maze.m_mazeWidth && currentNode.yPos < 0)
            {
                Node bottomNode = Program.finalMaze[currentNode.xPos, currentNode.yPos + 1];
                Node leftNode = Program.finalMaze[currentNode.xPos - 1, currentNode.yPos];
                surroundingNodes.Add(bottomNode);
                surroundingNodes.Add(leftNode);
                return surroundingNodes;
            }

            //BR CORNER
            if (currentNode.xPos == Maze.m_mazeWidth && currentNode.yPos == Maze.m_mazeHeight)
            {
                Node topNode = Program.finalMaze[currentNode.xPos, currentNode.yPos - 1];
                Node leftNode = Program.finalMaze[currentNode.xPos - 1, currentNode.yPos];
                surroundingNodes.Add(topNode);
                surroundingNodes.Add(leftNode);
                return surroundingNodes;
            }

            //BL CORNER
            if (currentNode.xPos == 0 && currentNode.yPos == Maze.m_mazeHeight)
            {
                Node topNode = Program.finalMaze[currentNode.xPos, currentNode.yPos - 1];
                Node rightNode = Program.finalMaze[currentNode.xPos + 1, currentNode.yPos];
                surroundingNodes.Add(topNode);
                surroundingNodes.Add(rightNode);
                return surroundingNodes;
            }

            //TL CORNER
            if (currentNode.xPos == 0 && currentNode.yPos == 0)
            {
                Node rightNode = Program.finalMaze[currentNode.xPos + 1, currentNode.yPos];
                Node bottomNode = Program.finalMaze[currentNode.xPos, currentNode.yPos + 1];
                surroundingNodes.Add(rightNode);
                surroundingNodes.Add(bottomNode);
                return surroundingNodes;
            }

            //TOP EDGE
            if ( currentNode.yPos == 0 && currentNode.xPos > 1 && currentNode.xPos < Maze.m_mazeWidth - 1)
            {
                Node rightNode = Program.finalMaze[currentNode.xPos + 1, currentNode.yPos];
                Node bottomNode = Program.finalMaze[currentNode.xPos, currentNode.yPos + 1];
                Node leftNode = Program.finalMaze[currentNode.xPos - 1, currentNode.yPos];

                surroundingNodes.Add(rightNode);
                surroundingNodes.Add(bottomNode);
                surroundingNodes.Add(leftNode);
                return surroundingNodes;
            }

            //RIGHT EDGE
            if (currentNode.xPos == Maze.m_mazeWidth - 1 && currentNode.yPos > 1 && currentNode.yPos < Maze.m_mazeHeight - 1)
            {
                Node topNode = Program.finalMaze[currentNode.xPos, currentNode.yPos - 1];
                Node bottomNode = Program.finalMaze[currentNode.xPos, currentNode.yPos + 1];
                Node leftNode = Program.finalMaze[currentNode.xPos - 1, currentNode.yPos];

                surroundingNodes.Add(topNode);
                surroundingNodes.Add(bottomNode);
                surroundingNodes.Add(leftNode);
                return surroundingNodes;
            }

            //BOTTOM EDGE
            if (currentNode.yPos == Maze.m_mazeHeight - 1 && currentNode.xPos > 0 && currentNode.xPos < Maze.m_mazeWidth - 1)
            {
                Node rightNode = Program.finalMaze[currentNode.xPos + 1, currentNode.yPos];
                Node topNode = Program.finalMaze[currentNode.xPos, currentNode.yPos - 1];
                Node leftNode = Program.finalMaze[currentNode.xPos - 1, currentNode.yPos];

                surroundingNodes.Add(rightNode);
                surroundingNodes.Add(topNode);
                surroundingNodes.Add(leftNode);
                return surroundingNodes;
            }

            //LEFT EDGE
            if (currentNode.xPos == 0 && currentNode.yPos > 0 && currentNode.yPos < Maze.m_mazeHeight - 1)
            {
                Node topNode = Program.finalMaze[currentNode.xPos, currentNode.yPos - 1];
                Node rightNode = Program.finalMaze[currentNode.xPos + 1, currentNode.yPos];
                Node bottomNode = Program.finalMaze[currentNode.xPos, currentNode.yPos + 1];

                surroundingNodes.Add(topNode);
                surroundingNodes.Add(rightNode);
                surroundingNodes.Add(bottomNode);
                return surroundingNodes;
            }

            //CHECK REMAINING NODES
            if (currentNode.xPos > 1 | currentNode.xPos < Maze.m_mazeWidth | currentNode.yPos > 1 | currentNode.yPos < Maze.m_mazeHeight)
            {
                Node topNode = Program.finalMaze[currentNode.xPos, currentNode.yPos - 1];
                Node rightNode = Program.finalMaze[currentNode.xPos + 1, currentNode.yPos];
                Node bottomNode = Program.finalMaze[currentNode.xPos, currentNode.yPos + 1];
                Node leftNode = Program.finalMaze[currentNode.xPos - 1, currentNode.yPos];

                surroundingNodes.Add(topNode);
                surroundingNodes.Add(rightNode);
                surroundingNodes.Add(bottomNode);
                surroundingNodes.Add(leftNode);
                return surroundingNodes;
            }
            return surroundingNodes;
        }
    }
}
