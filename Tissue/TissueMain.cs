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
        public BoundaryCondition myBC = new BoundaryCondition(tissueSize);

        public int[,] cells;

        public TissueMain()
        {
            cells = new int[tissueSize+myTransF.size-1, tissueSize + myTransF.size - 1];
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
            //update BC
            cells = myBC.upDateBCOnes(cells, myTransF.size);
            //update cells
            cells = myTransF.getUpdatedCellsArray(this);
        }

        /// <summary>
        /// Returns an symmetric array around x, y with values of size 2*size +1
        /// Only size == 1 is supported as is...
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
                    returnArray[x, y] = cells[x + xpos - 2 * size + 1, y + ypos - 2 * size + 1];
                    
                }// End
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
        public void toggleThresholdCell(int x)
        {
            if (x < 0) return;
            if (x > myTransF.thresholdFunc.GetLength(0)) return;
            if (myTransF.thresholdFunc[x] == 0) myTransF.thresholdFunc[x] = 1; else myTransF.thresholdFunc[x] = 0;
        }
    }
    
}
