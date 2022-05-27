using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapıları_proje
{
    public class Node
    {
        public Node next;
        public string data;
        public Node(string data)
        {
            this.data = data;
        }

        public static implicit operator Node(string v)
        {
            throw new NotImplementedException();
        }
    }
}
