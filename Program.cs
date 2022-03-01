namespace JogoRPG_Dotnet.src.Entities
{
   class Program
      {
         static void Main(string[] args)
         {
            Knight Arus = new Knight("Arus", 20, "Knight");
            Wizzard Jenica = new Wizzard("Jenica", 23, "White Wizzard");

            Console.WriteLine(Arus);
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Arus.Attack(7));

            Console.WriteLine(Jenica);            
            Console.WriteLine(Jenica.Attack());
            Console.WriteLine(Jenica.Attack(2));
            
         }
      }
}