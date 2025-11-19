using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class GameEntity
{
    public string Name { get; set; }
    public int Health {  get; set; }
    public int Damage { get; set; }
    
    public GameEntity(string name, int health, int damage)
    {
        Name = name; 
        Health = health;
        Damage = damage;
    }
    public void TakeDame(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }
    public bool IsAlive()
    {
        if (Health > 0) return true;
        return false;
    }
    public abstract void PerformAttack(GameEntity e);
}

