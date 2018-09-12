namespace ClassLibraryDelegatesForL2.Implementation
{
    public class TaskDelegates
    {
        private int _x1 = 1;
        private int _x2 = 1;

        public delegate int Fibonachii(int x1, int x2);

        public int NextFicNumb(Fibonachii fibonachii)
        {
            int boof = _x2;
            _x2 = fibonachii(_x1, _x2);
            _x1 = boof;
            return _x2;
        }
    }
}
