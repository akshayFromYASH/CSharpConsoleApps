// See https://aka.ms/new-console-template for more information
using CustomExtensionLib;
namespace Extension_Metnods_Use{
    internal class Program{
        static void Main(string[] args){
            
            string s ="The quick brown fox jumped over the lazy dog.";
            int i = s.WordCount();
            System.Console.WriteLine("Word Count in string s : "+ i);
            System.Console.WriteLine(s.ToSentenceCase());
        }
    }
}