using System;

namespace _35InnerClass
{

    class Outer
    {

        int at;

        void method()
        {
            Inner inner = new Inner();


            // 외부 클래스에서 이너 클래스의 멤버변수에는 접근 불가
            //inner.a = 5;
        }

        class Inner
        {
            int a;
            void method(Outer outer)
            {
                // 외부 클래스 멤버변수에 접근 가능
                outer.at = 5;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
