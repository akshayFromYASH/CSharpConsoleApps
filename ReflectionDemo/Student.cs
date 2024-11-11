namespace ReflectionDemo{
    public class Student{
        private int Marks;

        public Student(int marks){
            Marks = marks;
            // System.Console.WriteLine("called");
        }
        public void GetResult(){
             if(Marks>=40){
                System.Console.WriteLine($"Marks: {Marks} ======> Pass");
            }else{
                System.Console.WriteLine($"Marks: {Marks} ======> Fail");              
            }
        }
        
    }
}