namespace ConsoleForLibrarryEvents
{
    public class EventExampleWithAddRemove
    {
        EventDelegate _myEvent = null;

        public event EventDelegate MyEvent
        {
            add => _myEvent += value;
            remove => _myEvent -= value;
        }

        public void InvokeEvent()
        {
            _myEvent.Invoke();
        }
    }
}
