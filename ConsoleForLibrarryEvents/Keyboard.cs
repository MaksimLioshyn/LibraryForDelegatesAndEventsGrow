using System;

namespace ConsoleForLibrarryEvents
{
    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyB = null;

        public void PressKeyAEvent()
        {
            PressKeyA?.Invoke(); 
        }

        public void PressKeyBEvent()
        {
            PressKeyB?.Invoke();
        }

        public void Start()
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine("'exit' for exit, letter");
                string s = Console.ReadLine();

                switch (s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent();
                        break;
                    case "b":
                    case "B":
                        PressKeyBEvent();
                        break;
                    case "exit":
                        start = false;
                        break;

                    default:
                        Console.WriteLine($"No event {s}");
                        break;
                }
            }
            Console.WriteLine("Exit!");
        }
    }
}
