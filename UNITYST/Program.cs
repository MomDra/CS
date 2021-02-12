using System;

class Player
{
    private int ATT; // 전체 공개
    private int HP; // 자식에게만 공개
    private int LV; // 클래스 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }

    public void setHp(int _HP)
    {
        HP = _HP;
    }

    public void LVUP()
    {
        ATT = 100;
        HP = 1000;
        LV++;
    }

    public int getLV()
    {
        return LV;
    }

    public void Damage1(int _Dmg)
    {
        HP -= _Dmg;
    }

    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP -= _Dmg;
        HP -= _SubDmg;
    }

    public int DamageToHPReturn(int _Dmg)
    {
        HP -= _Dmg;

        return HP;
    }

}

namespace UNITYST
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();

            newPlayer.LVUP();
            newPlayer.Damage1(10);
            newPlayer.Damage2(10, 20);

            Console.WriteLine(newPlayer.getLV());
            Console.WriteLine(newPlayer.DamageToHPReturn(20));
        }
    }
}
