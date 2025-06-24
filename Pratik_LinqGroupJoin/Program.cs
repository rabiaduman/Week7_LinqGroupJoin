using Pratik_LinqGroupJoin;

List<Student> students = new List<Student>()
{
    new Student{ StudentId = 1, StudentName = "Ali", ClassId = 1 },
    new Student{ StudentId = 2, StudentName = "Ayşe", ClassId= 2 },
    new Student{ StudentId = 3, StudentName = "Mehmet", ClassId = 1},
    new Student{ StudentId = 4, StudentName = "Fatma", ClassId = 3},
    new Student{ StudentId = 5, StudentName = "Ahmet", ClassId = 2}
};

List<Class> classes = new List<Class>()
{
    new Class{ ClassId = 1, ClassName = "Matematik"},
    new Class{ ClassId = 2, ClassName = "Türkçe" },
    new Class{ ClassId = 3, ClassName = "Kimya"}
};

var classStudentGroups = from cls in classes
                         join std in students
                         on cls.ClassId equals std.ClassId into studentGroup
                         select new
                         {
                             ClassName = cls.ClassName,
                             Students = studentGroup
                         };

foreach (var group in classStudentGroups)
{
    Console.WriteLine("\nSınıf: " + group.ClassName);

    foreach (var student in group.Students)
    {
        Console.WriteLine("Öğrenci: " + student.StudentName);
    }

}

// Method Syntax ile Group Join:

//var classStudentGroups = classes
//    .GroupJoin(
//        students,              
//        cls => cls.ClassId,               
//        std => std.ClassId,               
//        (cls, studentGroup) => new        
//        {
//            ClassName = cls.ClassName,
//            Students = studentGroup
//        });