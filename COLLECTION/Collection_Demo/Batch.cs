using System.Collections;

namespace Collections_Demo{
    internal class Batch:IEnumerable{
        // public int BatchId { get; set; }
        Student[] studList = new Student[4];
        
        public Batch(){
            // BatchId = 1;
            studList = new Student[4];

            {
                studList[0] = new Student(){Id = 1, Name = "Akshay", Marks= 89};
                studList[1] = new Student(){Id = 2, Name = "Akshay", Marks= 89};
                studList[2] = new Student(){Id = 3, Name = "Akshay", Marks= 89};
                studList[3] = new Student(){Id = 4, Name = "Akshay", Marks= 89};
            }
        }

        // IEnumerator is a interface which inherits the IEnumerable interface
        public IEnumerator GetEnumerator(){
            foreach(Student student in studList){
                {yield return student;}                     // yield is a keyword which helps while returning the array
            }
        }
    }
}