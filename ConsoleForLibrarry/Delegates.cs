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

    public delegate EighthDelegate3 EighthDelegate(EighthDelegate1 eighthDelegate1, EighthDelegate2 eighthDelegate2);
    public delegate string EighthDelegate1();
    public delegate string EighthDelegate2();
    public delegate string EighthDelegate3();

    delegate void NinthDelegate(int argument);

    class Delegates
    {
        public static EighthDelegate3 MethodF(EighthDelegate1 eighthDelegate1, EighthDelegate2 eighthDelegate2) =>
            () => eighthDelegate1.Invoke() + eighthDelegate2.Invoke();

        static void Main(string[] args)
        {
            #region all data

            int first = 1;
            int second = 2;
            int sum = 0;

            #endregion

            IDelegate d = new DelegatesAuxiliaryClass();

            d.FirstDelegateMethod(StaticDelegatesAuxiliaryClass.Method);
            d.SecondDelegateMethod(StaticDelegatesAuxiliaryClass.Method);
            d.FirdDelegateMethod(StaticDelegatesAuxiliaryClass.MethodVoid1, StaticDelegatesAuxiliaryClass.MethodVoid2, StaticDelegatesAuxiliaryClass.MethodVoid3);
            d.FourthDelegateMethod();
            d.FifthDelegateMethod(first,second);
            d.SixthDelegateMethod(first,second,sum);
            d.SeventhDelegateMethod(StaticDelegatesAuxiliaryClass.MethodDelegateSeven);
            d.EighthDelegateMethod(MethodF, StaticDelegatesAuxiliaryClass.MethodString1, StaticDelegatesAuxiliaryClass.MethodString2);
            d.NinthDelegateMethod();

            Console.ReadKey();
        }
    }
}
