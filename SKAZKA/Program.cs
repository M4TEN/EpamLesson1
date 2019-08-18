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
                animal = animal.Substring(0, 1).ToUpper() + animal.Substring(1, animal.Length - 1).ToLower()+"- ";
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
            Mouse mice = new Mouse();
            Frog anuran = new Frog();
            Rabbit bunny = new Rabbit();
            Fox tod = new Fox();
            Wolf predator = new Wolf();
            Boar aper = new Boar();
            Bear shrek = new Bear();

            //add animals to a story
            _Animals.Add(mice.Display());
            _Animals.Add(anuran.Display());
            _Animals.Add(bunny.Display());
            _Animals.Add(tod.Display());
            _Animals.Add(predator.Display());
            _Animals.Add(aper.Display());
            _Animals.Add(shrek.Display());

            int _number = rnd.Next(6) + 1;
            int x = 0;

            //start of the story
            OutIn.Title("Р У К А В И Ч К А\n");
            OutIn.Writer("Шёл дед лесом, а за ним бежала собачка. Шёл дед, шёл, да и обронил рукавичку.");

            StartOfStory(x++, _Animals[lst[x]] + " ", OutIn);
            while (_number != 0)
            {
                OutIn.Reader();
                //first sentence of a phrase
                OutIn.MWriter("\n" + OutIn.Travel(5) + _Animals[lst[x]] + OutIn.Travel(0) + OutIn.Travel(8));

                //listing animals in Rukavichka
                for (int i = 0; i < x; i++)
                {
                    OutIn.MWriter(_Animals[lst[i]] + ", ");
                }

                //who are you
                OutIn.Writer(OutIn.Travel(1));

                //answer from a traveler
                OutIn.Writer(OutIn.Travel(9) + _Animals[lst[x]] + ". " + OutIn.Travel(2) + OutIn.Travel(3));
                //counting animals
                OutIn.MWriter(OutIn.Travel(10) + OutIn.Count(x - 1));
                x++;
                _number--;
            }
            //ending of the story
            OutIn.Ending(x);
            OutIn.Reader();

        }
    }
}
