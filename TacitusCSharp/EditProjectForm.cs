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
    public partial class EditProjectForm : Form
    {
        public OleDbConnection con = new OleDbConnection();

        public EditProjectForm(int top, int left)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Top = top;
            this.Left = left;
            InitializeComponent();
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\Tacitus\\tacitusDb.accdb; Persist Security Info=False;";

            this.nameTxtBx.Text = Program.editedProject.projName;
            this.descTxtBx.Text = Program.editedProject.projDesc;
            this.directoryLbl.Text = Program.editedProject.projPath;
            if (Program.editedProject.archived == true) this.archiveChkBx.Checked = true;
          
        }

        private void chooseDirectoryBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directoryLbl.Text = fdb.SelectedPath;
            }
        }

        private void saveProjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "UPDATE projectsTbl SET directory=@projPath, projName=@projName, projDescription=@projDescr, archived=@archived WHERE ID = " + Program.editedProject.id;
                command.Parameters.AddWithValue("@projPath", this.directoryLbl.Text);
                command.Parameters.AddWithValue("@projName", this.nameTxtBx.Text);
                command.Parameters.AddWithValue("@projDescr", this.descTxtBx.Text);
                command.Parameters.AddWithValue("@archived", this.archiveChkBx.Checked);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            con.Close();
            this.Close();
        }
    }
}
