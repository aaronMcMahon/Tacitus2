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
    public partial class EditNodeForm : Form
    {
        public EditNodeForm(node importedNode, int top, int left)
        {
            Program.editedNode = importedNode;
            this.StartPosition = FormStartPosition.Manual;
            this.Top = top;
            this.Left = left;

            InitializeComponent();


            this.nameTxtBx.Text = Program.editedNode.name;
            this.descTxtBx.Text = Program.editedNode.description;
            this.pathTxtBx.Text = Program.editedNode.fileLocation;
            if (Program.editedNode.type == "Document")
            {
                pathTxtBx.Visible = true;
                openDialogBtn.Visible = true;
                pathLbl.Visible = true;
            }
            else
            {
                pathTxtBx.Visible = false;
                pathTxtBx.Text = "";
                openDialogBtn.Visible = false;
                pathLbl.Visible = false;

            }
        }

        private void openDialogBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = pathLbl.Text;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathTxtBx.Text = ofd.FileName;
            }
        }

        private void saveNodeBtn_Click(object sender, EventArgs e)
        {
            Program.editedNode.name = this.nameTxtBx.Text;
            Program.editedNode.description = this.descTxtBx.Text;
            Program.editedNode.fileLocation = this.pathTxtBx.Text;
            this.Close();
        }
    }
}
