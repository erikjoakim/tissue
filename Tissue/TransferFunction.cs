using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tissue
{
    public class TransferFunction
    {

        //The Class TransferFunction will update the tissue to the next state
        public int[,] newCells;
        public int size = 3;
        public int[,] transF = new int[3, 3] { { 0, 1, 0 }, { 1, 0, 1 }, { 0, 1, 0 } };

        /// <summary>
        /// Will multiply element by element two equally sized square arrays and return the sum
        /// Will return null if not equally sized or not square
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private int? MultiplyArrays(int[,] first, int[,] second)
        {
            if ((first.GetLength(0) != second.GetLength(0)) || (first.GetLength(1) != second.GetLength(1)) || (first.GetLength(0) != first.GetLength(1))) return null;
            int result = 0;
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
            newCells = new int[theTissue.cells.GetLength(0), theTissue.cells.GetLength(1)];
            for (int x = size / 2; x < theTissue.getTissueSize() + size / 2; x++)
            {
                for (int y = size / 2; y < theTissue.getTissueSize() + size / 2; y++)
                {
                    int? res = MultiplyArrays(theTissue.getSubArray(1, x, y), transF);
                    if (res.HasValue)
                    {
                        if ((res.Value >= 3) && (res.Value < 7)) newCells[x, y] = 1;
                    }
                }
            }
            return newCells;
        }
    }
}
