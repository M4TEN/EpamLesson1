using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class Fox:Animals
    {
        public Fox(string Name= "лисица", string NickName= "сестричка", string Gender= "female") : base(Name, NickName, Gender)
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
