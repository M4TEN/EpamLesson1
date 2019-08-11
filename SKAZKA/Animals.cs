using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    abstract class Animals:IMoves
    {
        public string Name;
        public string NickName;
        public string Gender;

        public Animals(string _a, string _b, string _c)
        {
            Name = _a;
            NickName = _b;
            Gender = _c;
        }

        public string Display()
        {
            return (Name + '-' + NickName);
        }

        //public abstract string Travel(int number);

    }
}
