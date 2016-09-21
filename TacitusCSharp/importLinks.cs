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
        List<link> importLinks()
        {
            List<link> importedLinks = new List<link>();
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT linksTbl.ID, linksTbl.parentNode, linksTbl.childNode, linksTbl.timeStamp FROM projectsTbl INNER JOIN (nodesTbl INNER JOIN linksTbl ON nodesTbl.ID = linksTbl.parentNode) ON projectsTbl.ID = nodesTbl.projectId WHERE (((nodesTbl.projectId)= " + Program.selectedProject.id + "));";
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    importedLinks.Add(new link()
                    {
                        id = Int32.Parse(reader[0].ToString()),
                        parentNode = Int32.Parse(reader[1].ToString()),
                        childNode = Int32.Parse(reader[2].ToString()),
                        timeStamp = DateTime.Parse(reader[3].ToString())
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            con.Close();
            return importedLinks;
        }
    }
}
