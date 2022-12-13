using System;

namespace Learning_1
{
    class Learning_Homework_1
    {
        static void Main(string[] args)
        {
            int score1, score2;
            score1 = score2 = 0;
            string line;
            int z, moves_made;
            char who;
            char s1, s2, s3, s4, s5, s6, s7, s8, s9;
            bool success = false;

            while (true)
            {
                success = false;
                Console.WriteLine("1. New Game\n2. About the author\n3. Exit");
                Console.Write("> ");
                line = Console.ReadLine();
                //Console.WriteLine();
                if (int.TryParse(line, out z))
                {
                    if (z == 1)
                    {
                        moves_made = 0;
                        s1 = s2 = s3 = s4 = s5 = s6 = s7 = s8 = s9 = ' ';
                        while (true)
                        {
                            moves_made++;
                            Console.WriteLine(" {0} | {1} | {2} \n...+...+...\n {3} | {4} | {5} \n"
                                                + "...+...+...\n {6} | {7} | {8} ", s1, s2, s3, s4, s5, s6, s7, s8, s9);
                            if (moves_made % 2 == 1)
                                who = 'X';
                            else
                                who = 'O';
                            while (true)
                            {
                                success = false;
                                Console.Write("\n{0} -> ", who);
                                line = Console.ReadLine();
                                Console.WriteLine();
                                if (int.TryParse(line, out z))
                                {
                                    if ((z >= 1) && (z <= 9))
                                    {
                                        switch (z)
                                        {
                                            case 1:
                                                if (s1 == ' ')
                                                {
                                                    success = true;
                                                    s1 = who;
                                                }
                                                break;
                                            case 2:
                                                if (s2 == ' ')
                                                {
                                                    success = true;
                                                    s2 = who;
                                                }
                                                break;
                                            case 3:
                                                if (s3 == ' ')
                                                {
                                                    success = true;
                                                    s3 = who;
                                                }
                                                break;
                                            case 4:
                                                if (s4 == ' ')
                                                {
                                                    success = true;
                                                    s4 = who;
                                                }
                                                break;
                                            case 5:
                                                if (s5 == ' ')
                                                {
                                                    success = true;
                                                    s5 = who;
                                                }
                                                break;
                                            case 6:
                                                if (s6 == ' ')
                                                {
                                                    success = true;
                                                    s6 = who;
                                                }
                                                break;
                                            case 7:
                                                if (s7 == ' ')
                                                {
                                                    success = true;
                                                    s7 = who;
                                                }
                                                break;
                                            case 8:
                                                if (s8 == ' ')
                                                {
                                                    success = true;
                                                    s8 = who;
                                                }
                                                break;
                                            case 9:
                                                if (s9 == ' ')
                                                {
                                                    success = true;
                                                    s9 = who;
                                                }
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                    if (success)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Illegal Move! Try again.");
                                }
                                else
                                {
                                    Console.WriteLine("Illegal Move! Try again.");
                                }
                            }
                            if (((s1 == s2) && (s2 == s3) && (s2 != ' ')) || ((s4 == s5) && (s5 == s6) && (s5 != ' ')) || ((s7 == s8) && (s8 == s9) && (s8 != ' ')) || ((s1 == s4) && (s4 == s7) && (s4 != ' ')) || ((s2 == s5) && (s5 == s8) && (s5 != ' ')) || ((s3 == s6) && (s6 == s9) && (s6 != ' ')) || ((s1 == s5) && (s5 == s9) && (s5 != ' ')) || ((s3 == s5) && (s5 == s7) && (s5 != ' ')))
                            {
                                if (moves_made % 2 == 1)
                                    score1++;
                                else
                                    score2++;
                                line = who + " Won!";
                                break;
                            }
                            else if (moves_made >= 9)
                            {
                                line = "Draw";
                                break;
                            }

                        }
                        Console.WriteLine("Game Over\n");
                        Console.WriteLine("Game outcome: {0}!", line);
                        Console.WriteLine("Final Score\n'X' : 'O'\n {0}  :  {1}\n", score1, score2);
                        Console.WriteLine(" {0} | {1} | {2} \n...+...+...\n {3} | {4} | {5} \n"
                                            + "...+...+...\n {6} | {7} | {8} ", s1, s2, s3, s4, s5, s6, s7, s8, s9);
                        Console.Write("\n[Press Enter to return to main menu...]");
                        Console.ReadLine();
                        Console.Write("\n\n\n\n\n\n\n");
                    }
                    else if (z == 2)
                    {
                        Console.WriteLine("<Author of Fabulous tictactoe>\nName: Enes\nStatus: Alive\nDescription: Never give you up.");
                        Console.Write("[Press Enter to return to main menu...]");
                        Console.ReadLine();
                    }
                    else if (z == 3)
                    {
                        Console.Write("Are you sure you want to quit? [y/n] ");
                        line = Console.ReadLine();
                        if (line == "y")
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, your input is invalid.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, your input is invalid.");
                }
            }
        }
    }
}