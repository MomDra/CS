using System;

class Player
{
    private int ATT;
    private int HP;
    private int LV;

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
            Player newPlayer = new Player();
            /*
            newPlayer.LVUP();
            newPlayer.Damage1(10);
            newPlayer.Damage2(10, 20);

            Console.WriteLine(newPlayer.getLV());
            Console.WriteLine(newPlayer.DamageToHPReturn(20));*/

            int value = 100;
            
            value = newPlayer.Test(value); // 값형의 처리
            Console.WriteLine(value);
        }
    }
}
