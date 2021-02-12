using System;

class Player
{
    private int ATT;
    public int HP = 100;
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

class Monster
{
    public int ATT = 10;

    public void Attack(Player _player)
    {
        _player.HP -= ATT;
    }
}

namespace UNITYST
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            Monster newMonster = new Monster();

            newMonster.Attack(newPlayer);
            Console.WriteLine(newPlayer.HP);
        }
    }
}
