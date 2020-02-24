using System;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxSum = 21;
            int SumYour = 0, SumComp = 0;
            int count;
            string reply;
            Random rnd = new Random(DateTime.Now.Millisecond);
            do
            {
                Console.WriteLine("Бросить кость для Вас?(y/n)");
                do
                {
                    reply = Console.ReadLine();
                } while (reply == "y" || reply == "Y" || reply == "n" || reply == "N");
                if (reply == "y" || reply == "Y")
                {
                    count = rnd.Next(1, 6);
                    Console.WriteLine("Выпало {0} очков", count);
                    SumYour = SumYour + count;
                    if (SumYour >= MaxSum)
                    {
                        break;
                    }
                    if (SumComp < 18)
                    {
                        count = rnd.Next(1, 5);
                        Console.WriteLine("Мне выпало очков {0}", count);
                        SumComp = SumComp + count;
                        Console.WriteLine("У меня всего {0} очков", count);
                        if (SumYour >= MaxSum)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Я пас.Будете продолжать? (y/n)");
                        do
                        {
                            reply = Console.ReadLine();
                        } while (reply == "y" || reply == "Y" || reply == "n" || reply == "N");
                        if (reply == "n" || reply == "N")
                        {
                            break;
                        }
                    }

                }
            } while (false);
            if (SumYour > MaxSum) Console.WriteLine("Вы проиграли!");
            else if (SumComp > MaxSum) Console.WriteLine("Я проиграл");
            else if (SumYour < SumComp) Console.WriteLine("Я выиграл!");
            else if (SumYour == SumComp) Console.WriteLine("Ничья!");
            Console.ReadLine();
        }
    }
}
