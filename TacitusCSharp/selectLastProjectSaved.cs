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
        void selectLastProjectSaved()
        {
            List<node> importedNodes = new List<node>();
           
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM nodesTbl;";
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

            int selectedProjectId = 0;
            DateTime youngest = importedNodes[0].timeStamp;

            for (int i = 0; i < importedNodes.Count(); i++)
            {
                if (importedNodes[i].timeStamp > youngest)
                {
                    youngest = importedNodes[i].timeStamp;
                    selectedProjectId = importedNodes[i].projectId;
                }
            }
            for (int i = 0; i < projects.Count(); i++)
            {
                if (projects[i].id == selectedProjectId) Program.selectedProject = projects[i];
            }
        }
    }
}
