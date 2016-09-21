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
        void saveChanges()
        {
            int continueWithSave = 0; //0 - user has not chosen, 1 - user wants changes saved, 2 - user wants to discard changes

            bool deleteNodeBool = false;
            bool deleteLinkBool = false;
            bool addNodeBool = false;
            bool addLinkBool = false;
            nodesLastSaved = importNodes();
            linksLastSaved = importLinks();

            //check for updates
            for (int i = 0; i < nodes.Count(); i++)
            {
                for (int j = 0; j < nodesLastSaved.Count(); j++)
                {
                    if (nodes[i].id == nodesLastSaved[j].id)
                    {
                        if (nodes[i].x != nodesLastSaved[j].x || nodes[i].y != nodesLastSaved[j].y || nodes[i].name != nodesLastSaved[j].name ||
                            nodes[i].description != nodesLastSaved[j].description || nodes[i].fileLocation != nodesLastSaved[j].fileLocation)
                        {
                            if (continueWithSave == 0)
                            {
                                DialogResult dialogResult = MessageBox.Show("Save Changes to " + Program.selectedProject.projName + "?", "Tacitus", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    continueWithSave = 1;
                                    message = "Saving Changes...";
                                    drawMap(links, nodes);
                                }
                                else
                                {
                                    continueWithSave = 2;
                                    message = "Save Canceled";
                                }
                            }
                            if (continueWithSave == 1) updateNode(nodes[i]);
                        }
                    }
                }
            }

            //check for deletes
            for (int i = 0; i < linksLastSaved.Count(); i++)
            {
                deleteLinkBool = true;
                for (int j = 0; j < links.Count(); j++)
                {
                    if (linksLastSaved[i].id == links[j].id)
                    {
                        deleteLinkBool = false;
                    }
                }
                if (deleteLinkBool)
                {
                    if (continueWithSave == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Save Changes to " + Program.selectedProject.projName + "?", "Tacitus", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            continueWithSave = 1;
                            message = "Saving Changes...";
                            drawMap(links, nodes);
                        }
                        else
                        {
                            continueWithSave = 2;
                            message = "Save Canceled";
                        }
                    }
                    if (continueWithSave == 1) deleteLink(linksLastSaved[i].id);
                }
            }
            for (int i = 0; i < nodesLastSaved.Count(); i++)
            {
                deleteNodeBool = true;
                for (int j = 0; j < nodes.Count(); j++)
                {
                    if (nodesLastSaved[i].id == nodes[j].id)
                    {
                        deleteNodeBool = false;
                    }
                }
                if (deleteNodeBool)
                {
                    if (continueWithSave == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Save Changes to " + Program.selectedProject.projName + "?", "Tacitus", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            continueWithSave = 1;
                            message = "Saving Changes...";
                            drawMap(links, nodes);
                        }
                        else
                        {
                            continueWithSave = 2;
                            message = "Save Canceled";
                        }
                    }
                    if (continueWithSave == 1) deleteNode(nodesLastSaved[i].id);
                }
            }

            //check for additions
            for (int i = 0; i < nodes.Count(); i++)
            {
                addNodeBool = true;
                for (int j = 0; j < nodesLastSaved.Count(); j++)
                {
                    if (nodes[i].id == nodesLastSaved[j].id)
                    {
                        addNodeBool = false;
                    }
                }
                if (addNodeBool)
                {
                    if (continueWithSave == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Save Changes to " + Program.selectedProject.projName + "?", "Tacitus", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            continueWithSave = 1;
                            message = "Saving Changes...";
                            drawMap(links, nodes);
                        }
                        else
                        {
                            continueWithSave = 2;
                            message = "Save Canceled";
                        }
                    } 
                    if (continueWithSave == 1) addNode(nodes[i]);
                }
            }
            for (int i = 0; i < links.Count(); i++)
            {
                addLinkBool = true;
                for (int j = 0; j < linksLastSaved.Count(); j++)
                {
                    if (links[i].id == linksLastSaved[j].id)
                    {
                        addLinkBool = false;
                    }
                }
                if (addLinkBool)
                {
                    if (continueWithSave == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Save Changes to " + Program.selectedProject.projName + "?", "Tacitus", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            continueWithSave = 1;
                            message = "Saving Changes...";
                            drawMap(links, nodes);
                        }
                        else
                        {
                            continueWithSave = 2;
                            message = "Save Canceled";
                        }
                    }
                    if (continueWithSave == 1) addLink(links[i]);
                }
            }
            if (continueWithSave == 1) message = "Changes Saved";
        }
    }
}
