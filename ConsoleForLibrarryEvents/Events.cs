using System;

namespace ConsoleForLibrarryEvents
{
    public delegate void EventDelegate();
    public delegate void PressKeyEventHandler();
    class Events
    {
        #region Handlers

        private static void Handler1() => Console.WriteLine("Use event 1");

        private static void Handler2() => Console.WriteLine("Use event 2");

        private static void PressKeyAHandler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("    X    ");
            Console.WriteLine("   X X   ");
            Console.WriteLine("  X   X  ");
            Console.WriteLine(" XXXXXXX ");
            Console.WriteLine("X       X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static void PressKeyBHandler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("XXXXX  ");
            Console.WriteLine("X    X ");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine("X     X");
            Console.WriteLine("XXXXXX ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        #endregion

        static void Main(string[] args)
        {
            #region first

            BaseEventExample baseEventExample = new BaseEventExample();

            baseEventExample.myEvent += Handler1;
            baseEventExample.myEvent += Handler2;

            baseEventExample.InvokeEvent();
            Console.WriteLine(new string('-', 20));

            baseEventExample.myEvent -= Handler2;

            baseEventExample.InvokeEvent();

            #endregion

            Console.WriteLine(new string('*', 20));

            #region second

            EventExampleWithAddRemove eventExampleWithAddRemove = new EventExampleWithAddRemove();

            eventExampleWithAddRemove.MyEvent += Handler1;
            eventExampleWithAddRemove.MyEvent += Handler2;

            eventExampleWithAddRemove.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            eventExampleWithAddRemove.MyEvent -= Handler2;
            eventExampleWithAddRemove.InvokeEvent();

            #endregion

            Console.WriteLine(new string('*', 20));

            #region fird

            Keyboard keyboard = new Keyboard();

            keyboard.PressKeyA += PressKeyAHandler;
            keyboard.PressKeyB += PressKeyBHandler;

            keyboard.Start();

            #endregion

            Console.WriteLine(new string('*', 20));

            #region fourth

            EventExampleWithVirtual eventExampleWithVirtual = new EventExampleWithVirtual();

            eventExampleWithVirtual.SomeEvent += Handler1;
            eventExampleWithVirtual.SomeEvent += Handler2;

            eventExampleWithVirtual.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            eventExampleWithVirtual.SomeEvent -= Handler2;
            eventExampleWithVirtual.InvokeEvent();

            #endregion

            Console.WriteLine(new string('*', 20));

            #region fourth

            EventExampleWithAbstractAndVirtual eventExampleWithAbstractAndVirtual = new EventExampleWithAbstractAndVirtual();

            eventExampleWithAbstractAndVirtual.MyEvent += Handler1;
            eventExampleWithAbstractAndVirtual.MyEvent += Handler2;

            eventExampleWithAbstractAndVirtual.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            eventExampleWithAbstractAndVirtual.MyEvent -= Handler2;
            eventExampleWithAbstractAndVirtual.InvokeEvent();

            #endregion

            Console.WriteLine(new string('*', 20));

            #region sixth

            BaseEventExample instance = new BaseEventExample();
            instance.myEvent += new EventDelegate(Handler1);
            instance.myEvent += new EventDelegate(Handler2);
            instance.myEvent += delegate { Console.WriteLine("Anonim 1."); };

            instance.InvokeEvent();

            Console.WriteLine(new string('-', 20));

            // Открепляем Handler2().
            instance.myEvent -= new EventDelegate(Handler2);

            // Невозможно открепить ранее присоединенный анонимный метод.
            instance.myEvent -= delegate { Console.WriteLine("Anonim 1."); };

            instance.InvokeEvent();
            #endregion

            Console.ReadKey();
        }
    }
}
