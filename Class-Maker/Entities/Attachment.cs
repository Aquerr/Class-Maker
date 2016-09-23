namespace Class_Maker.Entities
{
    public class Attachment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WeaponType WeaponType {get;set;}
        public int Accuracy { get; set; }
        public string Damage { get; set; }
    }
}
