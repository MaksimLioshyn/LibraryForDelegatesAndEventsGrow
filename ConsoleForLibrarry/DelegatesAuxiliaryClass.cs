using System;

namespace ConsoleForLibrarryDelegates
{
    public class DelegatesAuxiliaryClass: IDelegate
    {
        public void FirstDelegateMethod(FirstDelegate method)
        {
            FirstDelegate firstDelegate = new FirstDelegate(method);
            firstDelegate.Invoke();
            //or
            firstDelegate();
        }

        public void SecondDelegateMethod(SecondDelegate method)
        {
            SecondDelegate secondDelegate = method;
            Console.WriteLine(secondDelegate("User name!"));
        }

        public void FirdDelegateMethod(FirdDelegate methodVoid1, FirdDelegate methodVoid2, FirdDelegate methodVoid3)
        {
            FirdDelegate firdDelegate1 = methodVoid1;
            FirdDelegate firdDelegate2 = methodVoid2;
            FirdDelegate firdDelegate3 = methodVoid3;

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
        }

        public void FourthDelegateMethod()
        {
            FourthDelegate fourthDelegate = delegate { Console.WriteLine("Hello world, FourthDelegate!"); };
            fourthDelegate();
        }

        public void FifthDelegateMethod(int first, int second)
        {
            FifthDelegate fifthDelegate1 = delegate (int a, int b) { return a + b; };
            FifthDelegate fifthDelegate2 = (a, b) => a + b;

            Console.WriteLine($"{first} + {second} = {fifthDelegate1(first, second)}");
            Console.WriteLine($"{first} + {second} = {fifthDelegate2(first, second)}");
        }

        public void SixthDelegateMethod(int first, int second, int sum)
        {
            SixthDelegate sixthDelegate = delegate (ref int a, ref int b, out int c) { a++; b++; c = a + b; };
            sixthDelegate(ref first, ref second, out sum);
            Console.WriteLine($"{first} + {second} = {sum}");
        }

        public void SeventhDelegateMethod(SeventhDelegate1 methodDelegateSeven)
        {
            SeventhDelegate1 seventhDelegate1 = new SeventhDelegate1(methodDelegateSeven);
            SeventhDelegate2 seventhDelegate2 = seventhDelegate1();
            seventhDelegate2();
        }

        public void EighthDelegateMethod(EighthDelegate methodF, EighthDelegate1 methodString1, EighthDelegate2 methodString2)
        {
            EighthDelegate eighthDelegate = methodF;
            EighthDelegate3 eighthDelegate3 = eighthDelegate.Invoke(new EighthDelegate1(methodString1), new EighthDelegate2(methodString2));

            Console.WriteLine(eighthDelegate3.Invoke());
        }

        public void NinthDelegateMethod()
        {
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
        }
    }
}
