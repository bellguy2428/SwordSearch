using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SwordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] BibleArray = { "Old Testiment", "Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel", "1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "Song of Songs", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "New Testiment","Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter", "2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation" };
            int testiment;
            int book;
            bool toContinue = false;
            string selection;
            string search;
            int choiceNum1 = 0;
            int choiceNum2 = 0;
            bool selectionTF = false;
            string choice1;
            string choice2;


            do
            {
                //choose book to race to
                Random rand = new Random();
                testiment = rand.Next(0, 2);

                if (testiment == 0)
                {
                    book = rand.Next(2, 39);
                }
                else
                {
                    book = rand.Next(42, 68);
                }

                Stopwatch stopWatch = new Stopwatch();

                //Countdown
                search = BibleArray[book];
                Console.Write($"You are looking for {search}.");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nReady?");
                System.Threading.Thread.Sleep(1000);                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t3");
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\t\t2");
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t1");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\tGO!");
                stopWatch.Start();
                
                                             
                //question 1
                do
                {
                    Console.WriteLine("\n\nOld Testiment or New Testiment?");
                    selection = Console.ReadLine().ToUpper();

                    if (testiment == 0 && selection == "OT" || selection == "OLD TESTIMENT" || selection == "OLDTESTIMENT")
                    {
                        selectionTF = true;
                        choiceNum1 = rand.Next(1, book - 1);
                        choiceNum2 = rand.Next(book + 1, 39);
                    }
                    else if (testiment == 1 && selection == "NT" || selection == "NEW TESTIMENT" || selection == "NEWTESTIMENT")
                    {
                        selectionTF = true;
                        choiceNum1 = rand.Next(41, book - 1);
                        choiceNum2 = rand.Next(book + 1, 68);
                    }
                    else 
                    {
                        Console.WriteLine("Response was incorrect. Please try again.");
                    }

                } while (selectionTF == false);


                //question 2
                do
                {
                    choice1 = BibleArray[choiceNum1];
                    choice2 = BibleArray[choiceNum2];
                    Console.WriteLine($"Which is closer to {search}?\n{choice1} or {choice2}?");
                    selection = Console.ReadLine().ToLower();

                    int distance1 = book - choiceNum1;
                    int distance2 = choiceNum2 - book;

                    if (distance1 > distance2 && selection == choice2.ToLower())
                    {
                        selectionTF = true;

                    }
                    else if (distance1 < distance2 && selection == choice1.ToLower())
                    {
                        selectionTF = true;

                    }
                    else if (distance1 == distance2 && selection == "same" || selection == "equal" || selection == "neither")
                    {
                        selectionTF = true;
                    }
                    else
                    {
                        selectionTF = false;
                        Console.WriteLine("Response was incorrect. Please try again.");
                    }

                } while (selectionTF == false);


                //question 3 randomizer
                int boa = rand.Next(0, 1);
                string BoA = "";
                if (boa == 0)
                {
                    BoA = "before";
                }
                else
                {
                    BoA = "after";
                }

                if (testiment == 0)
                {
                    
                    choiceNum1 = rand.Next(1, book - 1);
                    choiceNum2 = rand.Next(book + 1, 39);
                }
                else if (testiment == 1)
                {
                    
                    choiceNum1 = rand.Next(41, book - 1);
                    choiceNum2 = rand.Next(book + 1, 68);
                }

                //mixes up the next selection so that they aren't automatically in order
                int order = rand.Next(0, 1);

                if (order == 0)
                {
                    choice1 = BibleArray[choiceNum1];
                    choice2 = BibleArray[choiceNum2];
                }
                else
                {
                    choice1 = BibleArray[choiceNum2];
                    choice2 = BibleArray[choiceNum1];
                }

                //question 3
                do
                {                    
                    Console.WriteLine($"Which book comes {BoA} {search}?");
                    Console.WriteLine($"{choice1} or {choice2}");
                    selection = Console.ReadLine().ToLower();

                    if (BoA == "before" && order == 0 && selection == choice1.ToLower())
                    {
                        selectionTF = true;
                    }
                    else if (BoA == "after" && order == 0 && selection == choice2.ToLower())
                    {
                        selectionTF = true;
                    }
                    else if (BoA == "before" && order == 1 && selection == choice2.ToLower())
                    {
                        selectionTF = true;
                    }
                    else if (BoA == "after" && order == 1 && selection == choice1.ToLower())
                    {
                        selectionTF = true;
                    }
                    else
                    {
                        selectionTF = false;
                    }

                } while (selectionTF == false);

                //stop timer calculated time
                Console.ResetColor();
                double time = stopWatch.ElapsedMilliseconds;
                //int time = Convert.ToInt32(timer);
                stopWatch.Stop();
                double secs = time / 1000;
                double mins = secs / 60 ;
                mins = Math.Floor(mins);
                secs = secs - (mins * 60);
                string seconds = secs.ToString("N3");
                string minutes = mins.ToString("N0");
                
                

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("C");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("o");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("g");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("r");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("a");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("t");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("s");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("!");
                Console.ResetColor();

                                
                Console.WriteLine($"\nYou finished in {minutes}:{seconds}!");                
                Console.WriteLine($"\n\nWould you like to play again?");
                string input = Console.ReadLine().ToLower();
                if (input == "y" || input == "yes" || input == "yeah")
                {
                    toContinue = true;
                }
                else
                {
                    toContinue = false;
                }

            } while (toContinue == true);
            
            Console.ReadKey();

        }
    }
}
