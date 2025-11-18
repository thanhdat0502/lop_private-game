using System;

public abstract class Character
{
    public int PosX { get; set; }
    public int PosY { get; set; }
    public double Damage { get; set; }
    public int RangeAttack { get; set; }
    public double Health { get; set; }

    public Character(int x, int y, double damage, int range, double hp)
    {
        PosX = x;
        PosY = y;
        Damage = damage;
        RangeAttack = range;
        Health = hp;
    }

    public void TakeDamage(double dmg)
    {
        Health -= dmg;
        if (Health < 0) Health = 0;
    }

    public abstract void Move(char direction = ' ');

    public virtual Character CheckRangeAttack(Tile[,] grid)
    {
        int maxX = grid.GetLength(0);
        int maxY = grid.GetLength(1);

        for (int dx = -RangeAttack; dx <= RangeAttack; dx++)
        {
            for (int dy = -RangeAttack; dy <= RangeAttack; dy++)
            {
                int nx = PosX + dx;
                int ny = PosY + dy;

                if (nx >= 0 && ny >= 0 && nx < maxX && ny < maxY)
                {
                    Character c = grid[nx, ny].Occupant;
                    if (c != null && c != this)
                    {
                        return c;
                    }
                }
            }
        }
        return null;
    }

    public virtual void Attack(Tile[,] grid)
    {
        Character target = CheckRangeAttack(grid);
        if (target != null)
        {
            target.TakeDamage(this.Damage);
        }
    }
}

