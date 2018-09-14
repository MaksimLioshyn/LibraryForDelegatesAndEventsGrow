using ClassLibraryDelegatesForL2.Abstracts;
using ClassLibraryDelegatesForL2.Entities;
using ClassLibraryDelegatesForL2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryDelegatesForL2.Implementation
{
    public class TeacherServices: IUser
    {
        private List<Teacher> _teachers;

        public string Article { get; set; }

        protected TeacherServices(List<Teacher> teachers)
        {
            _teachers = teachers;
        }

        public void Create() => _teachers.Add(new Teacher(null, null));

        public void Create(string firstName, string lastName) => _teachers.Add(new Teacher(firstName, lastName));

        public bool Delete(Guid id)
        {
            if (FindById(id) != default(User))
            {
                _teachers.Remove((Teacher)FindById(id));
                return true;
            }

            return false;
        }

        public User Edit(User teacher)
        {
            Teacher editStudent = _teachers.FirstOrDefault(u => u.Id == teacher.Id);
            _teachers.Insert(_teachers.FindIndex(u => u.Id == editStudent?.Id), (Teacher)teacher);
            return editStudent;
        }

        public User FindById(Guid id) => _teachers.FirstOrDefault(u => u.Id == id);

        public IEnumerable<User> GetAll() => _teachers.Select(u => u);
    }
}
