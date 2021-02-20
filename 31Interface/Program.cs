using System;

namespace _31Interface
{

    interface QuestUnit
    {
        void Talk(QuestUnit questUnit);
    }

    class Player : QuestUnit
    {
        public void Talk(QuestUnit questUnit)
        {
            Console.WriteLine("Player의 Talk!");
        }
    }

    class NPC: QuestUnit
    {

        // 인터페이스를 상속하면 인터페이스에 정의된 함수를 반드시 포함해야 함
        public void Talk(QuestUnit questUnit)
        {
            Console.WriteLine("NPC의 Talk!");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            NPC npc = new NPC();

            QuestUnit qu1 = player;
            QuestUnit qu2 = npc;

            qu1.Talk(qu2);
            qu2.Talk(qu1);
            player.Talk(qu2);
            npc.Talk(qu1);


        }
    }
}
