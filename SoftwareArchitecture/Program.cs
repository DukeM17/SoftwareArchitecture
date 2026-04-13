using SoftwareArchitecture.Design_Patterns.Creational_Patterns.Clone;

var baseGoblin = new EnemyConfig
{
    Name = "Goblin",
    Health = 100,
    Damage = 15,
    Abilities = ["sneak", "steal"],
    Resistances = { ["poison"] = 50 }
};

var eliteGoblin = baseGoblin.DeepClone();
eliteGoblin.Name = "Elite Goblin";
eliteGoblin.Health = 250;
eliteGoblin.Abilities.Add("rage"); // Doesn't affect baseGoblin

var bossGoblin = baseGoblin.DeepClone();
bossGoblin.Name = "Goblin King";
bossGoblin.Damage = 80;