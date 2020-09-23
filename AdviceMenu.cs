using KanyeWest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace Advisor
{
    public static class AdviceMenu
    {
        static HttpClient client = new HttpClient();
        static readonly QuoteGenerator quoter = new QuoteGenerator(client);

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the advice generator! Do you want celebrity/character advice, anonymous advice, or no advice?");
            Console.WriteLine();
            Console.WriteLine("1) Celebrity/Character Advice!");
            Console.WriteLine("2) Anonymous Advice!");
            Console.WriteLine("3) No Advice!");
            Console.WriteLine();
            Console.WriteLine("Type 1, 2, or 3 and press enter:");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("Okay! Do you want advice from Kanye West, Ron Swanson, or Taylor Swift?");
                        Console.WriteLine();
                        Console.WriteLine("1) Kanye!");
                        Console.WriteLine("2) Ron!");
                        Console.WriteLine("3) Taylor!");
                        Console.WriteLine();
                        Console.WriteLine("Type 1, 2, or 3 and press enter:");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    AdviceMenu.PrePersonQuoteConsole("Kanye");
                                    Console.WriteLine(quoter.GetKanyeQuote());
                                    AdviceMenu.PostQuoteConsole();
                                    
                                    return true;
                                }
                            case "2":
                                {
                                    AdviceMenu.PrePersonQuoteConsole("Ron Swanson");
                                    Console.WriteLine(quoter.GetSwansonQuote());
                                    AdviceMenu.PostQuoteConsole();

                                    return true;
                                }
                            case "3":
                                {
                                    AdviceMenu.PrePersonQuoteConsole("T-Swift");
                                    Console.WriteLine(quoter.GetTSwiftQuote());
                                    AdviceMenu.PostQuoteConsole();

                                    return true;
                                }
                            default :
                                return true;
                        }
                    }
                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("Okay, anonymous advice it is!");
                        Thread.Sleep(2000);
                        Console.Clear();

                        Console.WriteLine("Think of a situation you'd like some advice on.");
                        Thread.Sleep(2500);
                        Console.WriteLine();

                        Console.WriteLine("Ready? Hit any key to continue!");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Here's the best advice available right now:");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        
                        Console.WriteLine(quoter.GetGoodAdvice());
                        
                        AdviceMenu.PostQuoteConsole();

                        return true;
                    }
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("Oh, okay, you've got it all figured out! Bye then!");
                        Thread.Sleep(2500);
                        return false;
                    }
                default:
                    return true;
            }
        }

        public static void PrePersonQuoteConsole(string name)
        {
            Console.Clear();

            Console.WriteLine("Okay, think of a situation you'd like advice on.");
            Thread.Sleep(2500);
            Console.WriteLine();

            Console.WriteLine("Ready? Hit any key to continue!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"According to {name}:");
            Thread.Sleep(1500);
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void PostQuoteConsole()
        {
            Thread.Sleep(2500);
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine("Hope that helps!");
            Thread.Sleep(2000);

            Console.WriteLine("( Press any button to go back to the main menu )");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
