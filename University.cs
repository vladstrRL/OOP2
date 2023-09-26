internal class University : IUniversity
{
    public List<IPerson> Persons { get; } = new List<IPerson>();
    public List<Student> Students { get; } = new List<Student>();
    public List<Teacher> Teachers { get; } = new List<Teacher>();


    public void Add(IPerson person)
    {
        if (person.GetType().ToString() == "Student") Students.Add((Student)person);
        else Teachers.Add((Teacher)person);
        Persons.Add(person);
    }

    public void Remove(IPerson person)
    {
        Persons.RemoveAt(Persons.FindIndex(per => per == person));
        if (person.GetType().ToString() == "Student") Students.RemoveAt(Students.FindIndex(stud => stud == person));
        else Teachers.RemoveAt(Teachers.FindIndex(teach => teach == person));
    }



    public IEnumerable<IPerson> FindByLastName(string lastName) => Persons.FindAll(per => per.Lastname == lastName);


    public IEnumerable<Student> FindByAvrPoint(float avrPoint) => Students.FindAll(stud => stud.AverageScore > avrPoint);

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
