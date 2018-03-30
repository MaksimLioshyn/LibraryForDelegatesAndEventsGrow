using System;

namespace ConsoleForLibrarryEvents
{
    interface IInterface
    {
        event EventDelegate SomeEvent; 
    }

    public class BaseClass : IInterface
    {
        EventDelegate myEvent = null;

        public virtual event EventDelegate SomeEvent 
        {
            add => myEvent += value;
            remove => myEvent -= value;
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    public class EventExampleWithVirtual : BaseClass
    {
        public override event EventDelegate SomeEvent
        {
            add
            {
                base.SomeEvent += value;
                Console.WriteLine($"Add event - {value.Method.Name}");
            }
            remove
            {
                base.SomeEvent -= value;
                Console.WriteLine($"Remove event - {value.Method.Name}");
            }
        }
    }
}
