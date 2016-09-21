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
        private void drawMap(List<link> links, List<node> nodes)
        {           
            Bitmap btm = new Bitmap(mapPicBx.Width, mapPicBx.Height);
            using (Graphics g = Graphics.FromImage(btm))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                int parentIdBuffer, childIdBuffer, parentNodeAddress = 0, childNodeAddress = 0;

                for (int i = 0; i < links.Count(); i++)
                {
                    parentIdBuffer = links[i].parentNode;
                    childIdBuffer = links[i].childNode;
                    for (int j = 0; j < nodes.Count(); j++)
                    {
                        if (nodes[j].id == parentIdBuffer) parentNodeAddress = j;
                        if (nodes[j].id == childIdBuffer) childNodeAddress = j;
                    }
                    p = new Pen(Brushes.LightGray);
                    p.CustomEndCap = bigArrow;
                    g.DrawLine(p, new Point(nodes[parentNodeAddress].x + nodeSize / 2 - translateX, nodes[parentNodeAddress].y + nodeSize / 2 - translateY),
                                 new Point(nodes[childNodeAddress].x + nodeSize / 2 - translateX, nodes[childNodeAddress].y + nodeSize / 2 - translateY));
                }

                for (int i = 0; i < nodes.Count(); i++)
                {
                    if (nodes[i].type == "Document")
                    {
                        int children = 0;
                        for (int j = 0; j < links.Count(); j++)
                        {
                            if (nodes[i].id == links[j].parentNode) children++;
                        }

                        if (children > 0)
                        {
                            b = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(192,192,255));
                            r = new Rectangle(nodes[i].x - translateX, nodes[i].y - translateY, nodeSize, nodeSize);
                        }
                        else
                        {
                            b = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
                            r = new Rectangle(nodes[i].x - translateX, nodes[i].y - translateY, nodeSize, nodeSize);
                        }
                        g.FillEllipse(b, r);
                    }
                    else if (nodes[i].type == "Observation")
                    {
                        int children = 0;
                        for (int j = 0; j < links.Count(); j++)
                        {
                            if (nodes[i].id == links[j].parentNode) children++;
                        }

                        if (children > 0)
                        {
                            b = new System.Drawing.SolidBrush(System.Drawing.Color.Pink);
                            r = new Rectangle(nodes[i].x - translateX, nodes[i].y - translateY, nodeSize, nodeSize);
                        }
                        else
                        {
                            b = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                            r = new Rectangle(nodes[i].x - translateX, nodes[i].y - translateY, nodeSize, nodeSize);
                        }
                        g.FillEllipse(b, r);
                    }
                    else
                    {
                        int children = 0;
                        for (int j = 0; j < links.Count(); j++)
                        {
                            if (nodes[i].id == links[j].parentNode) children++;
                        }

                        if (children > 0)
                        {
                            b = new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen);
                            r = new Rectangle(nodes[i].x - translateX, nodes[i].y - translateY, nodeSize, nodeSize);
                        }
                        else
                        {
                            b = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
                            r = new Rectangle(nodes[i].x - translateX, nodes[i].y - translateY, nodeSize, nodeSize);
                        }
                        g.FillRectangle(b, r);
                    }


                    g.DrawString(nodes[i].name, mapFont, Brushes.Black, nodes[i].x + nodeSize + labelOffset - translateX, nodes[i].y - translateY);

                }

                PointF textLocation = new PointF(nodeSize, nodeSize);
                r = new Rectangle(0, 0, mapPicBx.Width, (int)(mapFont.Size * 5));
                if (message.Length > 0) g.FillRectangle(Brushes.LightGray, r);
                g.DrawString(message, mapFont, Brushes.Black, new PointF(nodeSize / 2, nodeSize / 2));
                if (mapPicBx.Image != null) mapPicBx.Image.Dispose();
                mapPicBx.Image = btm;
                mapPicBx.Refresh();
            
            }
            
        }
    }
}

