namespace Collections_Demo{
    internal class Student{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        // public Student(int id, string name, int marks){
        //     Id = id;
        //     Name = name;
        //     Marks = marks;
        // }

        // public Student()
        // {
            
        // }

        public override string ToString(){
            return $"Student Details: {Id} {Name} {Marks}";
        }

        public int CompareTo(object? obj){
            Student s1 = obj as Student;

            return string.Compare(Name,s1.Name);
        }
    }
}