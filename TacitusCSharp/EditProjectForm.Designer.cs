namespace TacitusCSharp
{
    partial class EditProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseDirectoryBtn = new System.Windows.Forms.Button();
            this.directoryLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descTxtBx = new System.Windows.Forms.TextBox();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveProjectBtn = new System.Windows.Forms.Button();
            this.archiveChkBx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chooseDirectoryBtn
            // 
            this.chooseDirectoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chooseDirectoryBtn.Location = new System.Drawing.Point(16, 139);
            this.chooseDirectoryBtn.Name = "chooseDirectoryBtn";
            this.chooseDirectoryBtn.Size = new System.Drawing.Size(34, 23);
            this.chooseDirectoryBtn.TabIndex = 13;
            this.chooseDirectoryBtn.Text = "...";
            this.chooseDirectoryBtn.UseVisualStyleBackColor = false;
            this.chooseDirectoryBtn.Click += new System.EventHandler(this.chooseDirectoryBtn_Click);
            // 
            // directoryLbl
            // 
            this.directoryLbl.AutoSize = true;
            this.directoryLbl.Location = new System.Drawing.Point(56, 141);
            this.directoryLbl.Name = "directoryLbl";
            this.directoryLbl.Size = new System.Drawing.Size(25, 17);
            this.directoryLbl.TabIndex = 12;
            this.directoryLbl.Text = "C:\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Home Directory";
            // 
            // descTxtBx
            // 
            this.descTxtBx.Location = new System.Drawing.Point(16, 92);
            this.descTxtBx.Name = "descTxtBx";
            this.descTxtBx.Size = new System.Drawing.Size(760, 22);
            this.descTxtBx.TabIndex = 10;
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(16, 45);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(760, 22);
            this.nameTxtBx.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Project Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Project Name";
            // 
            // saveProjectBtn
            // 
            this.saveProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveProjectBtn.Location = new System.Drawing.Point(706, 195);
            this.saveProjectBtn.Name = "saveProjectBtn";
            this.saveProjectBtn.Size = new System.Drawing.Size(75, 23);
            this.saveProjectBtn.TabIndex = 14;
            this.saveProjectBtn.Text = "Save";
            this.saveProjectBtn.UseVisualStyleBackColor = false;
            this.saveProjectBtn.Click += new System.EventHandler(this.saveProjectBtn_Click);
            // 
            // archiveChkBx
            // 
            this.archiveChkBx.AutoSize = true;
            this.archiveChkBx.Location = new System.Drawing.Point(19, 183);
            this.archiveChkBx.Name = "archiveChkBx";
            this.archiveChkBx.Size = new System.Drawing.Size(85, 21);
            this.archiveChkBx.TabIndex = 15;
            this.archiveChkBx.Text = "Archived";
            this.archiveChkBx.UseVisualStyleBackColor = true;
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(793, 230);
            this.Controls.Add(this.archiveChkBx);
            this.Controls.Add(this.saveProjectBtn);
            this.Controls.Add(this.chooseDirectoryBtn);
            this.Controls.Add(this.directoryLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descTxtBx);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProjectForm";
            this.Text = "Edit Project Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseDirectoryBtn;
        private System.Windows.Forms.Label directoryLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descTxtBx;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveProjectBtn;
        private System.Windows.Forms.CheckBox archiveChkBx;
    }
}