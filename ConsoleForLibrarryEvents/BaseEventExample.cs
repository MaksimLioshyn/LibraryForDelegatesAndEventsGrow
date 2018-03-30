namespace ConsoleForLibrarryEvents
{
    public class BaseEventExample
    {
        public event EventDelegate myEvent = null;

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }
}
