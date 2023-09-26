/* Сатукин
 * Бельмесова 
 * ПМ-15
 * Вариант 5
 */
using System.Reflection;

public class oop
{
    static void Main(string[] args)
    {
        var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string[] linesStud = File.ReadAllLines(appDir + "\\inS.txt");
        string[] linesTeach = File.ReadAllLines(appDir + "\\inT.txt");
        int user = 0;
        string? flag;

        University myUni = new University();

        foreach (string ln in linesStud) myUni.Add(Student.Parse(ln));
        foreach (string ln in linesTeach) myUni.Add(Teacher.Parse(ln));

        while(user != 8)
        {
            Console.WriteLine("\n1 - Добавить пользователя\n2 - Удалить пользователя\n3 - Показать список всех пользователей\n4 - Показать список студентов\n5 - Показать список преподавателей\n6 - Поиск пользователей по фамилии\n7 - Поиск студентов по среднему баллу\n8 - Выход\n");
            user = int.Parse(Console.ReadLine());
            switch (user)
            {
                case 1:
                    Console.WriteLine("Выберите кого добавить (Преп/Студ)");
                    flag = Console.ReadLine();
                    Console.WriteLine("Введите параметры персоны \n");
                    if (flag == "Студ") myUni.Add(Student.Parse(Console.ReadLine()));
                    else if (flag == "Преп") myUni.Add(Teacher.Parse(Console.ReadLine()));
                    else Console.WriteLine("Такой роли нет!\n");
                    break;

                case 2:
                    Console.WriteLine("Укажите фамилию персоны которую хотите удалить\n");
                    foreach (IPerson per in myUni.FindByLastName(Console.ReadLine())) myUni.Remove(per);
                    break;

                case 3:
                    myUni.ShowAllPersons();
                    break;

                case 4:
                    myUni.ShowAllStudents();
                    break;

                case 5:
                    myUni.ShowAllTeachers();
                    break;

                case 6:
                    Console.WriteLine("Укажите фамилию персоны\n");
                    foreach (IPerson per in myUni.FindByLastName(Console.ReadLine())) Console.WriteLine(per.ToString()); 
                    break;

                case 7:
                    Console.WriteLine("Укажите средний балл\n");
                    foreach (IPerson per in myUni.FindByAvrPoint(float.Parse(Console.ReadLine()))) Console.WriteLine(per.ToString());
                    break;
                default:
                    Console.WriteLine("Нет такой команды!\n");
                    break;

            }
        }
    }
}