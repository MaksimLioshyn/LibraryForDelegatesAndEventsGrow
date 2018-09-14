using ClassLibraryDelegatesForL2.Abstracts;
using ClassLibraryDelegatesForL2.Entities;
using ClassLibraryDelegatesForL2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryDelegatesForL2.Implementation
{
    public abstract class StudentServices : IUser
    {
        private List<Student> _students;
        public string Article { get; set; }

        protected StudentServices(List<Student> students)
        {
            _students = students;
        }

        public void Create() => _students.Add(new Student(null, null));

        public void Create(string firstName, string lastName) => _students.Add(new Student(firstName, lastName));

        public bool Delete(Guid id)
        {
            if (FindById(id) != default(User))
            {
                _students.Remove((Student)FindById(id));
                return true;
            }

            return false;
        }

        public User Edit(User course)
        {
            Student editStudent = _students.FirstOrDefault(u => u.Id == course.Id);
            _students.Insert(_students.FindIndex(u => u.Id == editStudent?.Id), (Student)course);
            return editStudent;
        }

        public User FindById(Guid id) => _students.FirstOrDefault(u => u.Id == id);

        public IEnumerable<User> GetAll() => _students.Select(u=>u);
    }
}
