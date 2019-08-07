using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKAZKA
{
    class Every
    {
        public string Name;
        public string NickName;
        public string Gender;
        public Every(string _a, string _b, string _c)
        {
            Name = _a;
            NickName = _b;
            Gender = _c;
        }

        public string Display()
        {
            return (Name + '-' + NickName);
        }
        
    }
    //these classes are useless. Idk why in the task we need them
    class Mouse:Every
    {
        
        public Mouse(string Name, string NickName, string Gender) : base(Name, NickName, Gender)
        {

        }

        public string Move()
        {
            if (Gender == "female")
                return "ла";
            else
                return "л";
        }
    }

    class Frog:Every
    {
        public Frog(string Name, string NickName, string Gender) : base(Name, NickName, Gender)
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

    class Rabbit:Every
    {
        public Rabbit(string Name, string NickName, string Gender) : base(Name, NickName, Gender)
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

    class Fox:Every
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

    class Wolf:Every
    {
        public Wolf(string Name, string NickName, string Gender) : base(Name, NickName, Gender)
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

    class Boar:Every
    {
        public Boar(string Name, string NickName, string Gender) : base(Name, NickName, Gender)
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

    class Bear:Every
    {
        public Bear(string Name, string NickName, string Gender) : base(Name, NickName, Gender)
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

    class Program
    {
        public static string OneLine(string a, int b)
        {
            switch (b)
            {
                case 0:
                    return " и спрашивает: \n-Кто, кто в рукавичке живёт?\n";
                    break;
                case 1:
                    return "а ты кто?";
                    break;
                case 2:
                    return "Можно я зайду?";
                    break;
                case 3:
                    return "\n-Иди";
                    break;
                case 4:
                    return "И вот их уже " + a;
                    break;
                case 5:
                    return "Бежит " + a;
                    break;
                case 6:
                    return "";
                    break;
                default:
                    return "";
            }

        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> lst = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };
            List<string> how = new List<string>()
            {
                "двое.",
                "трое.",
                "четверо сидит.",
                "пятеро. И так им тесно, что не повернуться!",
                "шестеро",
                "семеро стало, да так тесно, что рукавичка того и гляди, разорвется."
            };
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
            Console.WriteLine("{0,50}", "Р У К А В И Ч К А\n");
            Console.WriteLine("Шёл дед лесом, а за ним бежала собачка. Шёл дед, шёл, да и обронил рукавичку.");
            int x = 1;
            Console.Write(OneLine(_Animals[lst[0]], 5));
            Console.WriteLine(" и говорит:\n-Тут я буду жить");

            while (_number!=0)
            {
                Console.Write("\n"+OneLine(_Animals[lst[x]], 5)+OneLine("",0)+"-А здесь ");
                for (int i=0;i<x;i++)
                {
                    Console.Write(_Animals[lst[i]]+", ");
                }
                Console.WriteLine(OneLine("", 1));
                Console.Write("-А я " + _Animals[lst[x]] + ". " + OneLine("", 2)+OneLine("",3));
                Console.WriteLine("\nИ вот их уже " + how[x-1]);
                x++;
                _number--;
            }
            Console.WriteLine("\nА тем временем дед хватился - нету рукавички.\n" +
                "Он тогда вернулся искать ее. А собачка вперед побежала. Бежала, бежала, смотрит - лежит рукавичка и пошевеливается.\n" +
                "Собачка тогда:\n-Гав-гав-гав!\n" +
                "Звери испугались, из рукавички вырвались - да врассыпную по лесу. А дед пришел и забрал рукавичку.");
            Console.ReadKey();
        }
    }
}
