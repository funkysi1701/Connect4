using System;

namespace Connect4
{
    public class Game
    {
        public int[,] game = new int[6, 7];
        /// <summary>
        /// Setup Game arena
        /// </summary>
        public void setup()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    game[i, j] = 0;
                }
            }
        }
        /// <summary>
        /// Checks if game is won,
        /// currently doesn't check diagonally
        /// </summary>
        /// <returns></returns>
        public bool checkwin()
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
                                                return true;
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
                                                return true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Draws the game screen
        /// </summary>
        public void draw()
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
    }
}
