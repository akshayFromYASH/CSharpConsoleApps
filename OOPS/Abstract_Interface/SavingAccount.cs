namespace Abstract_Interface{
    internal class SavingAccount:Account{
        public float InterestRate { get; set; }
        public decimal Balance { get; set; }
        
        // public SavingAccount(){
        //     InterestRate = 8.5f;
        // }

        public SavingAccount(float intRate, decimal balance,int accId,Customer cust):base(accId,cust){
            InterestRate = intRate;
            Balance = balance;
        }

        public override void ShowBalance(){
            System.Console.WriteLine($"Saving Account Balance: {Balance}");
        }

        public override string ToString(){
            return $"Saving Account Details:{AccountId} {InterestRate} {Balance} {base.ToString()}";
        }

    }
}