using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class Mouse:Animals
    {
        public Mouse(string Name = "мышка", string NickName = "поскребушка", string Gender = "female") : base(Name, NickName, Gender)
        {
            //Name = "мышка";
            //NickName = "поскребушка";
            //Gender = "female";
        }

        public string Move()
        {
            if (Gender == "female")
                return "ла";
            else
                return "л";
        }
    }
}
