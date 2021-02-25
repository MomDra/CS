using System;

namespace _36Generic
{
    class CashItem
    {

    }

    class GameItem
    {

    }

    class Inven<T> // 제네릭 클래스를 이용해 캐쉬아이템, 게임아이템 인벤을 만들 수 있음
    {
        T[] items = new T[100];

        public void ItemAdd(T item)
        {
            
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            // 클래스는 <> 생략 불가능
            Inven<GameItem> gameinven = new Inven<GameItem>();
            Inven<CashItem> cashinven = new Inven<CashItem>();

            GameItem gameItem = new GameItem();
            gameinven.ItemAdd(gameItem);

            // 제네릭 타입을 유추 할 수 있으면 <> 생략 가능
            method(3);
        }

        static void method<T>(T val)
        {
            Console.WriteLine(val);
        }
    }
}
