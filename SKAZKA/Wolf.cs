using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class Wolf:Animals
    {
        public Wolf(string Name= "волчок", string NickName = "серый бочок", string Gender= "male") : base(Name, NickName, Gender)
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
