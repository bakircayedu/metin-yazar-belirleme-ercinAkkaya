using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapıları_proje
{
    public class LinkedList
    {
        public string anahtar;
        public object value;
        public LinkedList next;
        public LinkedList(string anahtar, object value)
        {
            this.anahtar = anahtar;
            this.value = value;
            this.next = null;
        }
    }
}
