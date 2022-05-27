using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapıları_proje
{
    public interface IHashMap
    {
        object ara(string anahtar);
        void add(string anahtar, object value);
        int hashValue(string anahtar);
    }
}
