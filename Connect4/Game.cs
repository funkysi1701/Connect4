using System;

namespace Connect4
{
    /// <summary>
    /// creates the game array and methods for it
    /// </summary>
    public class Game
    {
        public int[,] game = new int[6, 7];

        public int player = 1;
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
                        if (j < 6 && i < 5)
                        {
                            if (game[i, j] == game[i + 1, j + 1])
                            {
                                if (j < 5 && i < 4)
                                {
                                    if (game[i, j] == game[i + 2, j + 2])
                                    {
                                        if (j < 4 && i < 3)
                                        {
                                            if (game[i, j] == game[i + 3, j + 3])
                                            {
                                                return true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (j < 6 && i < 5 && j > 0)
                        {
                            if (game[i, j] == game[i + 1, j - 1])
                            {
                                if (j < 5 && i < 4 && j > 1)
                                {
                                    if (game[i, j] == game[i + 2, j - 2])
                                    {
                                        if (j < 4 && i < 3 && j >2)
                                        {
                                            if (game[i, j] == game[i + 3, j - 3])
                                            {
                                                return true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
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
            Console.WriteLine("Connect4");
            Console.WriteLine();
            Console.WriteLine("Use number keys 0 to 6 to make your move.");
            Console.WriteLine("To select a human opponent press H, for the unintelligent computer press U, for intelligent computer press I");
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (game[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (game[i, j] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(i+","+j+" ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// makes a move
        /// </summary>
        /// <param name="col">0 to 6 for each of the seven possible moves</param>
        public void move(int col)
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
        }
    }
}
