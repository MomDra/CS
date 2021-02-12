using System;

class Player
{
    public static int playercount = 0;

    

    public int Test(int num)
    {
        num = 1000;
        return num;
    }

    

}

namespace UNITYST
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer1 = new Player();
            Player.playercount += 1;
            Player newPlayer2 = new Player();
            Player.playercount += 1;
            Player newPlayer3 = new Player();
            Player.playercount += 1;

            Console.WriteLine(Player.playercount);

            // newPlayer1.playercount 객체를 이용해 static 멤버 접근 불가
        }
    }
}
