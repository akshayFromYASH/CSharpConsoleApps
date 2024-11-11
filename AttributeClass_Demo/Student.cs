namespace Attribute_Class_Demo
{
    [MyCustom("Akshay", 34.34)]

    internal class Student
    {

        int id;
        string name;
        char grade;

        public Student(){
            id =1;
            name = "akshay";
            grade = 'A';
        }
        public Student(int id, string name, char grade){
            this.id = id;
            this.name = name;
            this.grade = grade;

        }
        public void ShowResult()
        {
            if (this.grade == 'A')
            {
                Console.WriteLine("Student is passed with first class");
            }
            else if (this.grade == 'B')
            {
                Console.WriteLine("Student is passed with second class");
            }
            else if (this.grade == 'C')
            {
                Console.WriteLine("Student is passsed with pass class");
            }
            else if (this.grade == 'F')
            {
                Console.WriteLine("Student is fail");
            }
            else
            {
                Console.WriteLine("Please enter valid grade...");
            }
        }
    
    }

}