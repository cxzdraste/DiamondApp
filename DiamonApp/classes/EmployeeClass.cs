using System;
using DiamonApp.Enums;
using DiamonApp.Hash;

namespace DiamonApp.Classes
{
    public class EmployeeClass
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public JobsEnumcs Job { get; set; }
        public EmployeeClass(string name, string surname, string login, string password, JobsEnumcs job ) 
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Login = login;
            Password = SimpleHash.HashSHA256(password);
            Job = job;
        }
    }
}
