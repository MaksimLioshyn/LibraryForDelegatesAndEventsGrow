using ClassLibraryDelegatesForL2.Entities;
using ClassLibraryDelegatesForL2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibraryDelegatesForL2.Implementation
{
    public class CourseServices: ICourse
    {
        private List<Course> _courses;

        public CourseServices(List<Course> courses)
        {
            _courses = courses;
        }

        public void Create() => _courses.Add(new Course(null));
        public void Create(string name)=> _courses.Add(new Course(name));
        
        public bool Delete(Guid id)
        {
            if (FindById(id) != default(Course))
            {
                _courses.Remove(FindById(id));
                return true;
            }

            return false;
        }

        public Course Edit(Course course)
        {
            Course editStudent = _courses.FirstOrDefault(u => u.Id == course.Id);
            _courses.Insert(_courses.FindIndex(u => u.Id == editStudent?.Id), (Course)course);
            return editStudent;
        }

        public Course FindById(Guid id) => _courses.FirstOrDefault(u => u.Id == id);

        public IEnumerable<Course> GetAll() => _courses.Select(u => u);
    }
}
