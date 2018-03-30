using System;
using LibraryForDelegatesAndEventsGrow;

namespace ConsoleForLibrarry
{
    public delegate void FirstDelegate();
    public delegate string SecondDelegate(string name);
    public delegate void FirdDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            #region first

            FirstExampleDelegate firstExampleDelegate = new FirstExampleDelegate();
            FirstDelegate firstDelegate = new FirstDelegate(firstExampleDelegate.Method);
            firstDelegate.Invoke();
            //or
            firstDelegate();

            #endregion


            #region second

            SecondExampleDelegate secondExampleDelegate = new SecondExampleDelegate();
            SecondDelegate secondDelegate = secondExampleDelegate.Method;
            Console.WriteLine(secondDelegate("Hello World"));

            #endregion

            #region fird

            FirdExampleDelegate firdExampleDelegate = new FirdExampleDelegate();

            FirdDelegate firdDelegate1 = firdExampleDelegate.Method1;
            FirdDelegate firdDelegate2 = firdExampleDelegate.Method2;
            FirdDelegate firdDelegate3 = firdExampleDelegate.Method3;

            var firdDelegate = firdDelegate1 + firdDelegate2 + firdDelegate3;

            Console.WriteLine("Enter a number between 1 and 7");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                {
                    firdDelegate1.Invoke();
                    break;
                }
                case "2":
                {
                    firdDelegate2.Invoke();
                    break;
                }
                case "3":
                {
                    firdDelegate3.Invoke();
                    break;
                }
                case "4":
                {
                    FirdDelegate myDelegate4 = firdDelegate - firdDelegate1;
                    myDelegate4.Invoke();
                    break;
                }
                case "5":
                {
                    FirdDelegate myDelegate5 = firdDelegate - firdDelegate2;
                    myDelegate5.Invoke();
                    break;
                }
                case "6":
                {
                    FirdDelegate myDelegate6 = firdDelegate - firdDelegate3;
                    myDelegate6.Invoke();
                    break;
                }
                case "7":
                {
                    firdDelegate.Invoke();
                    break;
                }
                default:
                {
                    Console.WriteLine("Exception.");
                    break;
                }
            }

            #endregion




            Console.ReadKey();
        }
    }
}
