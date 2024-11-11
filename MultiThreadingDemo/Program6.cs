// using System.ComponentModel;

// namespace Threading{
//     internal class Program6{
//         public static void Main(string[]args){
//             BankAccount account = new BankAccount(1000.00m);
//             ParameterizedThreadStart obj = new ParameterizedThreadStart(account.Deposit);

//             Thread DepositThread = new Thread(obj);
//             DepositThread.Start(700.00m);
//             DepositThread.Join();

//             Thread WithdrawThread = new Thread(account.Withdraw);
//             WithdrawThread.Start(300.00m);
//             WithdrawThread.Join();

//             account.GetBalance();

//             Thread depositThread = new Thread(()=>{
//                 for(int i=0; i<10; i++){
//                     account.Deposit(100m);
//                     Thread.Sleep(100);
//                 }
//             });

//             Thread withdrawThread = new Thread(()=>{
//                 for(int i=0; i<10; i++){
//                     account.Withdraw(50m);
//                     Thread.Sleep(50);
//                 }
//             });

//             //start thread
//             depositThread.Start();
//             withdrawThread.Start();

//             // wait for both threads to complete
//             depositThread.Join();
//             withdrawThread.Join();

//             System.Console.WriteLine($"Final Balance : {account.GetBalance}");
//         }
//     }
// }