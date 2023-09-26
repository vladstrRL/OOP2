public class Teacher : IPerson
{
    public string Name { get; init; }
    public string Patronomic { get; init; }
    public string Lastname { get; init; }
    public enum Post {Post0, Post1, Post2, Post3}
    public DateTime Date { get; init; }
    public int Age { get {return DateTime.Now.Month < Date.Month ? DateTime.Now.Year - Date.Year - 1 : DateTime.Now.Year - Date.Year; } } 
    public string Department { get; init; }
    public int Experience { get; init; }

    private Post _post;

    public Teacher(string name, string lastName, string datronomic, DateTime date, string department, int experience,  Post post)
    {
        Name = name;
        Patronomic = datronomic;
        Lastname = lastName;
        Date = date;
        Department = department;
        Experience = experience;
        _post = post;
    }

    public override string ToString()
    {
        return $"First Name: {Name}\nLast Name : {Lastname}\nMiddle Name: {Patronomic}\nExperience: {Experience}\nDepartment: {Department}\nPost: {_post}\nDate of Birth: {Date.ToString("MM-dd-yyyy")}\nAge: {Age}\n";
    }
    public static Teacher Parse(string line)
    {
        string[] data;
        data = line.Split(" ");
        return new Teacher(data[0], data[1], data[2], Convert.ToDateTime(data[3]), data[4], int.Parse(data[5]), (Post)int.Parse(data[6]));
    }
}
