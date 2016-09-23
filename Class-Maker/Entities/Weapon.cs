using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Maker.Entities
{
    public class Weapon
    {
        public int WeaponId { get; set; }
        public string Name { get; set; }
        public WeaponType WeaponType { get; set; }
        public Attachment Attachment { get; set; }
        public decimal Accuracy { get; set; }
        public string Damage { get; set; }
        public int Range { get; set; }
        public int FireRate { get; set; }
        public int Mobility { get; set; }
    }
}
