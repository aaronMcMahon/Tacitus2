using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacitusCSharp
{
    public class node
    {
        public int id { get; set; }
        public int projectId { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string fileLocation { get; set; }
        public DateTime timeStamp { get; set; }
        public int rank { get; set; }

    }
}
