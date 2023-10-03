public record Teacher(string Name, string Lastname, string Patronomic, DateTime Date, string Department, int Experience, string post) : IPerson
{
    public enum EnumPost { Post0, Post1, Post2, Post3 }
    private EnumPost Post { get { return (EnumPost)Enum.Parse(typeof(EnumPost), post.ToString());} }
    public int Age { get { return DateTime.Now.Month < Date.Month ? DateTime.Now.Year - Date.Year - 1 : DateTime.Now.Year - Date.Year; } }

    public override string ToString()
    {
        return $"First Name: {Name}\nLast Name : {Lastname}\nMiddle Name: {Patronomic}\nExperience: {Experience}\nDepartment: {Department}\nPost: {Post}\nDate of Birth: {Date.ToString("MM-dd-yyyy")}\nAge: {Age}\n";
    }
    public static Teacher Parse(string line)
    {
        string[] data;
        data = line.Split(" ");
        return new Teacher(data[0], data[1], data[2], Convert.ToDateTime(data[3]), data[4], int.Parse(data[5]), data[6]);
    }
}
