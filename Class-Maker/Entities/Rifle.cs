namespace Class_Maker.Entities
{
    public class Rifle : Weapon
    {
      //  public int WeaponId { ge t; set; }
      //  public string Name { get; set; }
      // // public Attachment Attachment { get; set; }
      //  public decimal Accuracy { get; set; }
      //  public string Damage { get; set; }
      //  public int Range { get; set; }
      //  public int FireRate { get; set; }
      //  public int Mobility { get; set; }
        public Skin Skin { get; set; }

        public Rifle(int id, string name)
        {
            WeaponId = id;
            Name = name;
        }
    }
}
