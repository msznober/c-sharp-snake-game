using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_snake_game
{
    public class Food
    {
        public Food()
        {
            Random foodPosition = new Random();
            var x = foodPosition.Next(1, 20);
            var y = foodPosition.Next(1, 20);
            CurrentMeal = new gridReference(x, y);
            Draw();
        }

        public gridReference CurrentMeal { get; set; }

        void Draw()
        {
            Console.SetCursorPosition(CurrentMeal.X, CurrentMeal.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("@");
        }
    }
}
