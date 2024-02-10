using System;

namespace Structures.Employees
{
    internal struct Employee
    {
        public Employee(string fullName, string post, DateTime birthDate, string academicDegree, int workExperience)
        {
            FullName = fullName.Trim();
            Post = post;
            BirthDate = birthDate;
            AcademicDegree = academicDegree;
            WorkExperience = workExperience;
        }

        public string FullName { get; }
        public string Post { get; }
        public DateTime BirthDate { get; }
        public string AcademicDegree { get; }
        public int WorkExperience { get; }
    }
}