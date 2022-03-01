namespace JogoRPG_Dotnet.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public string HeroType;
        public int Level;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

    }
}