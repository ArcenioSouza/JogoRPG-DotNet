namespace JogoRPG_Dotnet.src.Entities
{
    public class Wizzard : Hero
    {

        // Constructor com Herança
         public Wizzard(string Name, int Level, string HeroType) : base(Name, Level, HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        //Polimorfismo
        public override string Attack(){
            return this.Name + " lançou magia";
        }
    }
}