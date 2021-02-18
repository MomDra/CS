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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player= new Player();

            player.ProHP = 5;

            Console.WriteLine(player.ProHP);
        }
    }
}
