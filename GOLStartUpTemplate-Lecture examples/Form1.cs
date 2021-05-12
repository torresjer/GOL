using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOLStartUpTemplate_Lecture_examples
{
    public partial class Form1 : Form
    {
        // The universe array
        Cells[,] universe = new Cells[50, 50];
        Cells[,] scratchpad = new Cells[50,50];

        
        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;

        public Form1()
        { 
            InitializeComponent();
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = new Cells();
                    scratchpad[x, y] = new Cells();
                }
            }

            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer stopped
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {

            for(int y = 0; y < universe.GetLength(1); y++)
            {
                for(int x = 0; x < universe.GetLength(0); x++)
                {
                    scratchpad[x, y].SetAliveOrDead(false);
                    scratchpad[x, y].SetNeighborsCount(0);
                    int count = CountingNeighbours(x, y);
                    universe[x, y].SetNeighborsCount(count);
                    //apply rules
                    //should cell live or die
                    //turn on/off in scratchpad
                    if ((universe[x, y].GetAliveOrDead() == true) && count < 2)
                    {
                        scratchpad[x, y].SetAliveOrDead(false);
                        
                    }
                    if((universe[x, y].GetAliveOrDead() == true) && count > 3)
                    {
                        scratchpad[x, y].SetAliveOrDead(false);
                        
                    }
                    if ((universe[x, y].GetAliveOrDead() == true) && (count == 2 || count == 3))
                    {
                        scratchpad[x, y].SetAliveOrDead(true);
                       
                        
                    }
                    if ((universe[x,y].GetAliveOrDead() == false) && count == 3)
                    {
                        scratchpad[x, y].SetAliveOrDead(true);
                        
                        
                    }

                    
                }
            }

            //copy the scratchPad into the universe
            Cells[,] temp = universe;
            universe = scratchpad;
            scratchpad = temp;

            
            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();

            graphicsPanel1.Invalidate();
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {

                    
                    




                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    

                    // Fill the cell with a brush if alive
                    if (universe[x, y].GetAliveOrDead() == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                        

                        
                    }
                    // Fill the cell with a neighbor count
                    Font font = new Font("Arial", 5f);

                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    int neighbors = CountingNeighbours(x,y);
                    e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, cellRect, stringFormat);



                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);

                    
                }
            }
            
            

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                float cellWidth = (float)graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = (float)graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = (int)(e.X / cellWidth);
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = (int)(e.Y / cellHeight);

                // Toggle the cell's state
                universe[x, y].SetAliveOrDead(!universe[x, y].GetAliveOrDead());

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int CountingNeighbours(int x, int y)
        {
            int count = 0;
            int Xlength = universe.GetLength(0);
            int Ylength = universe.GetLength(1);

            for(int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for(int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int XCheck = x + xOffset;
                    int YCheck = y + yOffset;

                    if (xOffset == 0 && yOffset == 0) continue;
                    if (XCheck < 0) continue;
                    if (YCheck < 0) continue;
                    if (XCheck >= Xlength) continue;
                    if (YCheck >= Ylength) continue;

                    if (universe[XCheck, YCheck].GetAliveOrDead() == true) count++;
                }
            }

            return count;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right and then turn them off.
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y].SetAliveOrDead(false);
                    universe[x, y].SetNeighborsCount(0);
                    scratchpad[x, y].SetAliveOrDead(false);
                    scratchpad[x, y].SetNeighborsCount(0);

                }
            }

            
            timer.Enabled = false;
            generations = -1;
            NextGeneration();
            graphicsPanel1.Invalidate();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (timer.Enabled == false)
            {
                NextGeneration(); 
            }
        }
    }
}
