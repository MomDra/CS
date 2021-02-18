using System;

namespace _26Property
{
    class Player
    {
        int HP;
        public int ProHP
        {
            get => HP;
            set => HP = value;
            
        }

        public Player(int h)
        {
            ProHP = h;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player= new Player(6);

            player.ProHP = 5;

            Console.WriteLine(player.ProHP);
        }
    }
}
