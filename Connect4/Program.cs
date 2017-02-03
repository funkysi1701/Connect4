using System;

namespace Connect4
{
    class Program
    {
        public static int player = 1;
        static void Main(string[] args)
        {
            Game g = new Game();
            g.setup();
            
            g.draw();
            int move = -1;
            
            while (move > -2)
            {
                if (player == 1)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    switch (info.Key)
                    {
                        case ConsoleKey.D0:
                            move = 0;
                            break;
                        case ConsoleKey.D1:
                            move = 1;
                            break;
                        case ConsoleKey.D2:
                            move = 2;
                            break;
                        case ConsoleKey.D3:
                            move = 3;
                            break;
                        case ConsoleKey.D4:
                            move = 4;
                            break;
                        case ConsoleKey.D5:
                            move = 5;
                            break;
                        case ConsoleKey.D6:
                            move = 6;
                            break;
                        case ConsoleKey.Escape:
                            move = -5;
                            break;
                    }
                }
                if (player == 2)
                {
                    Random r = new Random();
                    move = r.Next(0, 7);
                }
                if(move == -5)
                {
                    g.setup();
                    g.draw();
                }
                else
                {
                    g.game = Program.move(g.game, move);
                    g.draw();
                }
                if (g.checkwin())
                {
                    Console.WriteLine("Player " + player + " has won.");
                    Console.ReadKey();
                    g.setup();
                    g.draw();
                    Random r = new Random();
                    player = r.Next(1, 3);
                }
                if (player == 1) player = 2;
                else if (player == 2) player = 1;
            }
        }
        private static int[,] move(int[,] game, int col)
        {
            int height = 5;
            if (game[height, col] == 0)
            {
                game[height, col] = player;
            }
            else if (game[height - 1, col] == 0)
            {
                game[height - 1, col] = player;
            }
            else if (game[height - 2, col] == 0)
            {
                game[height - 2, col] = player;
            }
            else if (game[height - 3, col] == 0)
            {
                game[height - 3, col] = player;
            }
            else if (game[height - 4, col] == 0)
            {
                game[height - 4, col] = player;
            }
            else if (game[height - 5, col] == 0)
            {
                game[height - 5, col] = player;
            }
            else
            {
                if (player == 1) player = 2;
                else if (player == 2) player = 1;
            }
            return game;
        }

    }
}
