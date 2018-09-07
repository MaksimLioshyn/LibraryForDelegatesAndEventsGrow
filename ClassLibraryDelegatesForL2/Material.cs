namespace ClassLibraryDelegatesForL2
{
    public class Material
    {
        public delegate void MaterialHandler(string message);
        public event MaterialHandler Removed;
        public event MaterialHandler Added;
        public string Article { get; set; }

        public Material(string article)
        {
            Article = article;
        }

        protected virtual void OnRemoved()
        {
            Removed?.Invoke($"Remove article {Article}");
        }

        protected virtual void OnAdded()
        {
            Added?.Invoke($"Add article {Article}");
        }
        
        public string Message(string message) => $"{message} {Article}";
    }
}
