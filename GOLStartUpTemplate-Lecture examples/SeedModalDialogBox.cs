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
    public partial class SeedModalDialogBox : Form
    {
        public SeedModalDialogBox()
        {
            InitializeComponent();
        }

        public int GetRandomSeed()
        {
            return (int)RandomUniverseSeed.Value;
        }
        public void SetRandomSeed(int seed)
        {
            RandomUniverseSeed.Value = seed;
        }
    }
}
