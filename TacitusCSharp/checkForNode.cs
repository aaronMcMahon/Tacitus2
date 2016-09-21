using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TacitusCSharp
{
    public partial class homeForm : Form
    {
        int checkForNode(int x, int y)
        {
            int nodeId = -1;
            for (int i = 0; i < nodes.Count(); i++)
            {
                if(x + translateX > nodes[i].x && x + translateX < nodes[i].x + nodeSize && y + translateY > nodes[i].y && y + translateY < nodes[i].y + nodeSize)
                {
                    nodeId = nodes[i].id;
                }
            }
            return nodeId;
        }
    }
}
