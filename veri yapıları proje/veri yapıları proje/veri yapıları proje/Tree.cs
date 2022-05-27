using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapıları_proje
{
    public class Tree : Itree
    {
        public treeNode root;
        public treeNode insPos;

        public Tree(treeNode n)
        {
            root = n;
            insPos = n;
        }
        public void insert(treeNode n)
        {
            if (insPos.left == null)
            {
                insPos.left = n;
                n.parent = insPos;

                balanceHeap(n);

                return;
            }
            else
            {
                insPos.right = n;
                n.parent = insPos;
                adjustPos();
                balanceHeap(n);
            }

        }
        public void adjustPos()
        {
            treeNode n;
            Queue<treeNode> myQueue = new Queue<treeNode>();
            myQueue.Enqueue(root);

            while (myQueue.Count > 0)
            {
                n = myQueue.Dequeue();
                if (n.left != null)
                {
                    myQueue.Enqueue(n.left);
                }
                else
                {
                    insPos = n;
                    break;
                }
                if(n.right != null)
                {
                    myQueue.Enqueue(n.right);
                }
                else
                {
                    insPos = n;
                    break;
                }
            }

        }

        public void balanceHeap(treeNode n)
        {
            while (n.parent != null)
            {
                if(string.Compare(n.parent.data, n.data) == 1)
                {
                    string temp = n.data;
                    n.data = n.parent.data;
                    n.parent.data = temp;
                    n = n.parent;
                }
                else
                {
                    break;
                }
            }
        }
        public void traverseHeap()
        {
            treeNode n;
            Queue<treeNode> myQueue = new Queue<treeNode>();
            myQueue.Enqueue(root);
            while(myQueue.Count > 0)
            {
                n = myQueue.Dequeue();
                if (n.left != null)
                    myQueue.Enqueue(n.left);
                if (n.right != null)
                    myQueue.Enqueue(n.right);
            }

        }
    }
}
