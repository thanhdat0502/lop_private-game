using Bài_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Character : Wizard
{
    

    public string NAme { get; set; }
    public int Health { get; set; }
    public Character(string name,  int health, int damage, int mana) : base(name, damage, mana)
    {
        NAme = name;
        Health = health;
    }
    public virtual void UseAbility()
    {

    }
}