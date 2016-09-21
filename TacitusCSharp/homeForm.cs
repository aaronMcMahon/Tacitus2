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
        public homeForm()
        {
            InitializeComponent();
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;      
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\Tacitus\\tacitusDb.accdb; Persist Security Info=False;";

            //record highest id number for nodes table
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM nodesTbl;";
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (Int32.Parse(reader[0].ToString()) > nodeIdMax) nodeIdMax = Int32.Parse(reader[0].ToString()); 
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
            //record highest id number for links
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM linksTbl;";
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (Int32.Parse(reader[0].ToString()) > linkIdMax) linkIdMax = Int32.Parse(reader[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void mapPicBx_Click(object sender, EventArgs e)
        {
            mapPicBx.Focus();
            var mouseEventArgs = e as MouseEventArgs;
            bool linkDeleted = false;
            if (mouseEventArgs != null)
            {
                if (mouseEventArgs.Button == MouseButtons.Right)
                {
                    int nodeIdBuffer = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);
                    if(nodeIdBuffer !=  -1)
                    {
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                        path += "\\Tacitus\\lift.wav";
                        player = new System.Media.SoundPlayer(path);
                        player.Play();
                        recordUndoState();
                        for (int i = 0; i < nodes.Count(); i++)
                        {
                            if (nodes[i].id == nodeIdBuffer)
                            {
                                nodeBuffer = nodes[i];                    
                                List<nodeTransition> parentTrans = new List<nodeTransition>();
                                List<nodeTransition> childTrans = new List<nodeTransition>();
                                parentTrans = parentTransition(nodeBuffer);
                                childTrans = childTransition(nodeBuffer);
                                for (int k = 0; k < panFrame; k++)
                                {
                                    for (int I = 0; I < parentTrans.Count(); I++)
                                    {
                                        for (int j = 0; j < nodes.Count(); j++)
                                        {
                                            if (parentTrans[I].id == nodes[j].id)
                                            {
                                                nodes[j].x += parentTrans[I].deltaX(panFrame);
                                                nodes[j].y += parentTrans[I].deltaY(panFrame, nodeSize);
                                            }
                                        }
                                    }
                                    for (int I = 0; I < childTrans.Count(); I++)
                                    {
                                        for (int j = 0; j < nodes.Count(); j++)
                                        {
                                            if (childTrans[I].id == nodes[j].id)
                                            {
                                                nodes[j].x += childTrans[I].deltaX(panFrame);
                                                nodes[j].y += childTrans[I].deltaY(panFrame, nodeSize);
                                            }
                                        }
                                    }
                                    drawMap(links, nodes);
                                }

                                for (int I = 0; I < parentTrans.Count(); I++)
                                {
                                    for (int j = 0; j < nodes.Count(); j++)
                                    {
                                        if (parentTrans[I].id == nodes[j].id)
                                        {
                                            nodes[j].x = parentTrans[I].updatedX;
                                            nodes[j].y = parentTrans[I].updatedY - nodeSize;
                                        }
                                    }
                                }
                                for (int I = 0; I < childTrans.Count(); I++)
                                {
                                    for (int j = 0; j < nodes.Count(); j++)
                                    {
                                        if (childTrans[I].id == nodes[j].id)
                                        {
                                            nodes[j].x = childTrans[I].updatedX;
                                            nodes[j].y = childTrans[I].updatedY - nodeSize;
                                        }
                                    }
                                }
                                drawMap(links, nodes);
                            }
                        }
                    }
                }
                else if (addingNode)
                {
                    addingNode = false;
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    switch (nodeBuffer.type )
                    {
                        case "Document":
                            path += "\\Tacitus\\thud.wav";
                            break;
                        case "Observation":
                            path += "\\Tacitus\\chime.wav";
                            break;
                        case "Task":
                            path += "\\Tacitus\\gear.wav";
                            break;
                    }
                    player = new System.Media.SoundPlayer(path);
                    player.Play();
                    nodeBuffer.x = mouseEventArgs.X + translateX;
                    nodeBuffer.y = mouseEventArgs.Y + translateY;
                    localDate = DateTime.Now;
                    nodeBuffer.timeStamp = localDate;
                    recordUndoState();

                    nodes.Add(nodeBuffer);
                    message = "";
                }
                else if (addingLinkParent)
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    path += "\\Tacitus\\click.wav";
                    player = new System.Media.SoundPlayer(path);
                    player.Play();
                    linkBuffer.parentNode = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);
                    addingLinkParent = false;
                    addingLinkChild = true;
                    message = "Select Child Node";
                }
                else if (addingLinkChild)
                {
                    string parentNodeType = "";
                    string childNodeType = "";
                    linkBuffer.childNode = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);

                    if (linkBuffer.parentNode != -1 && linkBuffer.childNode != -1 && linkBuffer.parentNode != linkBuffer.childNode)
                    {
                        for (int i = 0; i < nodes.Count(); i++)
                        {
                            if (nodes[i].id == linkBuffer.parentNode)
                            {
                                parentNodeType = nodes[i].type;
                            }
                            else if (nodes[i].id == linkBuffer.childNode)
                            {
                                childNodeType = nodes[i].type;
                            }
                        }
                        if (parentNodeType == "Task" || childNodeType == "Task")
                        {
                            if (parentNodeType != childNodeType)
                            {
                                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                                path += "\\Tacitus\\link.wav";
                                player = new System.Media.SoundPlayer(path);
                                player.Play();
                                linkIdMax++;
                                linkBuffer.id = linkIdMax;
                                localDate = DateTime.Now;
                                linkBuffer.timeStamp = localDate;
                                recordUndoState();
                                links.Add(linkBuffer);
                                message = "";
                            }
                            else message = "Invalid Link - Don't link two Task Nodes";
                        }
                        else message = "Invalid Link - Must include one Task Node ";

                    }
                    else message = "Invalid Link - Must include two Nodes";
                    addingLinkChild = false;
                }
                else if (deletingNode)
                {
                    int nodeIdBuffer = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);
                    for (int i = 0; i < nodes.Count(); i++)
                    {
                        if (nodes[i].id == nodeIdBuffer)
                        {
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                            path += "\\Tacitus\\cut.wav";
                            player = new System.Media.SoundPlayer(path);
                            player.Play();
                            recordUndoState();
                            nodes.RemoveAt(i);
                            message = "Node Deleted";
                            deletingNode = false;
                        }
                    }
                    for (int i = 0; i < links.Count(); i++)
                    {
                        if (links[i].parentNode == nodeIdBuffer || links[i].childNode == nodeIdBuffer)
                        {
                            recordUndoState();
                            links.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (deletingLinkParent)
                {
                    linkBuffer.parentNode = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);
                    if (linkBuffer.parentNode == -1)
                    {
                        deletingLinkParent = false;
                        message = "Invalid Link";
                    }
                    else
                    {
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                        path += "\\Tacitus\\click.wav";
                        player = new System.Media.SoundPlayer(path);
                        player.Play();
                        deletingLinkParent = false;
                        deletingLinkChild = true;
                        message = "Deleting Link - Select Child Node";
                    }

                }
                else if (deletingLinkChild)
                {
                    linkBuffer.childNode = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);
                    if (linkBuffer.childNode == -1)
                    {
                        deletingLinkChild = false;
                        message = "Invalid Link";
                    }
                    else
                    {
                        for (int i = 0; i < links.Count(); i++)
                        {
                            if (links[i].parentNode == linkBuffer.parentNode && links[i].childNode == linkBuffer.childNode)
                            {
                                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                                path += "\\Tacitus\\cut.wav";
                                player = new System.Media.SoundPlayer(path);
                                player.Play();
                                recordUndoState();
                                links.RemoveAt(i);
                                i--;
                                linkDeleted = true;
                                message = "Link Deleted";
                            }
                        }
                        if (!linkDeleted)
                        {
                            message = "Invalid Link";
                        }
                        deletingLinkChild = false;
                    }

                }
                else if (openingDocument)
                {
                    int nodeIdBuffer = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);
                    if (nodeIdBuffer != -1)
                    {
                        bool docNodeSelected = false;
                        for (int i = 0; i < nodes.Count(); i++)
                        {
                            if (nodes[i].id == nodeIdBuffer && nodes[i].type == "Document")
                            {
                                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                                path += "\\Tacitus\\thud.wav";
                                player = new System.Media.SoundPlayer(path);
                                player.Play();
                                System.Diagnostics.Process.Start(nodes[i].fileLocation);
                                docNodeSelected = true;
                            }
                        }
                        if (!docNodeSelected) message = "Failed - Document Node Not Selected"; 
                    }
                    else
                    {
                        message = "Failed - Document Node Not Selected";
                    }
                    openingDocument = false;
                }
                else if (movingNode)
                {
                    nodeBuffer = new node();
                    nodeBuffer.id = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);
                    {
                        if (nodeBuffer.id != -1)
                        {
                            recordUndoState();
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                            path += "\\Tacitus\\lift.wav";
                            player = new System.Media.SoundPlayer(path);
                            player.Play();
                            message = "Moving Node - Select New Location for Node";
                            placingNode = true;
                        }
                        else
                        {
                            message = "Failed - Node Not Selected";
                        }
                        movingNode = false;
                    }
                }
                else if (placingNode)
                {
                    for (int i = 0; i < nodes.Count(); i++)
                    {
                        if (nodes[i].id == nodeBuffer.id)
                        {
                            recordUndoState();
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                            switch (nodes[i].type)
                            {
                                case "Document":
                                    path += "\\Tacitus\\thud.wav";
                                    break;
                                case "Observation":
                                    path += "\\Tacitus\\chime.wav";
                                    break;
                                case "Task":
                                    path += "\\Tacitus\\gear.wav";
                                    break;
                            }
                            player = new System.Media.SoundPlayer(path);
                            player.Play();
                            nodes[i].x = mouseEventArgs.X + translateX;
                            nodes[i].y = mouseEventArgs.Y + translateY;
                        }
                    }
                    message = "";
                    placingNode = false;
                }
                else if (transferring)
                {
                    nodeBuffer = new node();
                    nodeBuffer.id = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);
                    if (nodeBuffer.id != -1)
                    {
                        message = "Transferring Nodes - Select a Network of Nodes to Transfer";
                        transferring = false;
                        List<node> transferNodes = new List<node>();
                        for (int i = 0; i < nodes.Count(); i++)
                        {
                            //add node clicked by user to list of nodes to transfer
                            if (nodes[i].id == nodeBuffer.id) transferNodes.Add(nodes[i]);
                        }
                        for (int i = 0; i < transferNodes.Count(); i++) //cycle through each node in list of nodes to transfer
                        {
                            for (int j = 0; j < links.Count(); j++) //cycle through each link
                            {
                                if (links[j].parentNode == transferNodes[i].id) //check if node is listed as a parent node
                                {
                                    for (int k = 0; k < nodes.Count(); k++) //cycle through all nodes
                                    {
                                        if (nodes[k].id == links[j].childNode) //check if current "all nodes" is child node of current link
                                        {
                                            bool addNode = true;
                                            for (int l = 0; l < transferNodes.Count(); l++) //cycle through transfer nodes
                                            {
                                                if (transferNodes[l].id == nodes[k].id) addNode = false; //check if current "all nodes" is already in the list of transfer nodes
                                            }
                                            if (addNode)
                                            {
                                                transferNodes.Add(nodes[k]);
                                                addNode = false;
                                            }
                                        }
                                    }
                                }
                                if (links[j].childNode == transferNodes[i].id)
                                {
                                    for (int k = 0; k < nodes.Count(); k++)
                                    {
                                        if (nodes[k].id == links[j].parentNode)
                                        {
                                            bool addNode = true;
                                            for (int l = 0; l < transferNodes.Count(); l++)
                                            {
                                                if (transferNodes[l].id == nodes[k].id) addNode = false;
                                            }
                                            if (addNode)
                                            {
                                                transferNodes.Add(nodes[k]);
                                                addNode = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        DialogResult dialogResult = MessageBox.Show("Transfer " + transferNodes.Count() + " to " + transferProject.projName + "?", "Tacitus", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            for (int i = 0; i < transferNodes.Count(); i++)
                            {
                                transferNodes[i].projectId = transferProject.id;
                                updateNode(transferNodes[i]);
                            }                            
                            message = "Nodes Transferred";
                        }
                        else message = "Transfer Canceled";

                        drawMap(links, nodes);
       
                        
                    }
                    transferring = false;
                    nodes = importNodes();
                    links = importLinks();
                    drawMap(links, nodes); 

                }
                else if (editingNode)
                {
                    editingNode = false;
                    nodeBuffer = new node();
                    nodeBuffer.id = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);

                    if (nodeBuffer.id != -1)
                    {
                        for (int i = 0; i < nodes.Count; i++)
                        {
                            if (nodes[i].id == nodeBuffer.id) nodeBuffer = nodes[i];
                        }
                        EditNodeForm editNodeForm = new EditNodeForm(nodeBuffer, this.Top + windowOffset, this.Left + windowOffset);
                        editNodeForm.ShowDialog();
                        while (editNodeForm.Visible);
                        for (int i = 0; i < nodes.Count; i++)
                        {
                            if (nodes[i].id == Program.editedNode.id) nodes[i] = Program.editedNode;
                        }
                    }
                    else message = "Failed - Node Not Selected";
                    drawMap(links, nodes);

                }

                else
                {
                    int bufferNodeId = checkForNode(mouseEventArgs.X, mouseEventArgs.Y);
                    if (bufferNodeId != -1)
                    {
                       for (int i = 0; i < nodes.Count(); i++)
                       {
                           if (bufferNodeId == nodes[i].id)
                           {
                               message = nodes[i].name + '\n' + nodes[i].description + '\n';
                           }
                       }
                    }
                    else
                    {
                        for (int i = 0; i < frameRate; i++ )
                        {
                            translateX += (mouseEventArgs.X - mapPicBx.Width / 2)/frameRate;
                            translateY += (mouseEventArgs.Y - mapPicBx.Height/2)/frameRate;
                            drawMap(links, nodes);
                            
                        }
                        message = "";

                    }
                }
            }
            drawMap(links, nodes);
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            nodeTypeCbo.Items.Add("Document");
            nodeTypeCbo.Items.Add("Observation");
            nodeTypeCbo.Items.Add("Task");
            nodeTypeCbo.SelectedIndex = 2;

            listProjects();
            selectLastProjectSaved();

            nodes = importNodes();
            links = importLinks();
            projectPath = importProjectPath();
            translateX = 0;
            translateY = 0;
            drawMap(links, nodes);
            selectedProjectLbl.Text = Program.selectedProject.projName;

        }

        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            nodeBuffer = new node();
            nodeIdMax++;
            nodeBuffer.id = nodeIdMax;
            nodeBuffer.projectId = Int32.Parse(Program.selectedProject.id.ToString());
            nodeBuffer.type = nodeTypeCbo.Text.ToString();
            nodeBuffer.name = nameTxtBx.Text.ToString();
            nodeBuffer.description = descTxtBx.Text.ToString();
            nodeBuffer.fileLocation = pathTxtBx.Text.ToString();
            message = ("Place Node on Map");
            addingNode = true;
            drawMap(links, nodes);
            //mapPicBx.Image = btm;
        }

        private void addLinkBtn_Click(object sender, EventArgs e)
        {
            message = "Adding Link - Select Parent Node";
            addingLinkParent = true;
            linkBuffer = new link();
            drawMap(links, nodes);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveChanges();
            drawMap(links, nodes);
        }

        private void deleteNodeBtn_Click(object sender, EventArgs e)
        {
            message = "Select Node to Delete";
            deletingNode = true;
            drawMap(links, nodes);

        }

        private void deleteLinkBtn_Click(object sender, EventArgs e)
        {
            message = "Deleting Link - Select Parent Node";
            deletingLinkParent = true;
            drawMap(links, nodes);

        }

        private void homeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (mapPicBx.Focused)
            {
                switch (e.KeyCode)
                {
                    case Keys.D:
                        for (int i = 0; i < frameRate; i ++ )
                        {
                            translateX += (mapPicBx.Width / 4) / frameRate;
                            drawMap(links, nodes);
                        }
                        break;
                    case Keys.A:
                        for (int i = 0; i < frameRate; i++)
                        {
                            translateX -= (mapPicBx.Width / 4) / frameRate;
                            drawMap(links, nodes);

                        }
                        break;
                    case Keys.W:
                        for (int i = 0; i < frameRate; i++)
                        {
                            translateY -= (mapPicBx.Height / 4) / frameRate;
                            drawMap(links, nodes);

                        }
                        break;
                    case Keys.S:
                        for (int i = 0; i < frameRate; i++)
                        {
                            translateY += (mapPicBx.Height / 4) / frameRate;
                            drawMap(links, nodes);
                        }
                        break;
                }
            }

        }

        private void openDocBtn_Click(object sender, EventArgs e)
        {
            openingDocument = true;
            message = "Opening Document - Select Document Node";
            drawMap(links, nodes);
            //mapPicBx.Image = btm;
        }

        private void moveNodeBtn_Click(object sender, EventArgs e)
        {
            movingNode = true;
            message = "Moving Node - Select Node to Move";
            drawMap(links, nodes);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Save Changes to " + Program.selectedProject.projName + "?", "Tacitus", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                saveChanges();
                message = "Changes Saved";
            }
            newProjectForm newProject = new newProjectForm(this.Top + windowOffset, this.Left + windowOffset);
            newProject.ShowDialog();
            while (newProject.Visible)
            {

            }
            listProjects();
            for (int i = 0; i < projects.Count(); i++)
            {
                if (projects[i].id == Program.selectedProject.id)
                {
                    Program.selectedProject = projects[i];
                    nodes = importNodes();
                    links = importLinks();
                    projectPath = importProjectPath();
                    translateX = 0;
                    translateY = 0;
                    drawMap(links, nodes);
                    selectedProjectLbl.Text = Program.selectedProject.projName;
                }
            }
        }

        private void replayBtn_Click(object sender, EventArgs e)
        {
            node nextNode = new node();
            link nextLink = new link();
            List<node> tempNodes = new List<node>();
            List<link> tempLinks = new List<link>();
            int delay;
            int pause = 700;
            bool moreNodes = true;
            bool moreLinks = true;
            bool loop = true;
            bool writeNode = false;
            int nodeIterator = 0;
            int linkIterator = 0;
            sortNodesLinks();

            delay = (int) ((nodes.Count + links.Count) * 700) % 5600;
            player2 = new System.Media.SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Tacitus\\memoryMusic.wav");
            player2.PlayLooping();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path += "\\Tacitus\\lift.wav";
            player = new System.Media.SoundPlayer(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Tacitus\\memoryMusicEnd.wav");
            while (loop)
            {
                System.Threading.Thread.Sleep(pause); 
                //player.Play();
                if (nodes.Count() == nodeIterator)
                {
                    moreNodes = false;              
                }
                if (links.Count() == linkIterator)
                {
                    moreLinks = false;
                }
                
                if (!moreNodes && !moreLinks) loop = false;
                if (loop)
                {
                    if (moreNodes) nextNode = nodes[nodeIterator];
                    if (moreLinks) nextLink = links[linkIterator];
                    if (nextNode.timeStamp < nextLink.timeStamp) writeNode = true;
                    if (!moreLinks) writeNode = true;
                    if (!moreNodes) writeNode = false;
                    if (writeNode)
                    {
                        int relativeX = nextNode.x - translateX;
                        int relativeY = nextNode.y - translateY;
                        for (int i = 0; i < frameRate; i++ )
                        {
                            translateX += (relativeX - mapPicBx.Width / 2 ) / frameRate;
                            translateY += (relativeY - mapPicBx.Height / 2) / frameRate;
                            drawMap(tempLinks, tempNodes);

                        }
                        tempNodes.Add(nextNode);
                        writeNode = false;
                        drawMap(tempLinks, tempNodes);
                        nodeIterator++;
                    }
                    else if (moreLinks)
                    {
                        tempLinks.Add(nextLink);
                        drawMap(tempLinks, tempNodes);
                        linkIterator++;
                    }

                }

            }
            System.Threading.Thread.Sleep(delay);     
            player2.Stop();
            player.Play();
        }

        private void openDialogBtn_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = projectPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathTxtBx.Text = ofd.FileName;
            }
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            taskManagerForm taskManager = new taskManagerForm(this.Top + windowOffset, this.Left + windowOffset);
            //this.Hide();
            taskManager.ShowDialog();
            while (taskManager.Visible)
            {

            }
            listProjects();
            nodes = importNodes();
            links = importLinks();
            projectPath = importProjectPath();
            translateX = Program.selectedTask.x - mapPicBx.Width / 2;
            translateY = Program.selectedTask.y - mapPicBx.Height / 2;
            drawMap(links, nodes);
            //mapPicBx.Image = btm;
            selectedProjectLbl.Text = Program.selectedProject.projName;
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveChanges();
            drawMap(links, nodes);
            message = "";
            listProjects();
            Program.selectedProject = openProjectDialog.ShowDialog("Select a Project", "Open Project", projects, this.Top + windowOffset, this.Left + windowOffset);
            nodes = importNodes();
            links = importLinks();
            projectPath = importProjectPath();
            translateX = 0;
            translateY = 0;
            drawMap(links, nodes);
            selectedProjectLbl.Text = Program.selectedProject.projName;
        }

        private void nodeTypeCbo_TextChanged(object sender, EventArgs e)
        {
            if (nodeTypeCbo.Text == "Document")
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

        private void transferBtn_Click(object sender, EventArgs e)
        {
            listProjects();
            transferProject = openProjectDialog.ShowDialog("Select a Project", "Node Transfer", projects, this.Top + windowOffset, this.Left + windowOffset);
            transferring = true;
        }

        private void homeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveChanges();
        }

        private void deleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            project projToDelete = openProjectDialog.ShowDialog("Select a Project", "Open Project", archivedProjects, this.Top + windowOffset, this.Left + windowOffset);
            if (projToDelete.id != Program.selectedProject.id)
            {
                DialogResult dialogResult = MessageBox.Show("Delete Enitre " + projToDelete.projName + " Project?", "Tacitus", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deleteProject(projToDelete);
                    message = projToDelete.projName + " has been deleted";
                }
            }
            else message = projToDelete.projName + " is still open. Canceled Project Delete.";
            drawMap(links,nodes);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoStatesList.Count > 0)
            {
                nodes = undoStatesList[0].nodes;
                links = undoStatesList[0].links;
                for (int i = 0; i < undoStatesList.Count - 1; i++) undoStatesList[i] = undoStatesList[i + 1];
                drawMap(links, nodes);
            }
        }

        private void homeForm_ResizeEnd(object sender, EventArgs e)
        {
            drawMap(links, nodes);
        }

        private void mapPicBx_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState != System.Windows.Forms.FormWindowState.Minimized) drawMap(links, nodes);
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listArchivedProjects();
            Program.editedProject = openProjectDialog.ShowDialog("Select a Project", "Edit a Project", archivedProjects, this.Top + windowOffset, this.Left + windowOffset);
            EditProjectForm editProjFm = new EditProjectForm(this.Top + windowOffset, this.Left + windowOffset);
            editProjFm.Show();
        }

        private void editNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editingNode = true;
            message = "Select Node to Edit";
            drawMap(links, nodes);
        }

        private void selectedProjectLbl_Click(object sender, EventArgs e)
        {
            message = Program.selectedProject.projName + " - " + Program.selectedProject.projDesc;
            drawMap(links, nodes);
        }

    }
}
