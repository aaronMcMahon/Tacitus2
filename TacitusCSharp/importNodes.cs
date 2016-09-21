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
        List<node> importNodes ()
        {
            undoStatesList = new List<undoState>();
            List<node> importedNodes = new List<node>();
           
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM nodesTbl WHERE projectId = " + Program.selectedProject.id + ";";
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
            return importedNodes;
        }
    }
}
