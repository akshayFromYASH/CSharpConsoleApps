namespace Delegat_For_EventHandling{

    // Declaring multi-cast delegate
    delegate void MarkDel();

    internal class Student{
        public int Id { get; set; }

        public string Name { get; set; }

        public int Marks { get; set; }

        // Declaring events ==> We assign fucntions to each event in Main() 
        public event MarkDel Pass;
        public event MarkDel Fail;

        // 
        public void EnterMarks(int marks){
            if(marks>=50){
                Pass();
            }else{
                Fail();
            }
        }
    }
}