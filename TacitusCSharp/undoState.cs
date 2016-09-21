using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacitusCSharp
{
    public class undoState
    {
        public List<node> nodes;
        public List<link> links;
        public void set(List<node> nodeValues, List<link> linkValues)
        {
            nodes = nodeValues;
            links = linkValues;
        }
    }
}
