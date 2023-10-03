internal class University : IUniversity
{
    public List<IPerson> _persons { get; } = new List<IPerson>();

    public IEnumerable<IPerson> Persons => _persons;
    public IEnumerable<Student> Students => Persons.OfType<Student>();
    public IEnumerable<Teacher> Teachers => Persons.OfType<Teacher>();

    public void Add(IPerson person) => _persons.Add(person);

    public void Remove(IPerson person) => _persons.RemoveAt(_persons.FindIndex(per => per == person));

    public IEnumerable<IPerson> FindByLastName(string lastName) => _persons.FindAll(per => per.Lastname == lastName);

    public IEnumerable<Student> FindByAvrPoint(float avrPoint) => Students.Where(stud => stud.AverageScore > avrPoint);

    public void ShowAllPersons()
    {
        foreach (IPerson per in Persons.OrderBy(obj => obj.Lastname).ToArray()) Console.WriteLine(per.ToString());
    }

    public void ShowAllStudents()
    {
        foreach (Student stud in Students.OrderBy(obj => obj.Lastname).ToArray()) Console.WriteLine(stud.ToString());
    }
    public void ShowAllTeachers()
    {
        foreach (Teacher teach in Teachers.OrderBy(obj => obj.Lastname).ToArray()) Console.WriteLine(teach.ToString());
    }

}
