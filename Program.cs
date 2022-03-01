namespace JogoRPG_Dotnet.src.Entities
{
   class Program
      {
         static void Main(string[] args)
         {
            Knight Arus = new Knight("Arus", 20, "Knight");
            Wizzard Jenica = new Wizzard("Jenica", 23, "White Wizzard");
            Ninja Wedge = new Ninja("Wedge", 35, "Ninja");
            WizzardBlack Topaga = new WizzardBlack("Topaga", 51, "Wizzard Black");

            Console.WriteLine(Arus);
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Arus.Attack(7));

            Console.WriteLine(Jenica);            
            Console.WriteLine(Jenica.Attack());
            Console.WriteLine(Jenica.Attack(2));

            Console.WriteLine(Wedge);            
            Console.WriteLine(Wedge.Attack());
            Console.WriteLine(Wedge.Attack(10));

            Console.WriteLine(Topaga);            
            Console.WriteLine(Topaga.Attack());
            Console.WriteLine(Topaga.Attack(5));
            
         }
      }
}