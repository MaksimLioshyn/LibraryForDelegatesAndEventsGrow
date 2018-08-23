using ClassLibraryDelegatesForL2;
using NUnit.Framework;

namespace ClassLibraryDelegatesForL2Tests
{
    [TestFixture()]
    public class ClassForTaskTests
    {
        public int FibonachiiFunction(int x1, int x2) => x1 + x2;

        private ClassForTask.Fibonachii _f;
        [TestCase(0, ExpectedResult = 2)]
        [TestCase(1, ExpectedResult = 3)]
        [TestCase(2, ExpectedResult = 5)]
        public int ShowFibonachiiTest(int circle)
        {
            _f += FibonachiiFunction;
            ClassForTask classForTask = new ClassForTask();
            for (int i = 0; i < circle; i++)
            {
                classForTask.NextFicNumb(_f);
            }
            return classForTask.NextFicNumb(_f);
        }
    }
}