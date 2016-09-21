using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacitusCSharp
{
    public class link
    {
        public int id { get; set; }
        public int parentNode { get; set; }
        public int childNode { get; set; }
        public DateTime timeStamp { get; set; }
    }
}
