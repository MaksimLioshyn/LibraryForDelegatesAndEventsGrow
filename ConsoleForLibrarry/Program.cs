using System;
using LibraryForDelegatesAndEventsGrow;

namespace ConsoleForLibrarry
{
    public delegate void FirstDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            #region First
            FirstExampleDelegate firstExampleDelegate = new FirstExampleDelegate();
            FirstDelegate firstDelegate = new FirstDelegate(firstExampleDelegate.Method);
            firstDelegate.Invoke();
            //or
            firstDelegate();

            #endregion

            Console.ReadKey();
        }
    }
}
