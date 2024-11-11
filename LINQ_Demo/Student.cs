namespace LINQ_Demo{
    public class Student{
        public  int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }

        public static List<Student> GetStudents(){

            List<Student> students = new List<Student>(){
                new Student{ID=101,Name="Prathmesh",Gender="Male",Branch="CSE",Age=22},
                new Student{ID=102,Name="Akshay",Gender="Male",Branch="CSE",Age=21},
                new Student{ID=103,Name="Pretty",Gender="Female",Branch="Electric",Age=20},
                new Student{ID=104,Name="Vishal",Gender="Male",Branch="AIDS",Age=23},
                new Student{ID=105,Name="Hina",Gender="Female",Branch="CSE",Age=22},
                new Student{ID=106,Name="Rohan",Gender="Male",Branch="Civil",Age=24}, 
                new Student{ID=101,Name="Meena",Gender="Female",Branch="ENTC",Age=20},
            };

            return students;
        }
    }
}