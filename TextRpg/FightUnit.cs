using System;
using System.Collections.Generic;
using System.Text;

class FightUnit
{
    protected string Name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int MAXHP = 100;

    public void StatusRender()
    {
        Console.WriteLine("-----------------");
        Console.WriteLine(Name);
        Console.WriteLine("공격력: {0}", AT);
        Console.WriteLine("체력: {0}/{1}", HP, MAXHP);
        Console.WriteLine("-----------------");
    }

    public bool Fight(FightUnit other)
    {
        other.HP -= AT;

        if (other.HP <= 0)
        {
            other.HP = 0;
            return true;
        }

        return false;
    }

    public int ProAT
    {
        get;
    }
}
