using System;
using System.Collections.Generic;
using System.Text;


class Inven
{
    Item[] items;
    int x;
    int selectnum = 0;

    public Inven(int x, int y)
    {
        this.x = x;

        items = new Item[x * y];
    }

    public void addItem(Item _item)
    {
        for (int i = 0; i<items.Length; i++)
        {
            if(items[i] == null)
            {
                items[i] = _item;
                break;
            }
        }
    }

    public void Render()
    {
        for(int i = 0; i<items.Length; i++)
        {
            if(i % x == 0 && i != 0)
            {
                Console.WriteLine();
            }

            if(i == selectnum)
            {
                Console.Write("▣");
            }
            else if(items[i] != null)
            {
                Console.Write("■");
            }
            else
            {
                Console.Write("□");
            }
        }

        if(items[selectnum] != null)
        {
            Console.WriteLine("\n--------------------");
            items[selectnum].Render();
            Console.WriteLine("--------------------");
        }
        else
        {
            Console.WriteLine("\n--------------------");
            Console.WriteLine("정보 없음");
            Console.WriteLine("--------------------");
        }
        

    }

    public void selectMove(ConsoleKey key)
    {
        int num = selectnum;

        switch (key)
        {
            case ConsoleKey.RightArrow:
                MoveRight();
                break;
            case ConsoleKey.LeftArrow:
                MoveLeft();
                break;
            case ConsoleKey.UpArrow:
                MoveUp();
                break;
            case ConsoleKey.DownArrow:
                MoveDown();
                break;
        }
    }
    
    private bool IsMoveable(int num)
    {
        return num >= 0 && num < items.Length;
    }

    private void MoveRight()
    {
        int num = selectnum;

        if (IsMoveable(++num))
        {
            selectnum++;
        }
    }

    private void MoveLeft()
    {
        int num = selectnum;

        if (IsMoveable(--num))
        {
            selectnum--;
        }
    }

    private void MoveUp()
    {
        int num = selectnum;

        if (IsMoveable(num - x))
        {
            selectnum -= x;
        }
    }

    private void MoveDown()
    {
        int num = selectnum;

        if (IsMoveable(num + x))
        {
            selectnum += x;
        }
    }
}

