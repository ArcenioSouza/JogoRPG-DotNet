namespace JogoRPG_Dotnet.src.Entities
{
    public class WizzardBlack : Hero
    {
        public WizzardBlack(string Name, int Level, string HeroType) : base(Name, Level, HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        //Polimorfismo
        public override string Attack(){
            return this.Name + " lançou magia negra";
        }
    }
}