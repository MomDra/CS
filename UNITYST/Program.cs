using System;

class Player
{
    private int HP = 100;
    private int AT = 10;

    public static void PVP(Player player1, Player player2)
    {
        // 자기 자신의 레퍼런스는 자신의 내부에서 모두 public인 상태
        player1.HP -= player2.AT;
        player2.HP -= player1.AT;
    }

    public void Damage(int _Dmg)
    {
        HP -= _Dmg;
    }
}

namespace UNITYST
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();

            // 정적 맴버 함수는 클래스명.함수명()으로 호출한다.
            Player.PVP(player1, player2);
        }
    }
}
