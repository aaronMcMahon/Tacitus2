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
        void addLink(link newLink)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "INSERT INTO linksTbl VALUES (@ID, @parentNode, @childNode, @timeStamp);";
                command.Parameters.AddWithValue("@ID", newLink.id);
                command.Parameters.AddWithValue("@parentNode", newLink.parentNode);
                command.Parameters.AddWithValue("@childNode", newLink.childNode);
                command.Parameters.AddWithValue("@timeStamp", newLink.timeStamp.ToString());
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            con.Close();
        }
    }
}
