namespace ConsoleForLibrarryEvents
{
    interface IInterfaceFith
    {
        event EventDelegate MyEvent;
        void InvokeEvent();
    }

    public class BaseClassFifth : IInterfaceFith
    {
        public virtual event EventDelegate MyEvent = null;

        public virtual void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }
   
    public class EventExampleWithAbstractAndVirtual : BaseClassFifth
    {
        public override event EventDelegate MyEvent = null;

        public override void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }
}
