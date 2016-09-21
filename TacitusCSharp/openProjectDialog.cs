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
    public static class openProjectDialog
    {
        public static project ShowDialog(string text, string caption, BindingList<project> projects, int top, int left)
        {
            Form prompt = new Form();
            project projectBuffer = new project();
            prompt.Width = 500;
            prompt.Height = 200;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.Manual;
            prompt.Top = top;
            prompt.Left = left;
            prompt.BackColor = Color.FromArgb(192, 192, 255);
            CheckBox showArchived = new CheckBox() { Left = 50, Top = 70 };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            ComboBox projectsCbo = new ComboBox() { Left = 50, Top = 50, Width = 400 };
            //NumericUpDown inputBox = new NumericUpDown() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 80 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(projectsCbo);
            
            projectsCbo.DataSource = projects;
            projectsCbo.ValueMember = "id";
            projectsCbo.DisplayMember = "projName";
            prompt.ShowDialog();

            projectBuffer = (project) projectsCbo.SelectedItem;
            //projectBuffer.id = (int)projectsCbo.SelectedValue;
            //projectBuffer.projName = projectsCbo.Text;

            return projectBuffer;
        }
    }
}
