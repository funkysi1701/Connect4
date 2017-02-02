using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] game = new int[6, 7];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    game[i, j] = 0;
                }
            }
            draw(game);
            int move = -1;
            int player = 1;
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
                    }

                }
                if (player == 2)
                {
                    Random r = new Random();
                    move = r.Next(0, 6);
                }
                game = Program.move(game, move, player);
                draw(game);
                checkwin(game);
                if (player == 1) player = 2;
                else if (player == 2) player = 1;
            }
        }

        private static void checkwin(int[,] game)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (game[i, j] != 0)
                    {
                        if (j < 6)
                        {
                            if (game[i, j] == game[i, j + 1])
                            {
                                if (j < 5)
                                {
                                    if (game[i, j] == game[i, j + 2])
                                    {
                                        if (j < 4)
                                        {
                                            if (game[i, j] == game[i, j + 3])
                                            {
                                                Console.WriteLine("Player " + game[i,j] + " has won.");
                                                Console.ReadKey();
                                                for (int k = 0; k < 6; k++)
                                                {
                                                    for (int l = 0; l < 7; l++)
                                                    {
                                                        game[k, l] = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (i < 5)
                            {
                                if (game[i, j] == game[i + 1, j])
                                {
                                    if (i < 4)
                                    {
                                        if (game[i, j] == game[i + 2, j])
                                        {
                                            if (i < 3)
                                            {
                                                if (game[i, j] == game[i + 3, j])
                                                {
                                                    Console.WriteLine("Player " + game[i, j] + " has won.");
                                                    Console.ReadKey();
                                                    for (int k = 0; k < 6; k++)
                                                    {
                                                        for (int l = 0; l < 7; l++)
                                                        {
                                                            game[k, l] = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private static void draw(int[,] game)
        {
            Console.Clear();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(game[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static int[,] move(int[,] game, int col, int player)
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
            return game;
        }
    }
}
