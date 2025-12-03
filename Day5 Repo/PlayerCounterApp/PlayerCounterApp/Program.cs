using PlayerCounterApp.Domain;

namespace PlayerCounterApp
{
     class Program
    {
         
        static void Main(string[] args)
        {
           
            
          
           
            Player sachin = new Player("Sachin", 55);
            // Console.WriteLine(sachin.Counter);
            Console.WriteLine(Player.GetHeadCount());

            Player virat = new Player("Virat", 38);
            //  Console.WriteLine(virat.Counter);
            Console.WriteLine(Player.GetHeadCount());

            Player rohit = new Player("Rohit", 37);
            Console.WriteLine(Player.GetHeadCount());

            //Console.WriteLine(rohit.Counter);
            //Console.WriteLine(sachin.Counter);
            //Console.WriteLine(virat.Counter);


            Console.WriteLine(Player.GetHeadCount());
            Console.WriteLine(rohit.Counter);//GetCounter(rohit);


          

        }

       static void CaseSTudy1() { 
        
        }
    }
}
