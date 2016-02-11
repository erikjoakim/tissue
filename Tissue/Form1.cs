using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tissue
{
    public partial class Form1 : Form
    {
        Bitmap DrawArea;
        Bitmap bmTransF;
        TissueMain thisTissue = new TissueMain();
        string buTissue;
        TransferFunction thisTransF = new TransferFunction();

        int GridSize = 10;
        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            bmTransF = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = DrawArea;
            pbTransferF.Image = bmTransF;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            g.Clear(Color.White);
            g = Graphics.FromImage(bmTransF);
            g.Clear(Color.White);

            DrawGrid(DrawArea);
            DrawGrid(bmTransF);
            DrawCells(bmTransF, thisTissue.myTransF.transF);
        }

        private void DrawFrame()
        {
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            bmTransF = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            DrawGrid(DrawArea);
            DrawCells(DrawArea);
            DrawGrid(bmTransF);
            DrawCells(bmTransF, thisTissue.myTransF.transF);
            pictureBox1.Image = DrawArea;
            pbTransferF.Image = bmTransF;
        }

        private void DrawCells(Bitmap DrawArea, int[,] thisCellArray)
        {
            Graphics g = Graphics.FromImage(DrawArea);
            SolidBrush myBrush = new SolidBrush(Color.Red);
            for (int x = 0; x < thisCellArray.GetLength(0); x++)
            {
                for (int y = 0; y < thisCellArray.GetLength(1); y++)
                {
                    if (thisCellArray[x, y] == 1)
                    {
                        Rectangle dotRect = new Rectangle(x * GridSize, y * GridSize, GridSize, GridSize);
                        g.FillEllipse(myBrush, dotRect);
                    }
                }
            }

        }
        private void DrawCells(Bitmap DrawArea)
        {
            Graphics g = Graphics.FromImage(DrawArea);
            SolidBrush myBrush = new SolidBrush(Color.Red);
            for (int x = 0; x < thisTissue.getTissueSize(); x++)
            {
                for (int y = 0; y < thisTissue.getTissueSize(); y++)
                {
                    if(thisTissue.getValueAt(x,y) == 1)
                    {
                        Rectangle dotRect = new Rectangle(x * GridSize, y * GridSize, GridSize, GridSize);
                        g.FillEllipse(myBrush, dotRect);
                    }
                }
            }
            
        }

        private void DrawGrid(Bitmap DrawArea)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Brushes.Black);
            int myW = DrawArea.Width;
            int myH = DrawArea.Height;
            for (int i = 0; i < myW; i += GridSize)
            {
                g.DrawLine(mypen, i, 0, i, myH);
            }
            for (int i = 0; i < myH; i += GridSize)
            {
                g.DrawLine(mypen, 0, i, myW, i);
            }
            
        }

        private Point? fromPixelToCellCoord(int x, int y)
        {
            if (x < 0 || y < 0) return null;
            if (x > DrawArea.Width || y > DrawArea.Height) return null;
            int dotX = x / GridSize;
            int dotY = y / GridSize;
            return new Point(dotX, dotY);
        }

        private void DrawDotFromPixel(int x, int y)
        {
            if (x < 0 || y < 0) return;
            if (x > DrawArea.Width || y > DrawArea.Height) return;
            int dotX = x / GridSize;
            int dotY = y / GridSize;
            Rectangle dotRect = new Rectangle(dotX*GridSize, dotY*GridSize, GridSize, GridSize);
            Graphics g = Graphics.FromImage(DrawArea);
            SolidBrush myBrush = new SolidBrush(Color.Red);
            g.FillEllipse(myBrush, dotRect);
            pictureBox1.Image = DrawArea;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;
            Point? cellCoord = fromPixelToCellCoord(me.X, me.Y);
            if (cellCoord.HasValue) thisTissue.toggleCell(cellCoord.Value.X, cellCoord.Value.Y);
            DrawFrame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Update Tissue
            thisTissue.updateTissue();
            //DrawFrame
            DrawFrame();
        }

        private void btnStartSim_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                btnStartSim.Text = "Start Sim";
            }
            else
            {
                timer1.Enabled = true;
                btnStartSim.Text = "Running";
            }
        }

        private void btnSaveStart_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(dialog.FileName, TissueMain.toXMLString(thisTissue));
            }
        }

        private void btnQuickSave_Click(object sender, EventArgs e)
        {
            buTissue = TissueMain.toXMLString(thisTissue);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            thisTissue = TissueMain.toTissueObject(buTissue);
            DrawFrame();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                thisTissue = TissueMain.toTissueObject(System.IO.File.ReadAllText(dialog.FileName));
                DrawFrame();
            }
        }

        private void btnStepSim_Click(object sender, EventArgs e)
        {
            //Update Tissue
            thisTissue.updateTissue();
            //DrawFrame
            DrawFrame();
        }

        private void pbTransferF_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;
            Point? cellCoord = fromPixelToCellCoord(me.X, me.Y);
            if (cellCoord.HasValue) thisTissue.toggleTransFCell(cellCoord.Value.X, cellCoord.Value.Y);
            DrawFrame();
        }
    }
}
