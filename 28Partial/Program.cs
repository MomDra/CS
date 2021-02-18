using System;

namespace _28Partial
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();

            player.Damage(50);

            Console.WriteLine(player.HP);
        }
    }
}
