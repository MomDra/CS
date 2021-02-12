using System;

class Player
{
    public int ATT; // 전체 공개
    protected int HP; // 자식에게만 공개
    private int MP; // 클래스 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }
}

namespace UNITYST
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();

            newPlayer.Fight();
        }
    }
}
