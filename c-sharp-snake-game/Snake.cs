using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c_sharp_snake_game
{
    public class Snake : ISnake
    {
        public int Length { get; set; } = 3;
        public Directions Directions { get; set; } = Directions.Right;

        public gridReference HeadPosition { get; set; } = new gridReference();

        List<gridReference> snakeTail { get; set; } = new List<gridReference>();

        //Zakończenie gry - wyjście poza planszę
        bool outOfRange = false;

        //Zakończenie gry - przegrana
        bool gameOver
        {
            //Czy któraś współrzędna ogona pokrywa się z głową - zderzenie
            get
            {
                return (snakeTail.Where(g => g.X == HeadPosition.X && g.Y == HeadPosition.Y).ToList().Count > 1);
             }
        }
        public void EatFood()
        {
            Length++;
        }

        public void Move()
        {
           switch(Directions)
            {
                case Directions.Left:
                    HeadPosition.X--;
                    break;
                
                case Directions.Right:
                    HeadPosition.X++;
                    break;
                
                case Directions.Up:
                    HeadPosition.Y--;
                    break;
                
                case Directions.Down:
                    HeadPosition.Y++;
                    break;
            }
            try
            {
                Console.SetCursorPosition(HeadPosition.X, HeadPosition.Y);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("@");
            }
            catch (ArgumentOutOfRangeException)
            {
                outOfRange = true;
            }
        }
    }

    public enum Directions { Left, Right, Up, Down}
}
