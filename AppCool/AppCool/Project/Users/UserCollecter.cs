using AppCool.Project.Extended;
using System;
using System.Collections.Generic;

namespace AppCool.Project.Users
{
    public class UserCollecter
    {
        private readonly SortedDictionary<uint, Student> _users;

        public UserCollecter()
        {
            _users = new SortedDictionary<uint, Student>();
        }

        public IEnumerable<Student> Users => _users.GetIEnumerable();

        public void Add(Student student)
        {
            if (_users.ContainsKey(student.Id) == true)
                throw new Exception($"{student.Id} That user has been added");

            _users.Add(student.Id, student);
        }

        public void Remove(Student student)
        {
            if (_users.ContainsKey(student.Id) == false)
                throw new Exception($"{student.Id} That user has been not added");

            _users.Remove(student.Id);
        }
    }
}
