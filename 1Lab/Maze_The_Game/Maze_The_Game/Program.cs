using System;

namespace maze_the_game_first_lab
{
    class Program
    {
        private static bool reply = false, win_lose = false, game_over = false;
        private static int width = 20, height = 19;
        private static int player_x, player_y, coin_x, coin_y, coin_x1, coin_y1, coin_x2, coin_y2, coin_x3, coin_y3, coin_x4, coin_y4, friend_x = 12, friend_y = 18, score;
        private static char barrier = 'X';
        private enum enum_steps
        {
            STOP = 0,
            LEFT, RIGHT, UP, DOWN
        }
        static enum_steps DIR;
        static void New_Coin()
        {
            coin_x = 3;
            coin_y = 5;
            coin_x1 = 17;
            coin_y1 = 1;
            coin_x2 = 2;
            coin_y2 = 18;
            coin_x3 = 13;
            coin_y3 = 3;
            coin_x4 = 18;
            coin_y4 = 14;
        }
        static void Setup()
        {
            game_over = win_lose = false;
            DIR = enum_steps.STOP;
            player_y = player_x = 1;
            New_Coin();
            score = 0;
        }
        static void Input()
        {
            switch (Console.ReadKey().KeyChar)
            {
                case 'a':
                    DIR = enum_steps.LEFT;
                    break;
                case 'd':
                    DIR = enum_steps.RIGHT;
                    break;
                case 'w':
                    DIR = enum_steps.UP;
                    break;
                case 's':
                    DIR = enum_steps.DOWN;
                    break;
                case 'ф':
                    DIR = enum_steps.LEFT;
                    break;
                case 'в':
                    DIR = enum_steps.RIGHT;
                    break;
                case 'ц':
                    DIR = enum_steps.UP;
                    break;
                case 'ы':
                    DIR = enum_steps.DOWN;
                    break;
                default:
                    DIR = enum_steps.STOP;
                    break;
            }
            Console.Clear();
        }
        static void Logic()
        {
            switch (DIR)
            {
                case enum_steps.UP:
                    player_x--;
                    break;
                case enum_steps.DOWN:
                    player_x++;
                    break;
                case enum_steps.RIGHT:
                    player_y++;
                    break;
                case enum_steps.LEFT:
                    player_y--;
                    break;
            }
            if (player_x > width - 1 || player_x <= 0 || player_y <= 0 || player_y > height - 1)
            {
                game_over = true;
            }
            if (coin_x == player_x && coin_y == player_y)
            {
                coin_x = -11;
                coin_y = -11;
                score += 125;
            }
            else if (coin_x1 == player_x && coin_y1 == player_y)
            {
                coin_x1 = -12;
                coin_y1 = -12;
                score += 125;
            }
            else if (coin_x2 == player_x && coin_y2 == player_y)
            {
                coin_x2 = -13;
                coin_y2 = -13;
                score += 125;
            }
            else if (coin_x3 == player_x && coin_y3 == player_y)
            {
                coin_x3 = -14;
                coin_y3 = -14;
                score += 125;
            }
            else if (coin_x4 == player_x && coin_y4 == player_y)
            {
                coin_x4 = -15;
                coin_y4 = -15;
                score += 125;
            }
            if (
                (player_y == 2 && player_x < 5 && player_x > 0) ||
                (player_y == 1 && player_x == 6) || (player_y == 1 && player_x == 10) || (player_y == 2 && player_x == 8) || (player_y == 2 && player_x >= 10 && player_x <= 14) || (player_y == 2 && player_x > 15 && player_x < 18) ||
                (player_y == 3 && player_x == 4) || (player_y == 3 && player_x >= 6 && player_x <= 8) || (player_y == 3 && player_x == 11) || (player_y == 3 && player_x == 14) ||
                (player_y == 4 && player_x >= 2 && player_x <= 4) || (player_y == 4 && player_x >= 6 && player_x <= 7) || (player_y == 4 && player_x >= 10 && player_x <= 11) || (player_y == 4 && player_x == 13) || (player_y == 4 && player_x >= 16 && player_x <= 18) ||
                (player_y == 5 && player_x == 8) ||
                (player_y == 6 && player_x >= 1 && player_x <= 6) || (player_y == 6 && player_x == 8) || (player_y == 6 && player_x == 10) || (player_y == 6 && player_x == 12) || (player_y == 6 && player_x == 15) || (player_y == 6 && player_x == 17) ||
                (player_y == 7 && player_x == 8) || (player_y == 7 && player_x == 10) || (player_y == 7 && player_x == 12) || (player_y == 7 && player_x >= 14 && player_x <= 15) || (player_y == 7 && player_x == 17) ||
                (player_y == 8 && player_x == 8) || (player_y == 8 && player_x == 15) || (player_y == 8 && player_x == 17) ||
                (player_y == 9 && player_x == 2) || (player_y == 9 && player_x >= 4 && player_x <= 10) || (player_y == 9 && player_x == 17) ||
                (player_y == 10 && player_x == 2) || (player_y == 10 && player_x >= 12 && player_x <= 13) || (player_y == 10 && player_x == 15) || (player_y == 10 && player_x == 17) ||
                (player_y == 11 && player_x >= 2 && player_x <= 3) || (player_y == 11 && player_x >= 5 && player_x <= 7) || (player_y == 11 && player_x == 9) || (player_y == 11 && player_x == 15) || (player_y == 11 && player_x == 17) ||
                (player_y == 12 && player_x == 5) || (player_y == 12 && player_x == 10) || (player_y == 12 && player_x == 12) || (player_y == 12 && player_x == 15) || (player_y == 12 && player_x == 17) ||
                (player_y == 13 && player_x >= 2 && player_x <= 15) || (player_y == 13 && player_x == 17) ||
                (player_y == 14 && player_x >= 2 && player_x <= 4) || (player_y == 14 && player_x == 17) ||
                (player_y == 15 && player_x == 4) || (player_y == 15 && player_x >= 6 && player_x <= 18) ||
                (player_y == 16 && player_x >= 1 && player_x <= 2) || (player_y == 16 && player_x == 4) || (player_y == 16 && player_x == 6) || (player_y == 16 && player_x == 18) ||
                (player_y == 17 && player_x >= 1 && player_x <= 2) || (player_y == 17 && player_x == 4) || (player_y == 17 && player_x >= 8 && player_x <= 16) || (player_y == 17 && player_x == 18) ||
                (player_y == 18 && player_x == 1) || (player_y == 18 && player_x == 4) || (player_y == 18 && player_x == 7) || (player_y == 18 && player_x == 11) || (player_y == 18 && player_x == 18)
                )
            {
                game_over = true;
            }
            if (player_x == friend_x && player_y == friend_y)
            {
                win_lose = true;
                game_over = true;
                Win();
            }
        }
        static void Draw()
        {
            for (int i = 1; i < width; i++)
            {
                Console.Write(barrier);
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(barrier);
                    }
                    else if (j == width - 1)
                    {
                        if (i == 0)
                        {
                            Console.Write("");
                        }
                        else
                        {
                            Console.Write(barrier);
                        }
                    }
                    else if (i == player_x && j == player_y)
                    {
                        Console.Write("☺");
                    }
                    else if ((i == coin_x && j == coin_y) || (i == coin_x1 && j == coin_y1) || (i == coin_x2 && j == coin_y2) || (i == coin_x3 && j == coin_y3) || (i == coin_x4 && j == coin_y4))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("$");
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (i == friend_x && j == friend_y)
                    {
                        Console.Write("☻");
                    }
                    else if (
                        (j == 2 && i < 5 && i > 0) ||
                        (j == 1 && i == 6) || (j == 1 && i == 10) || (j == 2 && i == 8) || (j == 2 && i >= 10 && i <= 14) || (j == 2 && i > 15 && i < 18) ||
                        (j == 3 && i == 4) || (j == 3 && i >= 6 && i <= 8) || (j == 3 && i == 11) || (j == 3 && i == 14) ||
                        (j == 4 && i >= 2 && i <= 4) || (j == 4 && i >= 6 && i <= 7) || (j == 4 && i >= 10 && i <= 11) || (j == 4 && i == 13) || (j == 4 && i >= 16 && i <= 18) ||
                        (j == 5 && i == 8) ||
                        (j == 6 && i >= 1 && i <= 6) || (j == 6 && i == 8) || (j == 6 && i == 10) || (j == 6 && i == 12) || (j == 6 && i == 15) || (j == 6 && i == 17) ||
                        (j == 7 && i == 8) || (j == 7 && i == 10) || (j == 7 && i == 12) || (j == 7 && i >= 14 && i <= 15) || (j == 7 && i == 17) ||
                        (j == 8 && i == 8) || (j == 8 && i == 15) || (j == 8 && i == 17) ||
                        (j == 9 && i == 2) || (j == 9 && i >= 4 && i <= 10) || (j == 9 && i == 17) ||
                        (j == 10 && i == 2) || (j == 10 && i >= 12 && i <= 13) || (j == 10 && i == 15) || (j == 10 && i == 17) ||
                        (j == 11 && i >= 2 && i <= 3) || (j == 11 && i >= 5 && i <= 7) || (j == 11 && i == 9) || (j == 11 && i == 15) || (j == 11 && i == 17) ||
                        (j == 12 && i == 5) || (j == 12 && i == 10) || (j == 12 && i == 12) || (j == 12 && i == 15) || (j == 12 && i == 17) ||
                        (j == 13 && i >= 2 && i <= 15) || (j == 13 && i == 17) ||
                        (j == 14 && i >= 2 && i <= 4) || (j == 14 && i == 17) ||
                        (j == 15 && i == 4) || (j == 15 && i >= 6 && i <= 18) ||
                        (j == 16 && i >= 1 && i <= 2) || (j == 16 && i == 4) || (j == 16 && i == 6) || (j == 16 && i == 18) ||
                        (j == 17 && i >= 1 && i <= 2) || (j == 17 && i == 4) || (j == 17 && i >= 8 && i <= 16) || (j == 17 && i == 18) ||
                        (j == 18 && i == 1) || (j == 18 && i == 4) || (j == 18 && i == 7) || (j == 18 && i == 11) || (j == 18 && i == 18)
                        )
                    {
                        Console.Write(barrier);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < width; i++)
            {
                Console.Write(barrier);
            }
        }
        static void Lose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("....===...===.....=====.....==☺....==......==..........=====........=====....=====....");
            Console.WriteLine(".....==...==....==.....==...==.....==..☺...==........==.....==.....==........=........");
            Console.WriteLine(".......===.☺....==.....==...==.....==......==..☺.....==..☺..==.......==.☺....====......");
            Console.WriteLine(".....☺..=.......==.☺...==....==...==.......==........==.....==........==.....=......☺.");
            Console.WriteLine("........=.........=====........===.........=======.....=====.......=====.....=====....");
            Console.WriteLine("Press enter to replay");
        }
        static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("....===...===.....=====.....==...☺.==......===....===....===....===....====...☺..==");
            Console.WriteLine(".....==☺..==....==.....==...==.....==.......===..==.==..===............==..==....==");
            Console.WriteLine(".......===......==.....==...==.....==........===.==.==.===......===....==...==...==");
            Console.WriteLine("........=.......==...☺.==....==...==..........====☺..====.......===....==.☺..==..==");
            Console.WriteLine("........=.........=====........===.............===...===........===.☺..==......====");
            Console.WriteLine("Press enter to replay");
        }
        static void Main(string[] args)
        {
            while (!reply)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("====== WELCOME TO MAZE ======");
                Console.WriteLine("===Let's meet with my game===");
                Console.WriteLine("====Press enter to replay====");
                Console.WriteLine("=====Use w-a-s-d to move=====");
                Console.WriteLine("====Collect coins to earn====");
                Console.WriteLine("===Don't touch the barrier===");
                Console.WriteLine("=======He is energized=======");
                Console.WriteLine("===Aim is find your friend===\n");
                Console.WriteLine("====Press s to start game====\n");
                Setup();
                while (!game_over)
                {
                    Draw();
                    Console.WriteLine();
                    Input();
                    Console.WriteLine();
                    Logic();
                    Console.Write("YOUR SCORE : ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(score);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                }
                if (!win_lose)
                {
                    Lose();
                }
                Console.ReadLine();

            }
        }
    }
}