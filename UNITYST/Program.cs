using System;

struct Data // 구조체는 값타입
{
    // int num = 10; 이런식으로 초기화 못함 자동으로 0으로 초기화
    // static, const 필드는 초기화 가능
    // 모든 필드를 초기화 하지 않는 생성자 정의 불가
    public int num, num2;
    
}

enum Item // 열거형은 값타입
{
    POTION, GUN
}

class A
{
    public virtual void abc()
    {
        Console.WriteLine("HELLO");
    }
}

class B : A
{
     public override void abc()
    {
        Console.WriteLine("BYE");
    }
}

namespace UNITYST
{
    class Program
    {
        delegate int Del(int a, int b);

        static void Main(string[] args)
        {
            A newA = new B();
            newA.abc();

            B newB = new B();
            newB.abc();
        }
    }
}
