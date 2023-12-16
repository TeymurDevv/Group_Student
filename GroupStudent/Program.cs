using GroupStudent.Models;
Student student = new("Teymur", "Suleymanov", 15, 90);
Student student2 = new("Teymur", "Suleymanov", 15, 25);
Group group = new(15);
group.AddStudent(student);
group.AddStudent(student2);
List<Student> slist = group.Sort();
foreach (var item in slist)
{
    Console.WriteLine(item);
}
Console.WriteLine(group.FindStudentById(2));