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
        void recordUndoState()
        {
            if (undoStatesList.Count == 0)
            {
                undoStatesList.Add(cloneState(nodes, links));
            }
            else if (undoStatesList.Count < undoStatesMax)
            {
                undoStatesList.Add(undoStatesList[undoStatesList.Count - 1]);
                for (int i = undoStatesList.Count - 1; i > 0; i--)
                {
                    undoStatesList[i] = cloneState(undoStatesList[i - 1].nodes, undoStatesList[i - 1].links);
                }
                undoStatesList[0] = cloneState(nodes, links);
            }
            else
            {
                for (int i = undoStatesList.Count - 1; i > 0; i--)
                {
                    undoStatesList[i] = cloneState(undoStatesList[i - 1].nodes, undoStatesList[i - 1].links);
                }
                undoStatesList[0] = cloneState(nodes, links);
            }

        }
    }
}
