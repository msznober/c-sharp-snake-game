using System;

namespace c_sharp_snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wyłączenie widoczności kursora
            Console.CursorVisible = false;

            bool exit = false;

            //Ilość klatek na sekundę
            double framesPerSecond = 1000 / 5.0;

            //Sprawdzenie obecnej daty i czasu
            DateTime lastDate = DateTime.Now;

            //Wydrukowanie pokarmu w konsoli
            Food food = new Food();

            //Wąż
            Snake snake = new Snake();

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
                            snake.Directions = Directions.Left;
                            break;

                        case ConsoleKey.RightArrow:
                            snake.Directions = Directions.Right;
                            break;

                        case ConsoleKey.UpArrow:
                            snake.Directions = Directions.Up;
                            break;

                        case ConsoleKey.DownArrow:
                            snake.Directions = Directions.Down;
                            break;
                    }

                }

                if((DateTime.Now - lastDate).TotalMilliseconds >= framesPerSecond)
                {
                    lastDate = DateTime.Now;

                    //akcja gry
                    snake.Move();

                    if (food.CurrentMeal.X == snake.HeadPosition.X && food.CurrentMeal.Y == snake.HeadPosition.Y)
                    {
                        snake.EatFood();
                        food = new Food();
                        framesPerSecond /= 1.2;
                    }

                    //Przerwanie gry
                    if (snake.gameOver)
                    {
                        Console.Clear();
                        Console.WriteLine($"Przegrałeś. Długość twojego węża to: {snake.Length} ");
                        exit = true;
                        Console.ReadLine();
                    }
                }

            }
        }
    }
}
