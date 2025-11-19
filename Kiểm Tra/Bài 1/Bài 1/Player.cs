using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player : GameEntity
{
    public Player (string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
    public override void PerformAttack(GameEntity e)
    {
        e.PerformAttack(damage);
    }
}