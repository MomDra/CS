using System;

namespace _23Inheritance
{
    // 상속이란 코드 재활용성을 향상시키기위해 사용
    // C#은 오직 하나의 클래스만 상속을 할 수 있다.
    // 공통되는 기능을 하는 맴버변수와 맴버함수를 걷어낸다.
    class FightUnit
    {
        protected int hP;
        protected int AT;

        public void Damage(FightUnit other)
        {
            this.hP -= other.AT;
            other.hP -= this.AT;
        }
    }

    class Player : FightUnit
    {
        int LV;
    }

    class Monster : FightUnit
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            Monster newMonster = new Monster();

            newPlayer.Damage(newMonster);
            newMonster.Damage(newPlayer);
        }
    }
}
