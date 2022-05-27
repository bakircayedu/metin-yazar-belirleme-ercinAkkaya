using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapıları_proje
{
    public class treeNode
    {
        public treeNode left;
        public treeNode right;
        public treeNode parent;

        public string data;

        public treeNode(string data)
        {
            this.data = data;
        }
    }
}
