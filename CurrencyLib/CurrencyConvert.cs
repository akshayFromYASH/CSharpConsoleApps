namespace CurrencyLib;

public class CurrencyConvert
{
    public void ConvertINRtoUSD(decimal amount){
        System.Console.WriteLine($"{amount} Rupees in USD: {amount/85.50m:c}");
    }

    public void ConvertINRtoEUR(decimal amount){
        System.Console.WriteLine($"{amount} Rupees in EUR: {amount/95.00m:f2}");
    }

}
