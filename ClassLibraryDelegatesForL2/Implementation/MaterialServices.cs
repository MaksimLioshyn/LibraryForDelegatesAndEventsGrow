using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDelegatesForL2.Abstracts;
using ClassLibraryDelegatesForL2.Interfaces;

namespace ClassLibraryDelegatesForL2.Implementation
{
    public class MaterialServices: IMaterial
    {
        public delegate void MaterialHandler(string message);
        public event MaterialHandler Removed;
        public event MaterialHandler Added;
        public string Article { get; set; }

        protected MaterialServices(string article)
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
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Material Edit(Guid id)
        {
            throw new NotImplementedException();
        }

        public Material FindMaterialById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
