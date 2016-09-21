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
        void deleteProject(project projectBuffer)
        {
            //open connnection
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "DELETE DISTINCTROW linksTbl.* FROM linksTbl INNER JOIN nodesTbl on linksTbl.parentNode = nodesTbl.id WHERE nodesTbl.projectId = " + projectBuffer.id + ";";
                command.ExecuteNonQuery();
                command.CommandText = "DELETE DISTINCTROW linksTbl.* FROM linksTbl INNER JOIN nodesTbl on linksTbl.childNode = nodesTbl.id WHERE nodesTbl.projectId = " + projectBuffer.id + ";";
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            con.Close();
            //query and delete all nodes joined by projects
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "DELETE FROM nodesTbl WHERE nodesTbl.projectId = " + projectBuffer.id + ";";
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            con.Close();
            //delete project
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "DELETE FROM projectsTbl WHERE ID = " + projectBuffer.id + ";";
                command.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            con.Close();


        }
    }
}
