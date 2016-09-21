using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacitusCSharp
{
    class nodesLinks
    {
        private List<node> nodes;
        private List<link> links;

        public void addNode(node newNode)
        {
            nodes.Add(newNode);
        }
        public void addLink(link newLink)
        {
            links.Add(newLink);
        }
    }
}
