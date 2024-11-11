// See https://aka.ms/new-console-template for more information
using System.Text;
namespace ExceptionHandling
{
    internal class Program
    {

        public static void f1()
        {
            f2();
        }

        public static void f2()
        {
            f3();
        }

        public static void f3()
        {
            int a, b, c;

            try
            {
                System.Console.WriteLine("Enter a number: ");
                a = Convert.ToInt32(System.Console.ReadLine());

                System.Console.WriteLine("Enter a number: ");
                b = Convert.ToInt32(System.Console.ReadLine());

                c = a / b;
                System.Console.WriteLine($"{a}/{b} = {c}");
            }

            // catch(FormatException e){
            //     System.Console.WriteLine(e.Message);
            // }

            // catch(OverflowException e){
            //     System.Console.WriteLine(e.Message);
            // }

            catch (Exception e)
            {
                System.Console.WriteLine("Message: " + e.Message);
                System.Console.WriteLine("Source: " + e.Source);
                System.Console.WriteLine("Stack Trace: " + e.StackTrace);
                System.Console.WriteLine("Target Site: " + e.TargetSite);
            }

            finally
            {
                System.Console.WriteLine("Tata Bye Bye");
            }

        }

        static void Main(string[] args)
        {

            // f1();

            // int tickeno;

            // try
            // {
            //     System.Console.WriteLine("Entet Ticket Number: ");
            //     tickeno = Convert.ToInt32(Console.ReadLine());

            //     if (tickeno > 50)
            //     {
            //         throw new CustomException("Ticket Number not available");
            //     }
            //     else
            //         System.Console.WriteLine("Your Ticket has been booked successfully");
            // }
            // catch (CustomException ex)
            // {
            //     System.Console.WriteLine(ex.Message);
            // }

            string Message = null;
            //Outer Try
            string path = Directory.GetCurrentDirectory();
            try
            {
                int FirstNumber, SecondNumber, Result;
                //Inner Try
                try
                {
                    //Make sure to Cause Exception in the Try Block
                    Console.WriteLine("Enter First Number:");
                    FirstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number:");
                    SecondNumber = Convert.ToInt32(Console.ReadLine());

                    Result = FirstNumber / SecondNumber;
                    Console.WriteLine($"Result = {Result}");
                }
                //Inner Catch
                catch (Exception ex)
                {
                    //Make sure this Path Does Not Exist
                    string filePath = @"D:\Projects\LogFile\Log.txt";
                    //   string filePath = path + "\\Log.txt";
                    if (File.Exists(filePath))
                    {
                        File.WriteAllText(filePath, ex.Message);
                        StringBuilder stringBuilder = new StringBuilder();
                        //stringBuilder.Append($"Message: {ex.Message} \n");
                        //stringBuilder.Append($"Source: {ex.Source} \n");
                        //stringBuilder.Append($"HelpLink: {ex.HelpLink} \n");
                        //stringBuilder.Append($"StackTrace: {ex.StackTrace} \n");
                        //stringBuilder.Append($"GetType(): {ex.GetType()} \n");
                        //stringBuilder.Append($"GetType().Name: {ex.GetType().Name} \n");

                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(stringBuilder.ToString());
                        streamWriter.Close();
                        Console.WriteLine("There is a Problem! Please Try Later");
                    }
                    else
                    {
                        //To retain the Original Exception pass, this exceptiopm as a parameter
                        //to the constructor of the current exception
                        Message = filePath + " Does Not Exist";
                        throw new FileNotFoundException(Message, ex);
                    }
                }
            }
            //Outer Catch
            catch (Exception exception)
            {
                //exception.Message will give the current exception message
                //i.e. Message about File Not Found Exception
                Console.WriteLine("\nCurrent Exception Details: ");


                //Check if InnerException is not null before accessing the InnerException properties
                ////else, you may get Null Reference Exception
                if (exception.InnerException != null)
                {
                    Console.WriteLine("\nInner Exception Details: " + Message);
                    Console.WriteLine($"Inner Exception Message: {exception.InnerException.Message}");
                    Console.WriteLine($"Inner Exception Source: {exception.InnerException.Source}");
                    Console.WriteLine($"Inner Exception StackTrace: {exception.InnerException.StackTrace}");
                }
            }
            Console.WriteLine("Main Method End");
            Console.ReadLine();
        }
    }
}
