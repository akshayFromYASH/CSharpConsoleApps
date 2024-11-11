namespace Threading
{
    internal class Program3
    {
        // static void Main(string[] args)
        // {
        //     Thread T = Thread.CurrentThread;
        //     T.Name = "Main Thread";
        //     System.Console.WriteLine("Main Thread is starting");

        //     Numbers num = new Numbers();

        //     Thread t1 = new Thread(num.Display1to10);
        //     Thread t2 = new Thread(num.Display10to100);
        //     Thread t3 = new Thread(num.Display100to1000);

        //     t1.Name = "thread1";
        //     t1.Start();
        //     t2.Start();
        //     t3.Start();

        //     t1.Join();
        //     t2.Join();
        //     t3.Join();


        //     System.Console.WriteLine("Main thread is ending");
        //     T.Start();
        // }
    }
    internal class Numbers
    {
        public void Display1to10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("Method1: " + i);
            }
        }

        public void Display10to100()
        {
            for (int i = 10; i <= 20; i += 10)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("Method2: " + i);
            }
        }

        public void Display100to1000()
        {
            for (int i = 100; i <= 1000; i += 100)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("Method3: " + i);
            }
        }
    }
}
