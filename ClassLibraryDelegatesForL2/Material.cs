namespace ClassLibraryDelegatesForL2
{
    public class Material
    {
        public delegate void MaterialHandler(string message);
        public event MaterialHandler Removed;
        public event MaterialHandler Added;

        public string Title { get; private set; }

        public Material(string title)
        {
            Title = title;
        }
        
        protected virtual void OnRemoved(string title)
        {
            Removed?.Invoke(title);
        }

        protected virtual void OnAdded(string article)
        {
            Added?.Invoke(article);
        }
    }
}
