using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Maker.Entities
{
    public class Granade
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string CollisionDamage { get; set; }
        public string ExplosionTime { get; set; }
        public bool IsImpact { get; set; }
    }
}
