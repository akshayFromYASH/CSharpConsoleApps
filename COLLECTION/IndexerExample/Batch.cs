using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace IndexerDemo{
    internal class Batch{
        
        // Generic List collection which stores the Student type value in StudetList
        List<Student> StudentList = new List<Student>();
        List<Employee> EmpList = new List<Employee>();
        public Batch()
        {
            // StudentList = new List<Student>();
            StudentList.Add(new Student(){Id=101, Name="Akshay",Gender="Male"});
            StudentList.Add(new Student(){Id=102, Name="Ajay",Gender="Male"});
            StudentList.Add(new Student(){Id=103, Name="Rahul",Gender="Male"});
            StudentList.Add(new Student(){Id=104, Name="PJ",Gender="Male"});
            StudentList.Add(new Student(){Id=105, Name="Vishal",Gender="Male"});
        }

        public void AddEmployee(int empid, string name, decimal sal){
            
        }

        // indexer with  get Id and send Name of student
        public string this[int id]{
            get{
                return StudentList.FirstOrDefault(x =>x.Id==id).Name;
            }
            set{
                StudentList.FirstOrDefault(x => x.Id == id).Name = value;
            }
        }

        public int this[string str]{
            get{
            return StudentList.FirstOrDefault(x=> x.Name.ToLower() == str.ToLower()).Id;
        }
        }   


    }
}