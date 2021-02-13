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

namespace UNITYST
{
    class Program
    {
        static void Main(string[] args)
        {
            Data newData = new Data();
            newData.num = 10;

            Data newData2; // new 안써도 사용 가능
            newData2.num = 10;

            Item item = Item.GUN;

            bool a = item == Item.GUN;
        }
    }
}
