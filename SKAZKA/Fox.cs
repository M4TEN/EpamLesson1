using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class Fox:Animals
    {
        public Fox(string Name, string NickName, string Gender) : base(Name, NickName, Gender)
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
