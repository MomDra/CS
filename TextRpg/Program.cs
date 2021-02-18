using System;

namespace TextRpg
{
    class Program
    {
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 배틀");
            Console.WriteLine("어디로 가시겠습니까? ");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n마을에 입장합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("\n배틀존에 입장합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("\n잘못된 입력!");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }
        }

        static void Town(Player player)
        {
            while (true)
            {
                Console.Clear();
                player.StatusRender();
                Console.WriteLine("마을에서 무슨일을 하시겠습니까?");
                Console.WriteLine("1. 체력을 회복한다.");
                Console.WriteLine("2. 무기를 강화한다.");
                Console.WriteLine("3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        player.MAXHeal();
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            }
           
        }

        static void Battle(Player player)
        {
            Monster newMonster = new Monster();
            bool Playerturn = true;
            bool isPlayerDie = false;
            bool isMonsterDie = false;
            while (true)
            {
                Console.Clear();
                player.StatusRender();
                newMonster.StatusRender();

                if (isPlayerDie)
                {
                    Console.WriteLine("플레이어가 죽었습니다. 마을로 복귀합니다.");
                    Console.ReadKey();
                    Town(player);
                    return;
                }
                else if (isMonsterDie)
                {
                    Console.WriteLine("몬스터를 잡았습니다.. 마을로 복귀합니다.");
                    Console.ReadKey();
                    Town(player);
                    return;
                }


                if (Playerturn)
                {
                    isMonsterDie = player.Fight(newMonster);
                    Console.Clear();
                    player.StatusRender();
                    newMonster.StatusRender();
                    Console.WriteLine("플레이어가 몬스터를 때려 {0}만큼 대미지를 입혔습니다.", player.ProAT);
                    Console.ReadKey();
                    Playerturn = false;
                }
                else
                {
                    isPlayerDie = newMonster.Fight(player);
                    Console.Clear();
                    player.StatusRender();
                    newMonster.StatusRender();
                    Console.WriteLine("몬스터가 플레이어를 때려 {0}만큼 대미지를 입혔습니다.", newMonster.ProAT);
                    Console.ReadKey();
                    Playerturn = true;
                } 
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            while (true)
            {
                switch (StartSelect())
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(player);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(player);
                        break;
                }
            }
        }
    }
}
