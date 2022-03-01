namespace JogoRPG_Dotnet.src.Entities
{
    public class Wizzard : Hero
    {

        // Constructor com Herança
         public Wizzard(string Name, int Level, string HeroType, int Hp, int Mp) : base(Name, Level, HeroType, Hp, Mp){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        //Polimorfismo
        public override string Attack(){
            return this.Name + " lançou magia";
        }

        public override string Defesa(){
            return this.Name + " se defendeu com uma barreira protetora";
        }
    }
}