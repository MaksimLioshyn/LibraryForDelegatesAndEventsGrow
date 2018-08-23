using System.ComponentModel.Design.Serialization;

namespace ClassLibraryDelegatesForL2
{
    public class ClassForTask
    {
        private int _x1 = 1;
        private int _x2 = 1;

        public delegate int Fibonacii(int x1, int x2);

        public int NextFicNumb(Fibonacii fibonacii)
        {
            int boof = _x2;
            _x2 = fibonacii(_x1, _x2);
            _x1 = boof;
            return _x2;
        }
    }
}
