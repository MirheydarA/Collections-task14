//task2

namespace Collections.task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            var student1 = new Student
            {
                Name = "dasdv",
                Surname = "Bfds",
                Pin = 1 
            };
            AddStudent(students, student1);
            

            var student2 = new Student
            {
                Name = "fagbgb",
                Surname = "Aqefwwef",
                Pin = 2
            };
            AddStudent(students, student2);

            var student3 = new Student
            {
                Name = "sadf",
                Surname = "adf",
                Pin = 3
            };
            AddStudent(students, student3);
            
            
            int count = students.Count(s => s.Name.Contains('a'));
            Console.WriteLine(count);                


            static void AddStudent(List<Student> students,  Student student) 
            {
                var IsDuplicatedPin = students.Any(s => s.Pin == student.Pin);
                if (!IsDuplicatedPin)
                {
                    students.Add(student);  
                }
            }
        }
    }
}



//task1

namespace Collections.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();

            var group1 = new Group
            {
                Name = "group1"
            };

            AddGroup(groups, group1);


            var group2 = new Group
            {
                Name = "group2"
            };
            AddGroup(groups, group2);


            
            
            static  void AddGroup(List<Group> groups, Group group) 
            {
                var isDuplicatedName = groups.Any(g => g.Name == group.Name);
               
                if (!isDuplicatedName)
                {
                    groups.Add(group);
                }
            }
        }
    }

    
}
