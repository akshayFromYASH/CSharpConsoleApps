// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

namespace DelegateDemo{

    // Steps to create a delegate
    // Step 1) Declare delegate outside the class
    delegate string MyDelegate(string fname,string lname);

    delegate int MySumDel(int a, int b);

    delegate void MyMathDel(int a, int b);


    internal class Program{

        public static void Main(string[] args){
            
            // Step 2) Create instance of delegate MyDelegate
            MyDelegate obj = new MyDelegate(GetFullName);
            string ans = obj("Akshay" , "Mashale");
            System.Console.WriteLine(ans);

            // Instance of MySumDel
            MySumDel sum = new MySumDel(Sum);
            System.Console.WriteLine(Sum(34,4));

            // Instance of MyMathDel
            MyMathDel math = new MyMathDel(Add);
            math+=Sub;
            math+=Mul;
            math+=Divide;
            math.Invoke(34,4);

            // Instance of MyStringDel
            MyStringDel strDel = new MyStringDel(StringDelegates.UpperCase);
            strDel+=StringDelegates.LowerCase;
            strDel+=StringDelegates.SentenceCase;
            strDel.Invoke("hello everyOne my is tHis n this @got it ?");
        }

        public static string GetFullName(string fname, string lname){
            return fname + " " +lname;
        }

        // UniCast delegate points to only one function
        public static int Sum(int a, int b){
            return a+b;
        }

        // Multi-Cast delegate ==> - single delegate points to multiple functions 
                                // - void is return type of multi cast delegate
                                
        public static void Add(int a, int b){
            System.Console.WriteLine(a+b);
        }
        public static void Sub(int a, int b){
            System.Console.WriteLine(a-b);
        }
        public static void Mul(int a, int b){
            System.Console.WriteLine(a*b);
        }
        public static void Divide(int a, int b){
            System.Console.WriteLine(a/b);
        }

    }
}
