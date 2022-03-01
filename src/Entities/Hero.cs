namespace JogoRPG_Dotnet.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Hp, int Mp){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public string Name;
        public string HeroType;
        public int Level;
        public int Hp;
        public int Mp;

        public override string ToString(){
            return 
            "Nome: " + this.Name + "\r\n" + 
            "Level: " + this.Level + "\r\n" + 
            "Tipo: " + this.HeroType + "\r\n" + 
            "HP: " + this.Hp + "\r\n" + 
            "MP: " + this.Mp + "\r\n";
        }

        public virtual string Attack(){
            return this.Name + " fez um ataque...";
        }

        public virtual string Defesa(){
            return this.Name + " fez uma defesa...";
        }

        // Encapsulamento
        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + " fez um super ataque com bonus de " + Bonus;
            } else {
                return this.Name + " fez um ataque comum com bonus de " + Bonus;
            }
        }

    }
}