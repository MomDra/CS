using System;
using System.Collections.Generic;
using System.Text;

class Player : FightUnit
{
    public void MAXHeal()
    {
        HP = MAXHP;
    }

    public Player()
    {
        Name = "플레이어";
        HP = 100;
    }
}
