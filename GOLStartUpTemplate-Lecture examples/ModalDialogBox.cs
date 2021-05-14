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
    public partial class ModalDialogBox : Form
    {
        public ModalDialogBox()
        {
            InitializeComponent();
        }

        //Gets Width of universe from ModalDialog Box
        public int GetWidthofUniverse()
        {
            return (int)WidthofGrid.Value;
        }
        //Gets Height of Universe from ModalDialog Box
        public int GetHeightofUniverse()
        {
            return (int)HeightofGrid.Value;
        }
        //Gets milliseconds of Generations count from ModalDialog Box
        public int GetCountinMS()
        {
            return (int)GenerationCountMS.Value;
        }
        //Sets Width of universe
        public void SetWidthofUniverse(int WidthofUniverse)
        {
            WidthofGrid.Value = WidthofUniverse;
        }
        //Sets Height of Universe
        public void SetHeightofuniverse(int HeightofUniverse)
        {
            HeightofGrid.Value = HeightofUniverse;
        }
        //Sets milliseconds of Generations count
        public void SetCountinMS(int milliseconds)
        {
            GenerationCountMS.Value = milliseconds;
        }
    }
}
