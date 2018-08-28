namespace ConsoleForLibrarryDelegates
{
    public interface IDelegate
    {
        void FirstDelegateMethod(FirstDelegate method);
        void SecondDelegateMethod(SecondDelegate method);
        void FirdDelegateMethod(FirdDelegate methodVoid1, FirdDelegate methodVoid2, FirdDelegate methodVoid3);
        void FourthDelegateMethod();
        void FifthDelegateMethod(int first, int second);
        void SixthDelegateMethod(int first, int second, int sum);
        void SeventhDelegateMethod(SeventhDelegate1 methodDelegateSeven);
        void EighthDelegateMethod(EighthDelegate methodF, EighthDelegate1 methodString1, EighthDelegate2 methodString2);
        void NinthDelegateMethod();
    }
}