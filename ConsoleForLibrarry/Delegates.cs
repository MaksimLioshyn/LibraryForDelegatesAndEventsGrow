using System;

namespace ConsoleForLibrarryDelegates
{
    public delegate void FirstDelegate();
    public delegate string SecondDelegate(string name);
    public delegate void FirdDelegate();
    public delegate void FourthDelegate();
    public delegate int FifthDelegate(int a, int b);
    public delegate void SixthDelegate(ref int a, ref int b, out int c);

    public delegate SeventhDelegate2 SeventhDelegate1();  
    public delegate void SeventhDelegate2();

    delegate EighthDelegate3 EighthDelegate(EighthDelegate1 eighthDelegate1, EighthDelegate2 eighthDelegate2);
    delegate string EighthDelegate1();
    delegate string EighthDelegate2();
    delegate string EighthDelegate3();

    delegate void NinthDelegate(int argument);

    class Delegates
    {
        #region methods

        public static void Method() => Console.WriteLine("First delegate.");
        public static string Method(string name) => "Hello " + name;

        public static SeventhDelegate2 MethodDelegateSeven() => new SeventhDelegate2(MethodForSevenDelegate);
        public static void MethodForSevenDelegate() => Console.WriteLine("Hello world!");

        public static void MethodVoid1() => Console.WriteLine("Method 1");

        public static void MethodVoid2() => Console.WriteLine("Method 2");

        public static void MethodVoid3() => Console.WriteLine("Method 3");

        public static string MethodString1() => "Hello ";
        public static string MethodString2() => "world!";

        public static EighthDelegate3 MethodF(EighthDelegate1 eighthDelegate1, EighthDelegate2 eighthDelegate2) =>
            () => eighthDelegate1.Invoke() + eighthDelegate2.Invoke();

        #endregion

        static void Main(string[] args)
        {
            #region all data

            int first = 1;
            int second = 2;
            int sum = 0;

            #endregion

            #region first

            FirstDelegate firstDelegate = new FirstDelegate(Method);
            firstDelegate.Invoke();
            //or
            firstDelegate();

            #endregion

            #region second

            SecondDelegate secondDelegate = Method;
            Console.WriteLine(secondDelegate("User name!"));

            #endregion

            #region fird

            FirdDelegate firdDelegate1 = MethodVoid1;
            FirdDelegate firdDelegate2 = MethodVoid2;
            FirdDelegate firdDelegate3 = MethodVoid3;

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

            #region fourth

            FourthDelegate fourthDelegate = delegate { Console.WriteLine("Hello world, FourthDelegate!"); };

            fourthDelegate();

            #endregion

            #region fifth
            
            FifthDelegate fifthDelegate1 = delegate (int a, int b) { return a + b; };
            FifthDelegate fifthDelegate2 = (a, b) => a + b;

            Console.WriteLine($"{first} + {second} = {fifthDelegate1(first, second)}");
            Console.WriteLine($"{first} + {second} = {fifthDelegate2(first, second)}");

            #endregion

            #region sixth

            SixthDelegate sixthDelegate = delegate (ref int a, ref int b, out int c) { a++; b++; c = a + b; };

            sixthDelegate(ref first, ref second, out sum);

            Console.WriteLine($"{first} + {second} = {sum}");

            #endregion

            #region seventh

            SeventhDelegate1 seventhDelegate1 = new SeventhDelegate1(MethodDelegateSeven);

            SeventhDelegate2 seventhDelegate2 = seventhDelegate1();

            seventhDelegate2();

            #endregion

            #region eighth

            EighthDelegate eighthDelegate = MethodF;
            EighthDelegate3 eighthDelegate3 = eighthDelegate.Invoke(new EighthDelegate1(MethodString1), new EighthDelegate2(MethodString2));

            Console.WriteLine(eighthDelegate3.Invoke());

            #endregion

            #region ninth

            NinthDelegate ninth = null; 

            ninth = (int i) =>
            {
                i--;
                Console.WriteLine($"Begin {i}");

                if (i > 0)
                {
                    ninth(i);
                }

                Console.WriteLine($"End {i}");
            };

            ninth(3);

            #endregion

            Console.ReadKey();
        }
    }
}
