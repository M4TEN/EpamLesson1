using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    interface IPrint
    {
        void Writer(string s);
        void MWriter(string s);
        void Title(string s);
        void Ending(int count);
        string Reader();
    }
}
