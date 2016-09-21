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
        undoState cloneState(List<node> oldNodes, List<link> oldLinks)
        {
            List<node> clonedNodes = new List<node>();
            List<link> clonedLinks = new List<link>();
            node nodeBuffer;
            link linkBuffer;
            for (int i = 0; i < oldNodes.Count; i++)
            {
                nodeBuffer = new node();
                nodeBuffer.id = oldNodes[i].id;
                nodeBuffer.fileLocation = oldNodes[i].fileLocation;
                nodeBuffer.name = oldNodes[i].name;
                nodeBuffer.projectId = oldNodes[i].projectId;
                nodeBuffer.rank = oldNodes[i].rank;
                nodeBuffer.timeStamp = oldNodes[i].timeStamp;
                nodeBuffer.type = oldNodes[i].type;
                nodeBuffer.x = oldNodes[i].x;
                nodeBuffer.y = oldNodes[i].y;

                clonedNodes.Add(nodeBuffer);
            }
            for (int i = 0; i < oldLinks.Count; i++)
            {
                linkBuffer = new link();
                linkBuffer.childNode = oldLinks[i].childNode;
                linkBuffer.id = oldLinks[i].id;
                linkBuffer.parentNode = oldLinks[i].parentNode;
                linkBuffer.timeStamp = oldLinks[i].timeStamp;

                clonedLinks.Add(linkBuffer);
            }
            undoState clonedState = new undoState();
            clonedState.set(clonedNodes, clonedLinks);
            return clonedState;
        }
    }
}
