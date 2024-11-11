// See https://aka.ms/new-console-template for more information
namespace OperatorOverloading_demo{
    
    internal class Program{
        public static void Main(string[] args){

            Rational r1 = new Rational(3,2);
            Rational r2 = new Rational(4,3);
            
            Rational r3 = r1+r2;
            Rational r4 = r1-r2;
            Rational r5 = r1*r2;
            Rational r6 = r1/r2;


            System.Console.WriteLine(r3);
            System.Console.WriteLine(r4);
            System.Console.WriteLine(r5);
            System.Console.WriteLine(r6);
            
        }
    }
}
