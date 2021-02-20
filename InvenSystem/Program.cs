using System;

namespace InvenSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inven inven = new Inven(5, 3);

            inven.addItem(new Item("철검", 500));
            inven.addItem(new Item("갑옷", 700));


            while (true)
            {
                inven.Render();
                inven.selectMove(Console.ReadKey().Key);
                Console.Clear();
            }
        }
    }
}
