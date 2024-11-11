namespace MyLibrary;

public class MyMath{
        public static int a;
        public static int b;
        public static int c;

        static MyMath(){
            a=200;
            b=100;
            System.Console.WriteLine("Static constructor executed");
        }
        
        public static void Add(){
            c=a+b;
            System.Console.WriteLine($"Addition = {c}");
        }

        public static void Substract(){
            c=a-b;
            System.Console.WriteLine($"Substraction = {c}");
        }

        public static void Multiply(){
            c=a*b;
            System.Console.WriteLine($"Multiplication = {c}");
        }

        public static void Division(){
            c=a/b;
            System.Console.WriteLine($"Division = {c}");
        }


    }
