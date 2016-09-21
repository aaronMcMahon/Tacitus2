namespace TacitusCSharp
{
    partial class homeForm
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
            this.mapPicBx = new System.Windows.Forms.PictureBox();
            this.addNodeBtn = new System.Windows.Forms.Button();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.descTxtBx = new System.Windows.Forms.TextBox();
            this.nodeTypeCbo = new System.Windows.Forms.ComboBox();
            this.pathTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pathLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openDialogBtn = new System.Windows.Forms.Button();
            this.addLinkBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteNodeBtn = new System.Windows.Forms.Button();
            this.deleteLinkBtn = new System.Windows.Forms.Button();
            this.openDocBtn = new System.Windows.Forms.Button();
            this.moveNodeBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayBtn = new System.Windows.Forms.Button();
            this.selectedProjectLbl = new System.Windows.Forms.Label();
            this.transferBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mapPicBx)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPicBx
            // 
            this.mapPicBx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPicBx.BackColor = System.Drawing.SystemColors.Window;
            this.mapPicBx.Location = new System.Drawing.Point(0, 90);
            this.mapPicBx.Name = "mapPicBx";
            this.mapPicBx.Size = new System.Drawing.Size(891, 604);
            this.mapPicBx.TabIndex = 3;
            this.mapPicBx.TabStop = false;
            this.mapPicBx.SizeChanged += new System.EventHandler(this.mapPicBx_SizeChanged);
            this.mapPicBx.Click += new System.EventHandler(this.mapPicBx_Click);
            // 
            // addNodeBtn
            // 
            this.addNodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addNodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addNodeBtn.Location = new System.Drawing.Point(659, 51);
            this.addNodeBtn.Name = "addNodeBtn";
            this.addNodeBtn.Size = new System.Drawing.Size(63, 54);
            this.addNodeBtn.TabIndex = 4;
            this.addNodeBtn.Text = "Add Node";
            this.addNodeBtn.UseVisualStyleBackColor = false;
            this.addNodeBtn.Click += new System.EventHandler(this.addNodeBtn_Click);
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameTxtBx.Location = new System.Drawing.Point(100, 80);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(234, 22);
            this.nameTxtBx.TabIndex = 5;
            // 
            // descTxtBx
            // 
            this.descTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descTxtBx.Location = new System.Drawing.Point(100, 109);
            this.descTxtBx.Name = "descTxtBx";
            this.descTxtBx.Size = new System.Drawing.Size(622, 22);
            this.descTxtBx.TabIndex = 6;
            // 
            // nodeTypeCbo
            // 
            this.nodeTypeCbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nodeTypeCbo.FormattingEnabled = true;
            this.nodeTypeCbo.Location = new System.Drawing.Point(100, 51);
            this.nodeTypeCbo.Name = "nodeTypeCbo";
            this.nodeTypeCbo.Size = new System.Drawing.Size(113, 24);
            this.nodeTypeCbo.TabIndex = 7;
            this.nodeTypeCbo.TextChanged += new System.EventHandler(this.nodeTypeCbo_TextChanged);
            // 
            // pathTxtBx
            // 
            this.pathTxtBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pathTxtBx.Location = new System.Drawing.Point(100, 137);
            this.pathTxtBx.Name = "pathTxtBx";
            this.pathTxtBx.Size = new System.Drawing.Size(587, 22);
            this.pathTxtBx.TabIndex = 8;
            this.pathTxtBx.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // pathLbl
            // 
            this.pathLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pathLbl.AutoSize = true;
            this.pathLbl.Location = new System.Drawing.Point(17, 140);
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(63, 17);
            this.pathLbl.TabIndex = 12;
            this.pathLbl.Text = "File Path";
            this.pathLbl.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Node Information";
            // 
            // openDialogBtn
            // 
            this.openDialogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openDialogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.openDialogBtn.Location = new System.Drawing.Point(682, 134);
            this.openDialogBtn.Name = "openDialogBtn";
            this.openDialogBtn.Size = new System.Drawing.Size(40, 28);
            this.openDialogBtn.TabIndex = 14;
            this.openDialogBtn.Text = "...";
            this.openDialogBtn.UseVisualStyleBackColor = false;
            this.openDialogBtn.Visible = false;
            this.openDialogBtn.Click += new System.EventHandler(this.openDialogBtn_Click);
            // 
            // addLinkBtn
            // 
            this.addLinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addLinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addLinkBtn.Location = new System.Drawing.Point(109, 1);
            this.addLinkBtn.Name = "addLinkBtn";
            this.addLinkBtn.Size = new System.Drawing.Size(114, 27);
            this.addLinkBtn.TabIndex = 15;
            this.addLinkBtn.Text = "Add Link";
            this.addLinkBtn.UseVisualStyleBackColor = false;
            this.addLinkBtn.Click += new System.EventHandler(this.addLinkBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveBtn.Location = new System.Drawing.Point(0, 1);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveBtn.Size = new System.Drawing.Size(114, 27);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteNodeBtn
            // 
            this.deleteNodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteNodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteNodeBtn.Location = new System.Drawing.Point(220, 1);
            this.deleteNodeBtn.Name = "deleteNodeBtn";
            this.deleteNodeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteNodeBtn.Size = new System.Drawing.Size(114, 27);
            this.deleteNodeBtn.TabIndex = 17;
            this.deleteNodeBtn.Text = "Delete Node";
            this.deleteNodeBtn.UseVisualStyleBackColor = false;
            this.deleteNodeBtn.Click += new System.EventHandler(this.deleteNodeBtn_Click);
            // 
            // deleteLinkBtn
            // 
            this.deleteLinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteLinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteLinkBtn.Location = new System.Drawing.Point(331, 1);
            this.deleteLinkBtn.Name = "deleteLinkBtn";
            this.deleteLinkBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteLinkBtn.Size = new System.Drawing.Size(114, 27);
            this.deleteLinkBtn.TabIndex = 18;
            this.deleteLinkBtn.Text = "Delete Link";
            this.deleteLinkBtn.UseVisualStyleBackColor = false;
            this.deleteLinkBtn.Click += new System.EventHandler(this.deleteLinkBtn_Click);
            // 
            // openDocBtn
            // 
            this.openDocBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openDocBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.openDocBtn.Location = new System.Drawing.Point(441, 1);
            this.openDocBtn.Name = "openDocBtn";
            this.openDocBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.openDocBtn.Size = new System.Drawing.Size(114, 27);
            this.openDocBtn.TabIndex = 19;
            this.openDocBtn.Text = "Open Doc";
            this.openDocBtn.UseVisualStyleBackColor = false;
            this.openDocBtn.Click += new System.EventHandler(this.openDocBtn_Click);
            // 
            // moveNodeBtn
            // 
            this.moveNodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveNodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.moveNodeBtn.Location = new System.Drawing.Point(550, 1);
            this.moveNodeBtn.Name = "moveNodeBtn";
            this.moveNodeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moveNodeBtn.Size = new System.Drawing.Size(114, 27);
            this.moveNodeBtn.TabIndex = 20;
            this.moveNodeBtn.Text = "Move Node";
            this.moveNodeBtn.UseVisualStyleBackColor = false;
            this.moveNodeBtn.Click += new System.EventHandler(this.moveNodeBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.taskManagerToolStripMenuItem,
            this.deleteProjectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "New Project";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            this.taskManagerToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.taskManagerToolStripMenuItem.Text = "Task Manager";
            this.taskManagerToolStripMenuItem.Click += new System.EventHandler(this.taskManagerToolStripMenuItem_Click);
            // 
            // deleteProjectToolStripMenuItem
            // 
            this.deleteProjectToolStripMenuItem.Name = "deleteProjectToolStripMenuItem";
            this.deleteProjectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.deleteProjectToolStripMenuItem.Text = "Delete Project";
            this.deleteProjectToolStripMenuItem.Click += new System.EventHandler(this.deleteProjectToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.editNodeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.projectToolStripMenuItem.Text = "Project Details";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // editNodeToolStripMenuItem
            // 
            this.editNodeToolStripMenuItem.Name = "editNodeToolStripMenuItem";
            this.editNodeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.editNodeToolStripMenuItem.Text = "Node Details";
            this.editNodeToolStripMenuItem.Click += new System.EventHandler(this.editNodeToolStripMenuItem_Click);
            // 
            // replayBtn
            // 
            this.replayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.replayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.replayBtn.Location = new System.Drawing.Point(660, 1);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(114, 27);
            this.replayBtn.TabIndex = 22;
            this.replayBtn.Text = "Replay";
            this.replayBtn.UseVisualStyleBackColor = false;
            this.replayBtn.Click += new System.EventHandler(this.replayBtn_Click);
            // 
            // selectedProjectLbl
            // 
            this.selectedProjectLbl.AutoSize = true;
            this.selectedProjectLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedProjectLbl.Location = new System.Drawing.Point(3, 67);
            this.selectedProjectLbl.Name = "selectedProjectLbl";
            this.selectedProjectLbl.Size = new System.Drawing.Size(157, 20);
            this.selectedProjectLbl.TabIndex = 23;
            this.selectedProjectLbl.Text = "<Open a Project>";
            this.selectedProjectLbl.Click += new System.EventHandler(this.selectedProjectLbl_Click);
            // 
            // transferBtn
            // 
            this.transferBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.transferBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.transferBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.transferBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.transferBtn.Location = new System.Drawing.Point(770, 1);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(114, 27);
            this.transferBtn.TabIndex = 24;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = false;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.transferBtn);
            this.panel1.Controls.Add(this.replayBtn);
            this.panel1.Controls.Add(this.moveNodeBtn);
            this.panel1.Controls.Add(this.openDocBtn);
            this.panel1.Controls.Add(this.deleteLinkBtn);
            this.panel1.Controls.Add(this.deleteNodeBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.addLinkBtn);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 29);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.openDialogBtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pathLbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pathTxtBx);
            this.panel2.Controls.Add(this.nodeTypeCbo);
            this.panel2.Controls.Add(this.descTxtBx);
            this.panel2.Controls.Add(this.nameTxtBx);
            this.panel2.Controls.Add(this.addNodeBtn);
            this.panel2.Location = new System.Drawing.Point(0, 692);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 177);
            this.panel2.TabIndex = 26;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(891, 870);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectedProjectLbl);
            this.Controls.Add(this.mapPicBx);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "homeForm";
            this.Text = "Tacitus - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.homeForm_FormClosing);
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.ResizeEnd += new System.EventHandler(this.homeForm_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.homeForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mapPicBx)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPicBx;
        private System.Windows.Forms.Button addNodeBtn;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox descTxtBx;
        private System.Windows.Forms.ComboBox nodeTypeCbo;
        private System.Windows.Forms.TextBox pathTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button openDialogBtn;
        private System.Windows.Forms.Button addLinkBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteNodeBtn;
        private System.Windows.Forms.Button deleteLinkBtn;
        private System.Windows.Forms.Button openDocBtn;
        private System.Windows.Forms.Button moveNodeBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button replayBtn;
        private System.Windows.Forms.ToolStripMenuItem taskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.Label selectedProjectLbl;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem deleteProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;

    }
}

