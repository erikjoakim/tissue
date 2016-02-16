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
        public int[] thresholdFunc = new int[10] { 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 };
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
        /// <summary>
        /// return the total number of cells used by the transfer function
        /// </summary>
        /// <returns></returns>
        public int getNumberOfTransferValues()
        {
            return size * size+1;
        }

        /// <summary>
        /// returns the maximum value the threshold can take which is the sum of the values of the transfer function
        /// </summary>
        /// <returns></returns>
        public int getMaxThreshold()
        {
            int value=0;
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    value += transF[x, y];
                }
            }
            return value;
        }
        /// <summary>
        /// returns the minimum value the threshold can take which is 0 in case of boolean values. Needs to be updated if the transfer function can take negative values
        /// </summary>
        /// <returns></returns>
        public int getMinThreshold()
        {
            return 0;
        }

        public int[,] getUpdatedCellsArray(TissueMain theTissue)
        {
            newCells = (int[,]) theTissue.cells.Clone();
            //newCells = new int[theTissue.cells.GetLength(0), theTissue.cells.GetLength(1)];
            for (int x = size / 2; x < theTissue.getTissueSize() + size / 2; x++)
            {
                for (int y = size / 2; y < theTissue.getTissueSize() + size / 2; y++)
                {
                    int? res = MultiplyArrays(theTissue.getSubArray(1, x, y), transF);
                    if (res.HasValue)
                    {
                        newCells[x, y] = thresholdFunc[res.Value];
                    }
                }
            }
            return newCells;
        }
    }
}
