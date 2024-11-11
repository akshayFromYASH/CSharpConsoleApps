using System.Security.Cryptography.X509Certificates;

namespace DelegateDemo{
    // Declaring delegate with same return type as eventhandler / function
    
    delegate void MyStringDel(string str);
    public class StringDelegates
    {
        public static void UpperCase(string str){
            System.Console.WriteLine(str.ToUpper());
        }

        public static void LowerCase(string str){
            System.Console.WriteLine(str.ToLower());
        }


        // string ==> hello world
        public static void SentenceCase(string str){
            string[] str1 = str.Split(" ");         // [hello,world]

            for(int i=0; i<str1.Length;i++){
                str1[i] = str1[i].Substring(0,1).ToUpper() + str1[i].Substring(1);      // "H" + "ello" and "W" + "orld"
            }

            str = string.Join(" ",str1);        // "Hello" + "World"
            System.Console.WriteLine(str);                // Hello World
        }
    }
}