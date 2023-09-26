using System;

public class Student : IPerson
{
    public string Name { get; init; }
    public string Patronomic { get; init; }
    public string Lastname { get; init; }
    public DateTime Date { get; }
    public int Course { get; init; }
    public string Group { get; init; }
    public float AverageScore { get; init; }
    public int Age { get { return DateTime.Now.Month < Date.Month ? DateTime.Now.Year - Date.Year - 1 : DateTime.Now.Year - Date.Year; } }


    public Student(string name, string lastName, string datronomic, DateTime date, int course, string group, float averageScore)
    {
        Name = name;
        Patronomic = datronomic;
        Lastname = lastName;
        Date = date;
        Course = course;
        Group = group;
        AverageScore = averageScore;
    }

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