using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapıları_proje
{
    public class HashMap : IHashMap
    {
        public LinkedList[] table;
        public int size;
        public HashMap(int size)
        {
            this.size = size;
            this.table = new LinkedList[size];
            for ( int i = 0; i < size; i++)
            {
                table[i] = null;
            }
        }

        public void add(string anahtar, object value)
        {
            int hash = hashValue(anahtar) % size;
            if (table[hash] != null)
            {
                LinkedList node = table[hash];
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = LinkedList(anahtar, value);
            }
            else
            {
                table[hash] = new LinkedList(anahtar, value);
            }
        }

        private LinkedList LinkedList(string anahtar, object value)
        {
            throw new NotImplementedException();
        }

        public object ara(string anahtar)
        {
            int hash = hashValue(anahtar) % size;
            if (table[hash] != null)
            {
                LinkedList node = table[hash];
                while (node.next != null)
                {
                    if (node.anahtar == anahtar)
                    {
                        break;
                    }
                    node = node.next;
                }
                return node.value;
            }
            else
            {
                return null;
            }
        }

        public int hashValue(string anahtar)
        {
            int hashValue = 0;
            for (int i = 0; i < anahtar.Length; i++)
            {
                hashValue += anahtar[i];

            }
            return hashValue;
        }
    }
}
