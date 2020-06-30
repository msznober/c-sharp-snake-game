using System;

namespace c_sharp_snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            //Ilość klatek na sekundę
            double framesPerSecond = 1000 / 5.0;

            //Sprawdzenie obecnej daty i czasu
            DateTime lastDate = DateTime.Now;

            //Pętla gry, działnie węża
            while(!exit)
            {
                if(Console.KeyAvailable)
                { 

                    ConsoleKeyInfo button = Console.ReadKey();

                    switch (button.Key)
                    {
                        case ConsoleKey.Escape:
                            exit = true;
                            break;

                        case ConsoleKey.LeftArrow:
                            //x
                            break;

                        case ConsoleKey.RightArrow:
                            //x
                            break;

                        case ConsoleKey.UpArrow:
                            //x
                            break;

                        case ConsoleKey.DownArrow:
                            //x
                            break;
                    }

                }

                if((DateTime.Now - lastDate).TotalMilliseconds >= framesPerSecond)
                {
                    //akcja gry
                    lastDate = DateTime.Now;
                }

            }
        }
    }
}
