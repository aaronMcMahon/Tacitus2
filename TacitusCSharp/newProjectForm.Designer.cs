namespace TacitusCSharp
{
    partial class newProjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.descTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.directoryLbl = new System.Windows.Forms.Label();
            this.chooseDirectoryBtn = new System.Windows.Forms.Button();
            this.createProjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Description";
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(21, 57);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(760, 22);
            this.nameTxtBx.TabIndex = 2;
            // 
            // descTxtBx
            // 
            this.descTxtBx.Location = new System.Drawing.Point(21, 104);
            this.descTxtBx.Name = "descTxtBx";
            this.descTxtBx.Size = new System.Drawing.Size(760, 22);
            this.descTxtBx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Home Directory";
            // 
            // directoryLbl
            // 
            this.directoryLbl.AutoSize = true;
            this.directoryLbl.Location = new System.Drawing.Point(61, 153);
            this.directoryLbl.Name = "directoryLbl";
            this.directoryLbl.Size = new System.Drawing.Size(25, 17);
            this.directoryLbl.TabIndex = 5;
            this.directoryLbl.Text = "C:\\";
            // 
            // chooseDirectoryBtn
            // 
            this.chooseDirectoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chooseDirectoryBtn.Location = new System.Drawing.Point(21, 151);
            this.chooseDirectoryBtn.Name = "chooseDirectoryBtn";
            this.chooseDirectoryBtn.Size = new System.Drawing.Size(34, 23);
            this.chooseDirectoryBtn.TabIndex = 6;
            this.chooseDirectoryBtn.Text = "...";
            this.chooseDirectoryBtn.UseVisualStyleBackColor = false;
            this.chooseDirectoryBtn.Click += new System.EventHandler(this.chooseDirectoryBtn_Click);
            // 
            // createProjectBtn
            // 
            this.createProjectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.createProjectBtn.Location = new System.Drawing.Point(706, 150);
            this.createProjectBtn.Name = "createProjectBtn";
            this.createProjectBtn.Size = new System.Drawing.Size(75, 23);
            this.createProjectBtn.TabIndex = 7;
            this.createProjectBtn.Text = "Create";
            this.createProjectBtn.UseVisualStyleBackColor = false;
            this.createProjectBtn.Click += new System.EventHandler(this.createProjectBtn_Click);
            // 
            // newProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(793, 186);
            this.Controls.Add(this.createProjectBtn);
            this.Controls.Add(this.chooseDirectoryBtn);
            this.Controls.Add(this.directoryLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descTxtBx);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newProjectForm";
            this.Text = "Create New Project";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox descTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label directoryLbl;
        private System.Windows.Forms.Button chooseDirectoryBtn;
        private System.Windows.Forms.Button createProjectBtn;
    }
}