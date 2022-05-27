using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapıları_proje
{
    public interface Istack
    {
        bool isEmpty();
        void push(string value);
        object pop();
        object peek();
    }
}
