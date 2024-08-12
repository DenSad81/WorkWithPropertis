using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp39_WorkWithCPropertis_
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero mario = new Hero('$', 1, 2);
            Renderer renderer = new Renderer();

            renderer.DrowHeroInPosition(mario);
        }
    }

    class Hero
    {
        public Hero(char sign, int positionX = 0, int positionY = 0)
        {
            SignHero = sign;
            PositionX = positionX;
            PositionY = positionY;
        }

        public char SignHero { get; }
        public int PositionX { get; }
        public int PositionY { get; }       
    }

    class Renderer
    {
        public void DrowHeroInPosition(Hero hero)
        {
            Console.SetCursorPosition(hero.PositionX, hero.PositionY);
            Console.Write(hero.SignHero);
        }
    }
}