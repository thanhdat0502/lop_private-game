public class Weapon
{
    public string Name { get; set; }
    public double Damage { get; set; }
    public int RangeAttack { get; set; }

    public Weapon(string name, double dmg, int range)
    {
        Name = name;
        Damage = dmg;
        RangeAttack = range;
    }
}

