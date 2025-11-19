using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Mage : Character
{
    public Mage(string name, int health, int damage, int mana) : base(name, health, damage, mana)
    {

    }
    public override void UseAbility()
    {
        Console.WriteLine($"{Name} niem chu ngu!");
    }
}