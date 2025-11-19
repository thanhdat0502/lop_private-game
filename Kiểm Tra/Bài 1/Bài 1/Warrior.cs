using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class Warrior : Character
{
    public Warrior (string name,  int health, int damage, int mana) : base (name, health, damage, mana)
    {

    }
    public override void UseAbility()
    {
        Console.WriteLine($"{Name} dung xoay bua");
    }
   
}
