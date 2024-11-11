namespace MyLibrary{
public class Student{
        public int StudId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Marks { get; set; }

        public Student()
        {
            StudId = 101;
            FName = "Akshay";
            LName = "Mashale";
            Marks = 12;
        }

        public Student(int Id, string fName, string lName, int marks){
            this.FName = fName;
            this.StudId = Id;
            this.LName = lName;
            this.Marks = marks;
        }

        public void display(){
            System.Console.WriteLine($"Student Details {StudId} {FName} {LName} {Marks}");
        }
    }
}