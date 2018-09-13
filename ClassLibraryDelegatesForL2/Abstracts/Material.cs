using System;

namespace ClassLibraryDelegatesForL2.Abstracts
{
    public abstract class Material
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Article { get; }
        public string Body { get; set; }
        public User Author { get; set; }

        protected Material(string article)
        {
            Article = article;
        }
    }
}
