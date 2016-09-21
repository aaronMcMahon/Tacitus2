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
        public OleDbConnection con = new OleDbConnection();
        public BindingList<project> projects = new BindingList<project>();
        public BindingList<project> archivedProjects = new BindingList<project>();
        List<node> nodes = new List<node>();
        List<link> links = new List<link>();
        List<node> nodesLastSaved = new List<node>();
        List<link> linksLastSaved = new List<link>();
        Rectangle r;
        Pen p;
        SolidBrush b;
        int translateX, translateY;
        int nodeSize = 15;
        int labelOffset = 5;
        Font mapFont = new Font(SystemFonts.DefaultFont.FontFamily, 10, FontStyle.Regular);
        node nodeBuffer;
        bool addingNode = false;
        bool addingLinkParent = false;
        bool addingLinkChild = false;
        bool deletingNode = false;
        bool deletingLinkParent = false;
        bool deletingLinkChild = false;
        bool openingDocument = false;
        bool movingNode = false;
        bool placingNode = false;
        bool editingNode = false;
        link linkBuffer = new link();
        int nodeIdMax = 0;
        int linkIdMax = 0;
        string message = "";
        int offset = 125;
        int panFrame = 5;
        int frameRate = 20;
        System.Drawing.Drawing2D.AdjustableArrowCap bigArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(3, 10);
        DateTime localDate;
        OpenFileDialog ofd = new OpenFileDialog();
        string projectPath;
        project transferProject;
        bool transferring = false;
        int windowOffset = 10;
        List<undoState> undoStatesList = new List<undoState>(); 
        int undoStatesMax = 5;
        System.Media.SoundPlayer player;
        System.Media.SoundPlayer player2;
    }
}
