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
        public OleDbConnection con = new OleDbConnection();
        List<node> importedNodes = new List<node>();
        List<node> sortedNodes = new List<node>();
        List<node> taskNodes = new List<node>();
        List<link> links = new List<link>();
        List<project> projects = new List<project>();
        Bitmap btm;
        Rectangle r;
        SolidBrush b;
        Graphics g;
        bool children = false;
        int nodeSize = 15;
        Font taskManagerFont = new Font(SystemFonts.DefaultFont.FontFamily, 10, FontStyle.Regular);
        int translateY = 0;
        int frameRate = 20;

        public taskManagerForm(int top, int left)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = top;
            this.Left = left;
            InitializeComponent();
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;       
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\Tacitus\\tacitusDb.accdb; Persist Security Info=False;";

            //import projects
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM projectsTbl;";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    projects.Add(new project()
                    {
                        id = Int32.Parse(reader[0].ToString()),
                        projName = reader[1].ToString(),
                        projDesc = reader[2].ToString(),
                        projPath = reader[3].ToString()
                    });
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            //import nodes
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM nodesTbl WHERE nodeType = 'Task';";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    importedNodes.Add(new node()
                    {
                        id = Int32.Parse(reader[0].ToString()),
                        projectId = Int32.Parse(reader[1].ToString()),
                        x = Int32.Parse(reader[2].ToString()),
                        y = Int32.Parse(reader[3].ToString()),
                        type = reader[4].ToString(),
                        name = reader[5].ToString(),
                        description = reader[6].ToString(),
                        fileLocation = reader[7].ToString(),
                        timeStamp = DateTime.Parse(reader[8].ToString())
                    });
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            //import edges
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM linksTbl;";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    links.Add(new link()
                    {
                        id = Int32.Parse(reader[0].ToString()),
                        parentNode = Int32.Parse(reader[1].ToString()),
                        childNode = Int32.Parse(reader[2].ToString()),
                        timeStamp = DateTime.Parse(reader[3].ToString())
                    });
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


            //save nodes with no children to a list and sort
            for (int i = 0; i < importedNodes.Count(); i++)
            {
                for (int j = 0; j < links.Count(); j++)
                {
                    if (importedNodes[i].id == links[j].parentNode) children = true;

                }
                if (!children)
                {
                    taskNodes.Add(importedNodes[i]);
                }
                children = false;
            }

            sortedNodes = taskNodes.OrderBy(o => o.projectId).ToList();
            drawTaskManager();
            tasksPicBx.Image = btm;

        }

        private void tasksPicBx_Click(object sender, EventArgs e)
        {
            tasksPicBx.Focus();
            var mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs != null)
            {
                int nodeIdBuffer = checkForTaskNode(mouseEventArgs.X, mouseEventArgs.Y);
                for (int i = 0; i < taskNodes.Count(); i++)
                {
                    if (sortedNodes[i].id == nodeIdBuffer)
                    {
                        Program.selectedTask = sortedNodes[i];
                        for (int j = 0; j < projects.Count(); j++)
                        {
                            if (projects[j].id == Program.selectedTask.projectId)
                            {
                                Program.selectedProject = projects[j];
                            }
                        }
                        this.Close();
                    }
                }

            }
        }

        private void taskManagerForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    for (int i = 0; i < frameRate; i++)
                    {
                        translateY -= (tasksPicBx.Height / 4) / frameRate;
                        drawTaskManager();

                    }
                    break;

                case Keys.PageUp:
                                        for (int i = 0; i < frameRate; i++)
                    {
                        translateY -= (tasksPicBx.Height / 4) / frameRate;
                        drawTaskManager();

                    }
                    break;

                case Keys.S:
                    for (int i = 0; i < frameRate; i++)
                    {
                        translateY += (tasksPicBx.Height / 4) / frameRate;
                        drawTaskManager();
                    }
                    break;
                case Keys.PageDown:
                    for (int i = 0; i < frameRate; i++)
                    {
                        translateY += (tasksPicBx.Height / 4) / frameRate;
                        drawTaskManager();
                    }
                    break;
            }
        }

        private void tasksPicBx_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != System.Windows.Forms.FormWindowState.Minimized) drawTaskManager();
        }
    }
}
