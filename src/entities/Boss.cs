namespace DioRPG.src.entities
{
    public class Boss : Hero
    {
        public Boss (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string AttackBoss(){
            return this.Name + " Atacou com seu machado ";
        }
    }
}