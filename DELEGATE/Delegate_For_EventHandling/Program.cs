// See https://aka.ms/new-console-template for more information
namespace Delegat_For_EventHandling{
    public class Program{
        public static void Main(string[]args){
            Student s1 = new Student(){Id=1,Name = "Mr.Bill"};
            TimeNow t1 = new TimeNow();
            // Assigning methods to each event
            s1.Pass += new MarkDel(ShowMessage.ShowGoodMsg);
            s1.Fail += new MarkDel(ShowMessage.ShowBadMsg);

            s1.EnterMarks(56);

            t1.Morning += new GreetDel(ShowGreetings.GoodMorning);
            t1.AfterNoon += new GreetDel(ShowGreetings.GoodAfternoon);
            t1.Evening += new GreetDel(ShowGreetings.GoodEvening);
            t1.Night += new GreetDel(ShowGreetings.GoodNight);

            t1.EnterTime(24);
            t1.LiveTime();
        }
    }
}
