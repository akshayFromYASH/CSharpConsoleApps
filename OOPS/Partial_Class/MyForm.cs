// Partial Class ==> - There can be Two classes with same name in Different files
                //   - Both should have same access modifiers
                //   - A single partial method in class makes the class partial
                //   - Used when there are large number of methods in a class 


// Partial Method ==> - Declare the partial method like abstract method in one file eg. public partial void Greet(string s);
                //  - Greet(string s) will be implemented or its body will be declared in another file



namespace Partial_Class_Partial_Method_Demo
{
    internal partial class MyForm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public partial void Greet(string s);
    }
}