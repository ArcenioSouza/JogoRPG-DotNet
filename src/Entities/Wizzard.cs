namespace JogoRPG_Dotnet.src.Entities
{
    public class Wizzard : Hero
    {
         public Wizzard(string Name, int Level, string HeroType) : base(Name, Level, HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + "lançou magia";
        }
    }
}