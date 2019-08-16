using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class Frog:Animals
    {
        public Frog(string Name= "лягушка", string NickName= "попрыгушка", string Gender= "female") : base(Name, NickName, Gender)
        {
            

        }

        public string Move()
        {
            if (Gender == "female")
                return "ла";
            else
                return "";
        }
    }
}
