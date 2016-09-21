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
    public partial class newProjectForm : Form
    {
        public OleDbConnection con = new OleDbConnection();
        public int newProjectId;
        DateTime localDate = DateTime.Now;

        public newProjectForm(int top, int left)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = top;
            this.Left = left;
            InitializeComponent();
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
       
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\Tacitus\\tacitusDb.accdb; Persist Security Info=False;";
        }

        private void createProjectBtn_Click(object sender, EventArgs e)
        {
            try
            {              
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "INSERT INTO projectsTbl (projName, projDescription, directory) VALUES (@projName, @projDescription, @directory);";
                command.Parameters.AddWithValue("@projName", nameTxtBx.Text);
                command.Parameters.AddWithValue("@projDescription", descTxtBx.Text);
                command.Parameters.AddWithValue("@directory", directoryLbl.Text);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT @@Identity";
                Program.selectedProject.id = (int)command.ExecuteScalar();
                //command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            con.Close();
            this.Hide();

        }

        private void chooseDirectoryBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directoryLbl.Text = fdb.SelectedPath;
            }
        }
    }
}
