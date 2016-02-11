using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tissue
{
    public class TissueMain
    {
        public static int tissueSize = 50;
        public TransferFunction myTransF = new TransferFunction();
        public int[,] cells;

        public TissueMain()
        {
            cells = new int[tissueSize, tissueSize];
        }
        public static TissueMain toTissueObject(string serializedText)
        {
            return JsonConvert.DeserializeObject<TissueMain>(serializedText);

        }
        public static string toXMLString(TissueMain theTissue)
        {
            return JsonConvert.SerializeObject(theTissue);
        }

        public int getTissueSize()
        {
            return tissueSize;
        }

        public void updateTissue()
        {
            cells = myTransF.getUpdatedCellsArray(this);
        }

        /// <summary>
        /// Returns an symmetric array around x, y with values of size 2*size +1
        /// </summary>
        /// <param name="size"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int[,] getSubArray(int size, int xpos, int ypos)
        {
            int[,] returnArray = new int[2 * size + 1, 2 * size + 1];
            for (int x =0 ; x <2 * size + 1; x++)
            {
                for (int y = 0; y < 2 * size + 1; y++)
                {
                    if (x + xpos - 2*size +1 < 0 || y + ypos - 2*size + 1 < 0)
                        returnArray[x, y] = 0;
                    else
                    {
                        if (x + xpos > tissueSize-1 || y + ypos > tissueSize-1)
                            returnArray[x, y] = 0;
                        else
                            returnArray[x, y] = cells[xpos + x - 2*size +1, ypos + y -2*size + 1];
                    }
                }
            }
            return returnArray;
        }

        public int? getValueAt(int x, int y)
        {
            if (x < 0 || y < 0) return null;
            if (x > tissueSize || y > tissueSize) return null;
            return cells[x, y];
        }

        public void toggleCell(int x, int y)
        {
            if (x < 0 || y < 0) return;
            if (x > tissueSize || y > tissueSize) return;
            if (cells[x, y] == 0) cells[x, y] = 1; else cells[x, y] = 0;
        }
        public void toggleTransFCell(int x, int y)
        {
            if (x < 0 || y < 0) return;
            if (x > myTransF.transF.GetLength(0) || y > myTransF.transF.GetLength(1)) return;
            if (myTransF.transF[x, y] == 0) myTransF.transF[x, y] = 1; else myTransF.transF[x, y] = 0;
        }
    }
    public class TransferFunction
    {
        //The Class TransferFunction will update the tissue to the next state
        public int[,] newCells;
        public int[,] transF = new int[3, 3]  { {0,1,0}, {1,0,1}, {0,1,0} };

        /// <summary>
        /// Will multiply element by element two equally sized square arrays and return the sum
        /// Will return null if not equally sized or not square
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private int? MultiplyArrays(int[,] first, int[,] second)
        {
            if ( (first.GetLength(0) != second.GetLength(0)) || (first.GetLength(1) != second.GetLength(1)) || ( first.GetLength(0) != first.GetLength(1)) ) return null;
            int result=0;
            for (int x = 0; x < first.GetLength(0); x++)
            {
                for (int y = 0; y < first.GetLength(1); y++)
                {
                    result += first[x, y] * second[x, y];
                }
            }
            return result;
        }

        public int[,] getUpdatedCellsArray(TissueMain theTissue)
        {
            newCells = new int[theTissue.getTissueSize(), theTissue.getTissueSize()];
            for (int x = 0; x < theTissue.getTissueSize(); x++)
            {
                for (int y = 0; y < theTissue.getTissueSize(); y++)
                {
                    int? res = MultiplyArrays(theTissue.getSubArray(1, x, y), transF);
                    if(res.HasValue)
                    {
                        if ((res.Value >= 3) && (res.Value <7)) newCells[x, y] = 1;
                    }
                }
            }
            return newCells;
        }

    }
}
