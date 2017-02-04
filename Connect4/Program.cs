using System;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            g.setup();
            
            g.draw();
            int move = -1;
            int type = 1;
            while (move > -2)
            {
                if (g.player == 1 || type == 0)
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
                        case ConsoleKey.H:
                            type = 0;
                            break;
                        case ConsoleKey.U:
                            type = 1;
                            break;
                        case ConsoleKey.I:
                            type = 2;
                            break;
                        default:
                            move = -1;
                            break;
                    }
                }
                if (g.player == 2 && type == 1)
                {
                    Random r = new Random();
                    move = r.Next(0, 7);
                }
                if (g.player == 2 && type == 2)
                {
                    // Clever logic for deciding moves
                }
                if (move == -5)
                {
                    g.setup();
                    g.draw();
                }
                else if(move == -1)
                {
                    if (g.player == 1) g.player = 2;
                    else if (g.player == 2) g.player = 1;
                }
                else if (move > -1)
                {
                    g.move(move);
                    g.draw();
                }
                if (g.checkwin())
                {
                    Console.WriteLine("Player " + g.player + " has won.");
                    Console.ReadKey();
                    g.setup();
                    g.draw();
                    Random r = new Random();
                    g.player = r.Next(1, 3);
                }
                if (g.player == 1) g.player = 2;
                else if (g.player == 2) g.player = 1;
            }
        }
    }
}
