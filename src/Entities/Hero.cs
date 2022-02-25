namespace projeto.src.Entities
{
    public class Walney
    {
        public Walney(string Name, int Level,string HeroType ){
           this.Name = Name;
           this.Level = Level;
           this.HeroType =  HeroType;

        }
        public Walney(){

        }
        public string Name;
        public int Level;
        public String HeroType; 

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public string Attack(){
            return this.Name + " Atacou com sua espada";
        }
    }
}