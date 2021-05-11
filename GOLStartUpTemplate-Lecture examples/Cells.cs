using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOLStartUpTemplate_Lecture_examples
{
    class Cells
    {
        bool aliveOrDead;
        int neighbors;
        public Cells()
        {
            aliveOrDead = false;
            neighbors = 0;
        }
        public void SetAliveOrDead(bool status)
        {
            aliveOrDead = status;
        }
        public bool GetAliveOrDead()
        {
            return aliveOrDead;
        }
        public void SetNeighborsCount(int count)
        {
            neighbors = count;
        }
        public int GetNeighborsCount()
        {
            return neighbors;
        }
    }
}
