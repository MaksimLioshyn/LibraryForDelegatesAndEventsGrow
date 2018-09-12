using System;
using System.Collections.Generic;
using ClassLibraryDelegatesForL2.Abstracts;

namespace ClassLibraryDelegatesForL2.Entities
{
    public enum Roles
    {
        Teacher,
        Student
    }


    public class Course
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string NameCourse { get; }
        public Dictionary<Material, User> Materials { get; } = new Dictionary<Material, User>();
        public Dictionary<User, Roles> Users { get; set; } = new Dictionary<User, Roles>();

        public Course(string nameCourse)
        {
            NameCourse = nameCourse;
        }
    }
}
