using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapıları_proje
{
    public class stack : Istack
    {
        public Node head;
        int count = 0;

        public stack()
        {
            this.head = null;
        }

        public bool isEmpty()
        {
            return count == 0 ? true : false;
        }

        public object peek()
        {
            if (isEmpty())
            {
                return 0;
            }
            return head.data;
        }

        public object pop()
        {
            Node temp = this.head;
            if (isEmpty())
            {
                return 0;
            }
            else
            {
                count--;
                string data = head.data;
                head = head.next;
                return data;
            }
        }

        public void push(string value)
        {
            Node temp = this.head;
            if (isEmpty())
            {
                head = value;
                
            }
            else
            {
                head = new Node(value)
                {
                    next = temp
                };
            }
            count++;
        }
    }
}





