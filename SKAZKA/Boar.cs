using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class Boar:Animals
    {
        public Boar(string Name= "кабан", string NickName= "клыкан", string Gender= "male") : base(Name, NickName, Gender)
        {
            
        }

        public string Move()
        {
            if (Gender == "female")
                return "влезла";
            else
                return "влез";
        }
    }
}
