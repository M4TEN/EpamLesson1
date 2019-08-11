using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                "двое.",
                "трое.",
                "четверо сидит.",
                "пятеро. И так им тесно, что не повернуться!",
                "шестеро",
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

        public string Reader()
        {
            return Console.ReadLine();
        }

        public void Ending(int count)
        {
            try
            {
                Random rnd = new Random();
                List<string> EndOfStoryLst = new List<string>()
                {
                    "\nА тем временем дед хватился - нету рукавички.\n" +
                "Он тогда вернулся искать ее. А собачка вперед побежала. Бежала, бежала, смотрит - лежит рукавичка и пошевеливается.\n" +
                "Собачка тогда:\n-Гав-гав-гав!\n" +
                "Звери испугались, из рукавички вырвались - да врассыпную по лесу. А дед пришел и забрал рукавичку.",

                    "\nА тут шла девочка-припевочка, глядит: большая рукавичка лежит, да шевелится.\n"+
                    "Думает: Хмм, вроде не живая а шевелится. \n" +
                    "Как позовет дедушку, ведь страшно!\n" +
                    "А дедушка с собачкой. Собачка тогда:\n-Гав-гав-гав!\n" +
                "Звери испугались, из рукавички вырвались - да врассыпную по лесу. А дед пришел и забрал рукавичку.",

                    "*Треск-треск*\nНе выдержала рукавичка! Порвалась!\nИ звери, услышав звук, как разбежались от страха" +
                    "\nДед пришел за рукавичкой, смотрит - а от неё одни кусочки остались. \nЧтож, теперь придётся новенькую плести"
                };

                int r = rnd.Next(EndOfStoryLst.Count-1)+1;
                Writer(EndOfStoryLst[r - 1]);
                switch (r)
                {
                    case 1:
                        throw new Exception("\n И чтоб делал дед без девочки-припевочки... \n-Спасибо тебе большое, внученька, за рукавичку.");
                        break;
                    case 2:
                        throw new Exception("\nНе теряйте, дети, рукавичку!");
                }
            }
            catch(Exception e)
            {
                Writer(e.Message);
            }
        }
    }
}
