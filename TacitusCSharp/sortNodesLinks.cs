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
        void sortNodesLinks()
        {
            nodes.Sort((x, y) => x.timeStamp.CompareTo(y.timeStamp));
            links.Sort((x, y) => x.timeStamp.CompareTo(y.timeStamp));
        }
    }
}
