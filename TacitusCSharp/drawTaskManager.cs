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
        void drawTaskManager()
        {
            int nameX = 3 * nodeSize;
            int projectX = 6 * nameX;
            int descriptionX = 9 * nameX;
            btm = new Bitmap(tasksPicBx.Width, tasksPicBx.Height);
            g = Graphics.FromImage(btm);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            for (int i = 0; i < sortedNodes.Count(); i++)
            {
                b = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
                r = new Rectangle(nodeSize, nodeSize  * 2 * (i + 1) - translateY, nodeSize, nodeSize);
                g.FillRectangle(b, r);
                g.DrawString(sortedNodes[i].name, taskManagerFont, Brushes.Black,
                                new PointF(nameX, nodeSize * 2 * (i + 1) - translateY));
                for (int j = 0; j < projects.Count; j++)
                {
                    if (sortedNodes[i].projectId == projects[j].id)
                    {
                        g.DrawString(projects[j].projName, taskManagerFont, Brushes.Black,
                            new PointF(projectX, nodeSize * 2 * (i + 1) - translateY));
                    }
                }
                g.DrawString(sortedNodes[i].description, taskManagerFont, Brushes.Black,
                                new PointF(descriptionX, nodeSize * 2 * (i + 1) - translateY));
            }
            if (tasksPicBx.Image != null) tasksPicBx.Image.Dispose();
            tasksPicBx.Image = btm;
            tasksPicBx.Refresh();
        }

    }
}
