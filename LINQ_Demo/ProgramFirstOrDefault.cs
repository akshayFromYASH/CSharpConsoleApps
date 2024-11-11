using System.Security.Cryptography;

namespace LINQ_Demo{
    internal class ProgramFirstOrDefault{
        static void Main(string[] args){
            
            int[] numbers = {12,2,3,14,10,4,5,67,89,7,23,90,21};

            try{
                // First() ==> if it doesnt get any matching results it will throw exception
                var data = numbers.First(n=>n%7==0);        // Returns 14 Only as it is the first element in array divisible by 7
                System.Console.WriteLine(data);


                // FirstOrDefault ==> Doesnt throw exception it returns the default value for datatype
                            // - e.g for int 0, for fload and double 0.0, for string null
                var data1 = numbers.FirstOrDefault(n=>n%7==0);
                System.Console.WriteLine(data1);
            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }

            System.Console.WriteLine("------------ Boys List ----------------------------");
            var studData = Student.GetStudents().FirstOrDefault(n=>n.Gender=="Male");

            System.Console.WriteLine(studData.Name + " " + studData.Age);
        }
    }
}