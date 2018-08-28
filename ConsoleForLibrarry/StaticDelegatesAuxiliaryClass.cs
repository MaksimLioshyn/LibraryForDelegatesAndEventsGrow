using System;

namespace ConsoleForLibrarryDelegates
{
    public static class StaticDelegatesAuxiliaryClass
    {
        public static void Method() => Console.WriteLine("First delegate.");
        public static string Method(string name) => "Hello " + name;

        public static SeventhDelegate2 MethodDelegateSeven() => new SeventhDelegate2(MethodForSevenDelegate);
        public static void MethodForSevenDelegate() => Console.WriteLine("Hello world!");

        public static void MethodVoid1() => Console.WriteLine("Method 1");

        public static void MethodVoid2() => Console.WriteLine("Method 2");

        public static void MethodVoid3() => Console.WriteLine("Method 3");

        public static string MethodString1() => "Hello ";
        public static string MethodString2() => "world!";
    }
}
