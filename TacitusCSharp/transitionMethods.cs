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
        List<nodeTransition> parentTransition(node selectedNode)
        {
            List<nodeTransition> prTrVec = new List<nodeTransition>();
            List<int> nodeIds =  new List<int>();
            nodeTransition tempTr; 
            for (int i = 0; i < links.Count(); i++)
            {
                if (links[i].childNode == selectedNode.id)
                {
                    nodeIds.Add(links[i].parentNode);
                }
            }
            for (int k = 0; k < nodes.Count(); k ++)
            {
                for (int j = 0; j < nodeIds.Count(); j++)
                {
                    if (nodeIds[j] == nodes[k].id)
                    {
                        tempTr = new nodeTransition();
                        tempTr.originalX = nodes[k].x;
                        tempTr.originalY = nodes[k].y;
                        tempTr.updatedX = selectedNode.x - offset;
                        tempTr.updatedY = (int)(selectedNode.y + (nodeIds.Count / 2 - j) * nodeSize * 2);
                        tempTr.id = nodeIds[j];
                        prTrVec.Add(tempTr);
                    }
                }
            }
            return prTrVec;
        }
        List<nodeTransition> childTransition(node selectedNode)
        {
            List<nodeTransition> prTrVec = new List<nodeTransition>();
            List<int> nodeIds = new List<int>();
            nodeTransition tempTr;
            for (int i = 0; i < links.Count(); i++)
            {
                if (links[i].parentNode == selectedNode.id)
                {
                    nodeIds.Add(links[i].childNode);
                }
            }
            for (int k = 0; k < nodes.Count(); k++)
            {
                for (int j = 0; j < nodeIds.Count(); j++)
                {
                    if (nodeIds[j] == nodes[k].id)
                    {
                        tempTr = new nodeTransition();
                        tempTr.originalX = nodes[k].x;
                        tempTr.originalY = nodes[k].y;
                        tempTr.updatedX = selectedNode.x + offset;
                        tempTr.updatedY = (int)(selectedNode.y + (nodeIds.Count / 2 - j) * nodeSize * 2);
                        tempTr.id = nodeIds[j];
                        prTrVec.Add(tempTr);
                    }
                }
            }
            return prTrVec;
        }
    }
}
