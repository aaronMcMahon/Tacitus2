using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TacitusCSharp
{
    static class Program
    {
        public static project selectedProject = new project();
        public static project editedProject = new project();
        public static node editedNode = new node();
        public static node selectedTask = new node();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new homeForm());

        }
    }
}
