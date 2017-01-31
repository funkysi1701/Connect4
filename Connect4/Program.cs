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
            game = move(game, 0, 2);
            draw(game);
            game = move(game, 1, 1);
            draw(game);
            game = move(game, 2, 2);
            draw(game);
            game = move(game, 3, 1);
            draw(game);
            game = move(game, 4, 2);
            draw(game);
            game = move(game, 5, 1);
            draw(game);
            game = move(game, 6, 2);
            draw(game);
        }

        private static void draw(int[,] game)
        {
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

        private static int[,] move(int[,] game, int col,int player)
        {
            int height = 5;
            if (game[height, col] == 0) {
                game[height, col] = player;
            }
            else if (game[height-1, col] == 0)
            {
                game[height-1, col] = player;
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
