using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacitusCSharp
{
    public class project
    {
        public int id {get; set;}
        public string projName {get; set;}
        public string projDesc { get; set; }
        public string projPath { get; set; }
        public string timeStamp { get; set; }
        public bool archived { get; set; }

        public int getId()
        {
            return id;
        }
    }
}
