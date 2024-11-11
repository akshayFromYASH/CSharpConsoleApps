namespace Partial_Class_Partial_Method_Demo
{
    internal partial class MyForm
    {
        public partial void Greet(string s)
        {
            System.Console.WriteLine($"Greetings: {Name} {Description} for this great Event of....{s}");
        }
    }
}