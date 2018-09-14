using ClassLibraryDelegatesForL2.Abstracts;
using ClassLibraryDelegatesForL2.Entities;
using ClassLibraryDelegatesForL2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryDelegatesForL2.Implementation
{
    public class StudentMaterialServices: IMaterial
    {
        private List<Material> _materials;
        public string Article { get; set; }

        protected StudentMaterialServices(List<Material> materials)
        {
            _materials = materials;
        }

        public void Create() => _materials.Add(new StudentMaterial());

        public void Create(string name) => _materials.Add(new StudentMaterial(name));

        public bool Delete(Guid id)
        {
            if (FindById(id) != default(Material))
            {
                _materials.Remove(FindById(id));
                return true;
            }

            return false;
        }

        public Material Edit(Material course)
        {
            Material editStudent = _materials.FirstOrDefault(u => u.Id == course.Id);
            _materials.Insert(_materials.FindIndex(u => u.Id == editStudent?.Id), (Material)course);
            return editStudent;
        }

        public Material FindById(Guid id) => _materials.FirstOrDefault(u => u.Id == id);

        public IEnumerable<Material> GetAll() => _materials.Select(u => u);
    }
}
