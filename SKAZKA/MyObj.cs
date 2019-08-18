using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class MyObj<T>
    {
        T obj;
        public MyObj(T obj)
        {
            this.obj = obj;
        }


        public string GetEnd(string temp)
        {
            if ((typeof(T).ToString() == "System.String")&&(temp!=""))
            {
                return "Спасибо за то, что прочитали сказку!";
            }
            else
                return "Thank you for reading";
        }
    }
}
