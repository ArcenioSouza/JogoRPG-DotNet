namespace JogoRPG_Dotnet.src.Entities
{
    public class Knight : Hero
    {
        //Constructor com Herança 
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        //Polimorfismo
        public override string Attack(){
            return this.Name + " fez um ataque com sua espada";
        }

    }
}