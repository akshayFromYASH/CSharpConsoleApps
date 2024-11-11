namespace Delegat_For_EventHandling{

    delegate void GreetDel ();
    internal class TimeNow{

        public string Name { get; set; }

        public event GreetDel Morning;
        public event GreetDel AfterNoon;
        public event GreetDel Evening;
        public event GreetDel Night;

        int CurrentTime = DateTime.Now.Hour;

        public void EnterTime(int CurrentTime){
            if(CurrentTime>=00 && CurrentTime<12){
                Morning();
            }else if(CurrentTime>=12 && CurrentTime<16){
                AfterNoon();
            }else if(CurrentTime>=16 && CurrentTime<20){
                Evening();
            }else if(CurrentTime>=20 && CurrentTime<=24){
                Night();
            }else{
                System.Console.WriteLine("Invalid Time!");
            }
        }

        public void LiveTime(){

            System.Console.WriteLine(CurrentTime);
            
            if(CurrentTime>=00 && CurrentTime<12){
                Morning();
            }else if(CurrentTime>=12 && CurrentTime<16){
                AfterNoon();
            }else if(CurrentTime>=16 && CurrentTime<20){
                Evening();
            }else if(CurrentTime>=20 && CurrentTime<=24){
                Night();
            }else{
                System.Console.WriteLine("Invalid Time!");
            }
        }

    }
}