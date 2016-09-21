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
        void addNode (node newNode)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "INSERT INTO nodesTbl VALUES (@ID, @projectID, @nodeX, @nodeY, @nodeType, @nodeName, @nodeDescr, @nodeFile, @timeStamp);";
                command.Parameters.AddWithValue("@ID", newNode.id);
                command.Parameters.AddWithValue("@projectID", newNode.projectId);
                command.Parameters.AddWithValue("@nodeX", newNode.x);
                command.Parameters.AddWithValue("@nodeY", newNode.y);
                command.Parameters.AddWithValue("@nodeType", newNode.type);
                command.Parameters.AddWithValue("@nodeName", newNode.name);
                command.Parameters.AddWithValue("@nodeDescr", newNode.description);
                command.Parameters.AddWithValue("@nodeFile", newNode.fileLocation);
                command.Parameters.AddWithValue("@timeStamp", newNode.timeStamp.ToString());
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
