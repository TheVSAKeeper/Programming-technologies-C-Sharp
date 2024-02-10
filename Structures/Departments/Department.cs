namespace Structures.Departments
{
    internal struct Department
    {
        public Department(string name, string headFullName, int teachersCount, string address)
        {
            Name = name;
            HeadFullName = headFullName;
            TeachersCount = teachersCount;
            Address = address;
        }

        public string Name { get; }
        public string HeadFullName { get; }
        public int TeachersCount { get; }
        public string Address { get; }
    }
}