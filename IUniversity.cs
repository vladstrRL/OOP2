internal interface IUniversity
{
    List<IPerson> Persons { get; }
    List<Student> Students { get; }
    List<Teacher> Teachers { get; }

    void Add(IPerson person);
    void Remove(IPerson person);

    IEnumerable<IPerson> FindByLastName(string lastName);
    IEnumerable<Student> FindByAvrPoint(float avrPoint);
}
