using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class Program
    {

        public static void StartOfStory(int number, string animal, Print outin)
        {
            if (number == 0)
            {
                outin.MWriter(animal);
                outin.MWriter(outin.Travel(5));
                outin.Writer(outin.Travel(6));
                outin.MWriter(outin.Travel(7));
            }
        }

        static void Main(string[] args)
        {
            Print OutIn = new Print();
            Random rnd = new Random();
            List<int> lst = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
            
            for (int i = 0; i < lst.Count; i++)
            {
                int tmp = lst[i];
                lst.RemoveAt(i);
                lst.Insert(rnd.Next(lst.Count), tmp);
            }

            List<string> _Animals = new List<string>();
            Mouse mice = new Mouse("мышка","поскребушка","female");
            Frog anuran = new Frog("лягушка", "попрыгушка", "female");
            Rabbit bunny = new Rabbit("зайчик", "побегайчик", "male");
            Fox tod = new Fox("лисица", "сестричка", "female");
            Wolf predator = new Wolf("волчок", "серый бочок", "male");
            Boar aper = new Boar("кабан", "клыкан", "male");
            Bear shrek = new Bear("медведюшка", "батюшка", "male");

            _Animals.Add(mice.Display());
            _Animals.Add(anuran.Display());
            _Animals.Add(bunny.Display());
            _Animals.Add(tod.Display());
            _Animals.Add(predator.Display());
            _Animals.Add(aper.Display());
            _Animals.Add(shrek.Display());

            int _number=rnd.Next(6)+1;
            OutIn.Title("Р У К А В И Ч К А\n");
            OutIn.Writer("Шёл дед лесом, а за ним бежала собачка. Шёл дед, шёл, да и обронил рукавичку.");
            int x = 0;

            StartOfStory(x++, _Animals[0] + " ", OutIn);
            while (_number!=0)
            {
                OutIn.Reader();

                OutIn.MWriter("\n" + OutIn.Travel(5)+ _Animals[lst[x]] + OutIn.Travel(0) + OutIn.Travel(8));

                for (int i=0;i<x;i++)
                {
                    OutIn.MWriter(_Animals[lst[i]]+", ");
                }
                OutIn.Writer(OutIn.Travel(1));

                OutIn.Writer(OutIn.Travel(9) + _Animals[lst[x]] + ". " + OutIn.Travel(2)+ OutIn.Travel(3));
                OutIn.MWriter(OutIn.Travel(10) + OutIn.Count(x-1));
                x++;
                _number--;
            }
            
            OutIn.Ending(_number);
            OutIn.Reader();
            OutIn.Title("Нажмите E N T E R");

        }
    }
}
