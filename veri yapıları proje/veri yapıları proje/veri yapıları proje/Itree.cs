using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapıları_proje
{
    public interface Itree
    {
        void insert(treeNode node);
        void balanceHeap(treeNode node);
        void adjustPos();
        void traverseHeap();
    }
}
