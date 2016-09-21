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
        void listProjects()
        {
            projects.Clear();
            //find all projects in database and put them in the project combo box
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM projectsTbl WHERE archived = FALSE;";
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

            List<project> sortedProjects = new List<project>();
            sortedProjects = projects.OrderBy(o => o.projName).ToList();
            projects = new BindingList<project>(sortedProjects);
        }
    }
}
