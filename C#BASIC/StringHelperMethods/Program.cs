// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace StringHelper_Demo{
    internal class StringHelper{
        public static void Main(){

            // string str = "Hello World!";
            // string str1 = "Good Night!";

            // // Length ==> Returns length of string str
            // System.Console.WriteLine(str.Length);

            // // Substring() ==> Returns the 3rd to 8th element of string str
            // System.Console.WriteLine(str.Substring(3,8));

            // // IndexOf() ==> Returns the index of first occurence of the character
            // System.Console.WriteLine(str.IndexOf('o'));

            // // LastIndexOf() ==> Returns the index of last occurance of the character
            // System.Console.WriteLine(str.LastIndexOf('o'));

            // // Replace() ==> Replaces first arguement with second arguement in str
            // System.Console.WriteLine(str.Replace("Hello","Bye"));

            // // Contains() ==> Returns boolean value if str contains the arguement
            // System.Console.WriteLine(str.Contains("by"));

            // // StartWith() ==> Returns boolean value if string str starts with arguement passed
            // System.Console.WriteLine(str.StartsWith("Ello"));

            // // EndsWith() ==> Returns boolean value if string str ends with arugement passed
            // System.Console.WriteLine(str.EndsWith("!"));

            // // Trim() ==> Removes all the white spaces at start and end of string
            // System.Console.WriteLine(str.Trim());

            // // TrimStart() ==> Removes white spaces at start of string
            // System.Console.WriteLine(str.TrimStart());

            // // TrimEnd() ==> Removes white spaces at the end of string
            // System.Console.WriteLine(str.TrimEnd());

            // // ToUpper() ==> Convert complete string to upper case
            // System.Console.WriteLine(str.ToUpper());

            // // ToLower() ==> Convert complete string to lower case 
            // System.Console.WriteLine(str.ToLower());

            // // Split() ==> Creates an array by splitting string into array elements based on the arugement character
            // System.Console.WriteLine(str.Split(" "));

            // // Join() ==> Join two strings
            // System.Console.WriteLine(string.Join(str,str1));

            string str2 = "Good Morning! My name #is#akshay i am from #Solapur #Maharastra";

            string[] strSplit = str2.Split(" ");

            foreach(string st in strSplit){
                System.Console.WriteLine(st);
            }

            System.Console.WriteLine();

            System.Console.WriteLine("........ Hashtags in the string .............");

            foreach(string st in strSplit){
                if(st.Contains("#")){
                    string[] tags = st.Split("#");
                    
                    foreach(string tag in tags){
                        System.Console.WriteLine("#" + tag);
                    }     
                }
            }

            

        }
    }
}
