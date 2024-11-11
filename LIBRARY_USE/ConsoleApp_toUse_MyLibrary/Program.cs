// See https://aka.ms/new-console-template for more information
using MyLibrary;
using CurrencyLib;
namespace ConsoleApp_toUse_MyLibrary{
    public class Program{
        static void Main(string[] args){
        
            MyMath.Add();
            MyMath.Substract();
            MyMath.Multiply();
            MyMath.Division();

            CurrencyConvert convert = new();

            convert.ConvertINRtoUSD(23);
            convert.ConvertINRtoEUR(12);

        }
    }
}
