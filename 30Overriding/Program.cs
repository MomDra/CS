using System;

namespace _30Overriding
{
    class FightUnit
    {
        protected int AT = 10;

        public virtual int getAT()
        {
            Console.WriteLine("FightUnit의 함수");
            return AT;
        }
    }

    class Player : FightUnit
    {
        int ItemAt = 5;

        public override int getAT()
        {
            Console.WriteLine("Player의 함수");
            
            return AT + ItemAt;
        }
    }

    class Monster : FightUnit
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Monster monster = new Monster();

            FightUnit f1 = player;
            FightUnit f2 = monster;

            f1.getAT();
            f2.getAT();
        }
    }
}
