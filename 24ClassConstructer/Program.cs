using System;

namespace _24ClassConstructer
{
    class FightUnit
    {
        protected int AT;

        public FightUnit()
        {
            Console.WriteLine("55");
        }
    }

    class Player : FightUnit
    {


        public Player()
        {
            AT = 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player();
        }
    }
}
