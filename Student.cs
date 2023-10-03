public record Student(string Name,string Lastname, string Patronomic,DateTime Date,int Course,string Group,float AverageScore) : IPerson
{
    public int Age { get { return DateTime.Now.Month < Date.Month ? DateTime.Now.Year - Date.Year - 1 : DateTime.Now.Year - Date.Year; } }
    public override string ToString()
    {
        return $"First Name: {Name} \nLast Name : {Lastname}\nMiddle Name: {Patronomic}\nCourse: {Course}\nGroup: {Group}\nAverageScore: {AverageScore}\nDate of Birth: {Date.ToString("MM-dd-yyyy")}\nAge: {Age}\n";
    }
    public static Student Parse(string line)
    {
        string[] data;
        data = line.Split(" ");
        return new Student(data[0], data[1], data[2], Convert.ToDateTime(data[3]), int.Parse(data[4]), data[5], float.Parse(data[6]));
    }
}