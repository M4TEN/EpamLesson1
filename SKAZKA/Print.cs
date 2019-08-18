using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SKAZKA
{
    class Print:IPrint
    {

        public List<string> lst = new List<string>()
        {
            " и спрашивает: \n-Кто, кто в рукавичке живёт?\n",
            "а ты кто?",
            "Можно я зайду?",
            "\n-Иди",
            "И вот их уже ",
            "Бежит ",
            "и говорит:",
            "-Тут я буду жить",
            "-А здесь ",
            "-А я ",
            "И вот их уже "
        };

        List<string> how = new List<string>()
        {
                "двое. Рукавичка просторна, казалось бы.",
                "трое. Довольно тесновато зверюшкам.",
                "четверо сидит да песенки поют.",
                "пятеро. И так им тесно, что не повернуться!",
                "шестеро... Ого!!!",
                "семеро стало, да так тесно, что рукавичка того и гляди, разорвется."
        };

        public string Count(int number)
        {
            return how[number];
        }

        public string Travel(int number)
        {
            return lst[number];
        }

        public void Writer(string s)
        {
            Console.WriteLine(s);
        }

        public void MWriter(string s)
        {
            Console.Write(s);
        }

        public void Title (string s)
        {
            Console.WriteLine("{0,50}", s);
        }

        public virtual void MTitle(string s)
        {
            Console.WriteLine("{0,25}", s);
        }

        public string Reader()
        {
            return Console.ReadLine();
        }
        //for AnonMethods
        delegate void MessageHandler(string message);
        delegate void HowMuchAnimals();
        //for Events
        class CountingOfAnimals
        {
            public delegate void StoryEventHandler(string message);
            public event StoryEventHandler Withdrawn;

            int _count;

            public CountingOfAnimals(int count)
            {
                _count = count;
            }

            public void Withdraw()
            {
                if (_count > 5)
                {
                    Withdrawn($" - Довольно таки большое количество!");
                }
                else if (_count > 3)
                {
                    Withdrawn($" - Довольно средне...");
                }
                else
                {
                    Withdrawn($" - Маловато будет!");
                }
            }
        }

        //Ending for the Story
        public void Ending(int count)
        {
            int _howtoend = 0;
            MyObj<string> hehe = new MyObj<string>("English");
           //Exception
            try
            {
                Random rnd = new Random();
                List<string> EndOfStoryLst = new List<string>()
                {
                    "\n\nА тем временем дед хватился - нету рукавички.\n" +
                "Он тогда вернулся искать ее. А собачка вперед побежала. " +
                "Бежала, бежала, смотрит - лежит рукавичка и пошевеливается.\n" +
                "Собачка тогда:\n-Гав-гав-гав!\n" +
                "Звери испугались, из рукавички вырвались - да врассыпную по лесу. " +
                "А дед пришел и забрал рукавичку.",

                    "\n\nА тут шла девочка-припевочка, глядит:" +
                    " большая рукавичка лежит, да шевелится.\n"+
                    "Думает: Хмм, вроде не живая а шевелится. \n" +
                    "Как позовет дедушку, ведь страшно!\n" +
                    "А дедушка с собачкой. Собачка тогда:\n-Гав-гав-гав!\n" +
                "Звери испугались, из рукавички вырвались - " +
                "да врассыпную по лесу. А дед пришел и забрал рукавичку.",

                    "\n\n*Треск-треск*\nНе выдержала рукавичка! Порвалась!" +
                    "\nИ звери, услышав звук, как разбежались от страха" +
                    "\nДед пришел за рукавичкой, смотрит - а от неё " +
                    "одни кусочки остались. \nЧтож, теперь придётся новенькую плести",

                    "But grandpa didnt find his vareshka and forgot this. Uh.. Sad End("
                };
                //Anon Method
                MessageHandler handler = delegate (string mes)
                {
                    MWriter(mes);
                };

                handler("\n\nКульминация:");

                int r = rnd.Next(EndOfStoryLst.Count);
                Writer(EndOfStoryLst[r]);

                if (r == 3)
                {
                    _howtoend = 3;
                }

                switch (r)
                {
                    case 1:
                        throw new Exception("\n И чтоб делал дед без девочки-припевочки... " +
                            "\n-Спасибо тебе большое, внученька, за рукавичку.");
                    case 2:
                        throw new Exception("\nНе теряйте, дети, рукавичку!");
                    case 3:
                        throw new Exception("\nBut dont worry, Be happy!");
                    default:
                        throw new Exception("\nВот и сказочки конец, а кто слушал - молодец!");
                }
                
            }
            catch(Exception e)
            {
                //Event
                CountingOfAnimals _coa = new CountingOfAnimals(count);
                _coa.Withdrawn += Writer;
                //Lyambda
                HowMuchAnimals howmuchanimals = () => Writer(e.Message);
                howmuchanimals();

                MWriter($"\nБыло задействовано животных: {count}");
                //Event
                _coa.Withdraw();
                if (_howtoend == 3)
                {
                    Writer(hehe.GetEnd(""));
                }
                else
                    Writer(hehe.GetEnd("RU"));
            }
        }
    }
}
