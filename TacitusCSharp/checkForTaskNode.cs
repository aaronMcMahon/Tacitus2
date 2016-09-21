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
    public partial class taskManagerForm : Form
    {
        int checkForTaskNode(int x, int y)
        {
            y += translateY;
            int nodeId = -1;
            int nodePosition = (int)y / (nodeSize * 2) - 1;
            if (nodePosition <= sortedNodes.Count()) nodeId = sortedNodes[nodePosition].id;
            return nodeId;
        }
    }
}
