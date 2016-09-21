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
        void updateNode(node changedNode)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "UPDATE nodesTbl SET projectId=@projectId, nodeX=@nodeX, nodeY=@nodeY, nodeType=@nodeType, nodeName=@nodeName, nodeDescr=@nodeDescr, nodeFile=@nodeFile WHERE ID = " + changedNode.id;
                command.Parameters.AddWithValue("@projectId", changedNode.projectId);
                command.Parameters.AddWithValue("@nodeX", changedNode.x);
                command.Parameters.AddWithValue("@nodeY", changedNode.y);
                command.Parameters.AddWithValue("@nodeType", changedNode.type);
                command.Parameters.AddWithValue("@nodeName", changedNode.name);
                command.Parameters.AddWithValue("@nodeDescr", changedNode.description);
                command.Parameters.AddWithValue("@nodeFile", changedNode.fileLocation);
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
