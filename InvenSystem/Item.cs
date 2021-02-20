using System;
using System.Collections.Generic;
using System.Text;


class Item
{
    string Name;
    int Gold;

    public Item(string _Name, int _Gold)
    {
        Name = _Name;
        Gold = _Gold;
    }

    public void Render()
    {
        Console.WriteLine("이름: " + Name);
        Console.WriteLine("가격: " + Gold);
    }
}

