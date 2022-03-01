namespace JogoRPG_Dotnet.src.Entities
{
   class Program
      {
         static void Main(string[] args)
         {
            Knight Cloud = new Knight("Cloud", 20, "Knight", 250, 100);            

            Console.WriteLine(Cloud);
            Console.WriteLine(Cloud.Attack());
            Console.WriteLine(Cloud.Attack(7));
            Console.WriteLine(Cloud.Defesa());            
            
         }
      }
}