namespace Class_Maker.Entities
{
    public class Loadout
    {
        public int LoadoutId { get; set; }
        public string Name { get; set; }
        public Weapon Weapon { get; set; }
        public Pistol Pistol { get; set; }
        public OffensiveGranade OffensiveGranade{get;set;}
        public TacticalGranade FirstTacticalGranade{get;set;}
        public TacticalGranade SecondTacticalGranade { get; set; }
        //public Armour Armour { get; set; }
    }
}
