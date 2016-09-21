using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacitusCSharp
{
    class nodeTransition
    {
        public int originalX, originalY, updatedX, updatedY;
        public int id;
        public int deltaX(int panFrame)
        {
            float delta;
            delta = (updatedX - originalX) / panFrame;
            Math.Round(delta);
            return (int) delta;
        }
        public int deltaY(int panFrame, int nodeSize)
        {
            float delta;
            delta = (updatedY - originalY - nodeSize) / panFrame;
            Math.Round(delta);
            return (int)delta;
        }
    }
}
