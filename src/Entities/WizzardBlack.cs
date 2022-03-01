namespace JogoRPG_Dotnet.src.Entities
{
    public class WizzardBlack : Hero
    {
        public WizzardBlack(string Name, int Level, string HeroType, int Hp, int Mp) : base(Name, Level, HeroType, Hp, Mp){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        //Polimorfismo
        public override string Attack(){
            return this.Name + " lançou magia negra";
        }

        public override string Defesa(){
            return this.Name + " se defendeu atordoando o inimigo";
        }
    }
}