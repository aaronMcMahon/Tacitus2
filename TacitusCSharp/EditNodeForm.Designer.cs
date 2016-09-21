namespace TacitusCSharp
{
    partial class EditNodeForm
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
            this.openDialogBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pathLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathTxtBx = new System.Windows.Forms.TextBox();
            this.descTxtBx = new System.Windows.Forms.TextBox();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.saveNodeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openDialogBtn
            // 
            this.openDialogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openDialogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.openDialogBtn.Location = new System.Drawing.Point(689, 152);
            this.openDialogBtn.Name = "openDialogBtn";
            this.openDialogBtn.Size = new System.Drawing.Size(40, 28);
            this.openDialogBtn.TabIndex = 27;
            this.openDialogBtn.Text = "...";
            this.openDialogBtn.UseVisualStyleBackColor = false;
            this.openDialogBtn.Visible = false;
            this.openDialogBtn.Click += new System.EventHandler(this.openDialogBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Node Information";
            // 
            // pathLbl
            // 
            this.pathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pathLbl.AutoSize = true;
            this.pathLbl.Location = new System.Drawing.Point(24, 158);
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(63, 17);
            this.pathLbl.TabIndex = 25;
            this.pathLbl.Text = "File Path";
            this.pathLbl.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // pathTxtBx
            // 
            this.pathTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pathTxtBx.Location = new System.Drawing.Point(107, 155);
            this.pathTxtBx.Name = "pathTxtBx";
            this.pathTxtBx.Size = new System.Drawing.Size(587, 22);
            this.pathTxtBx.TabIndex = 21;
            this.pathTxtBx.Visible = false;
            // 
            // descTxtBx
            // 
            this.descTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descTxtBx.Location = new System.Drawing.Point(107, 127);
            this.descTxtBx.Name = "descTxtBx";
            this.descTxtBx.Size = new System.Drawing.Size(622, 22);
            this.descTxtBx.TabIndex = 19;
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameTxtBx.Location = new System.Drawing.Point(107, 98);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(234, 22);
            this.nameTxtBx.TabIndex = 18;
            // 
            // saveNodeBtn
            // 
            this.saveNodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveNodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveNodeBtn.Location = new System.Drawing.Point(666, 69);
            this.saveNodeBtn.Name = "saveNodeBtn";
            this.saveNodeBtn.Size = new System.Drawing.Size(63, 54);
            this.saveNodeBtn.TabIndex = 17;
            this.saveNodeBtn.Text = "Save";
            this.saveNodeBtn.UseVisualStyleBackColor = false;
            this.saveNodeBtn.Click += new System.EventHandler(this.saveNodeBtn_Click);
            // 
            // EditNodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(753, 237);
            this.Controls.Add(this.openDialogBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pathLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathTxtBx);
            this.Controls.Add(this.descTxtBx);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.saveNodeBtn);
            this.Name = "EditNodeForm";
            this.Text = "Edit Node Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openDialogBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pathTxtBx;
        private System.Windows.Forms.TextBox descTxtBx;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.Button saveNodeBtn;

    }
}