namespace rpgzinho.src.entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string Herotype, string Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype;            
            this.Weapon = Weapon;            
        }
        
        public string Name;
        public int Level;
        public string Herotype;
        public string Weapon;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.Herotype;}
        
        public string Attack(){
            return this.Name + "Attacked with " + (Weapon);
        } 

        
        
    }
}