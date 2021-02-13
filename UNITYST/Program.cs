using System;

// 정적 클래스 정적 맴버변수,함수만을 가질 수 있는 클래스
class Player
{
    int hp;


    // 맴버함수 인자에 this가 생략되어 있다.
    public void Heal(/* Player this*/ int _heal)
    {
        // 맴버 함수에서 맴버 면수를 쓴다면 앞에 this.이 생략되어 있는 것
        this.hp += _heal;
    }

    public static void Damage(int _dmg)
    {
        // 정적 멤버 함수에는 this 키워드가 없다.
        // hp -= _dmg;
    }

}

namespace UNITYST
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}
