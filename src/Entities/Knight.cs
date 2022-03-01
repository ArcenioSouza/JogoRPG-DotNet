namespace JogoRPG_Dotnet.src.Entities
{
    public class Knight : Hero
    {
        //Constructor com Herança 
        public Knight(string Name, int Level, string HeroType, int Hp, int Mp) : base(Name, Level, HeroType, Hp, Mp){
            
        }

        //Polimorfismo
        public override string Attack(){
            return this.Name + " fez um ataque com sua espada";
        }

        public override string Defesa(){
            return this.Name + " fez uma defesa com seu escudo";
        }

    }
}