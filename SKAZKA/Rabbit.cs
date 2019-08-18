using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class Rabbit:Animals
    {
        public Rabbit(string Name= "зайчик", string NickName= "побегайчик", string Gender= "male") : base(Name, NickName, Gender)
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
