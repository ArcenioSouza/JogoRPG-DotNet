namespace JogoRPG_Dotnet.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int Hp, int Mp) : base(Name, Level, HeroType, Hp, Mp){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        //Polimorfismo
        public override string Attack(){
            return this.Name + " fez um ataque com sua shuriken";
        }

        public override string Defesa(){
            return this.Name + " se defendeu sumindo na cortina de fumaça";
        }
    }
}