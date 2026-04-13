using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Design_Patterns.Creational_Patterns.Clone
{
    public class EnemyConfig
    {
        public string Name { get; set; } = "";
        public int Health { get; set; }
        public int Damage { get; set; }
        public List<string> Abilities { get; set; } = new();
        public Dictionary<string, int> Resistances { get; set; } = new();

        // Shallow copy — reference types still share references
        public EnemyConfig ShallowClone() => (EnemyConfig)MemberwiseClone();

        // Deep copy — fully independent object
        public EnemyConfig DeepClone() => new EnemyConfig
        {
            Name = Name,
            Health = Health,
            Damage = Damage,
            Abilities = new List<string>(Abilities),           // New list, same strings
            Resistances = new Dictionary<string, int>(Resistances) // New dict
        };
    }

}
