using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tissue
{
    public class BoundaryCondition
    {
        Random rand = new Random();
        public enum BCPosition
        {
            BCRight, BCLeft, BCTop, BCBottom
        };
        public enum BCCorner
        {
            BCTopLeft, BCTopRight, BCBottomLeft, BCBottomRight
        };
        public enum BCType
        {
            BCZero, BCOne, BCFree, BCWrapTop, BCWrapRight, BCWrapBoth
        };

        int tissueSize;
        public int[,] BCCells;
        public int[] BCCorners = new int[4];

        BCType[] thisBCTypes= new BCType[4];

        public BoundaryCondition(int _tissueSize)
        {
            tissueSize = _tissueSize;
            BCCells = new int[4, tissueSize];
        }
        public BoundaryCondition(int _tissueSize, int initValue)
        {
            tissueSize = _tissueSize;
            BCCells = new int[4, tissueSize];
            for (int i = 0; i < 4; i++)
            {
                BCCorners[i] = initValue;
                for (int x = 0; x < tissueSize; x++)
                {
                    BCCells[i, x] = initValue;
                    
                }
            }
        }

        public int[,] updateBC(int[,] cells, int TFSize, BCType thisBCType)
        {
            switch (thisBCType)
            {
                case BCType.BCZero:
                    break;
                case BCType.BCOne:
                    cells = upDateBCOnes(cells, TFSize);
                    break;
                case BCType.BCFree:

                    break;
                case BCType.BCWrapTop:
                    break;
                case BCType.BCWrapRight:
                    cells = updateBCWrapRight(cells, TFSize);
                    break;
                case BCType.BCWrapBoth:
                    break;
                default:
                    break;
            }
            return cells;
        }

        /// <summary>
        /// Copy the values of the right side of the proper tissue to the BC on the left side and vice verse
        /// </summary>
        /// <param name="cells"></param>
        /// <param name="TFSize"></param>
        /// <returns></returns>
        private int[,] updateBCWrapRight(int[,] cells, int TFSize)
        {
            
            for (int y = TFSize/2; y < cells.GetLength(1)-TFSize/2; y++)
            {
                for (int x = 0; x < TFSize/2; x++)
                {
                   
                    //Copy to left BC side
                    cells[x, y] = cells[x + cells.GetLength(0) - TFSize / 2 - 1, y];
                    //Copy to right BC side
                    cells[x + cells.GetLength(0) - TFSize / 2, y] = cells[x + TFSize / 2, y];
                }
                
            }
            return cells;
        }

        public int[,] upDateBCOnes(int[,] cells, int TFsize)
        {
            for (int x = 0; x < cells.GetLength(0); x++)
            {
                for (int y = 0; y < TFsize/2; y++)
                {
                    //TOP
                    cells[x, y] = 1;
                    //BOTTOM
                    cells[x, (y + cells.GetLength(0) - TFsize / 2 )] = 1;
                    //LEFT
                    cells[y, x] = 1;
                    //RIGHT
                    cells[(y + cells.GetLength(0) - TFsize / 2 ),x] = 1;
                }
            }
            return cells;
        }

        public void SetRandomBoolAll(BCPosition thisBC)
        {
            for (int i = 0; i < 4; i++)
            {
                BCCorners[i] = rand.Next(0, 2);
                for (int x = 0; x < tissueSize; x++)
                {
                    BCCells[i, x] = rand.Next(0, 2);
                }
            }
        }
        public void SetRandomBoolBC(BCPosition thisBC)
        {
            for (int x = 0; x < tissueSize; x++)
            {
                BCCells[(int)thisBC, x] = rand.Next(0,2);
            }
        }
        public void SetBC(BCPosition thisBC, int _value)
        {
            for (int x = 0; x < tissueSize; x++)
            {
                BCCells[(int) thisBC, x] = _value;
            }
        }
    }
}
