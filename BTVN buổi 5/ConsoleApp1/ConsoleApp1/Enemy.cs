using System;
using System.Numerics;

public class Enemy : Character
{
    private static Random rd = new Random();

    public Enemy(int x, int y, double dmg, int range, double hp)
        : base(x, y, dmg, range, hp) { }

    public override void Move(char direction = ' ')
    {
        int dir = rd.Next(4);
        int newX = PosX, newY = PosY;

        switch (dir)
        {
            case 0: newY--; break;
            case 1: newY++; break;
            case 2: newX--; break;
            case 3: newX++; break;
        }

        GameManager gm = GameManager.Instance;
        if (gm.IsInsideGrid(newX, newY) && gm.gridManager.grid[newX, newY].Occupant == null)
        {
            PosX = newX;
            PosY = newY;
        }
    }

    public override void Attack(Tile[,] grid)
    {
        Character target = CheckRangeAttack(grid);
        if (target is Player player)
        {
            player.TakeDamage(Damage);
            Console.WriteLine($"EnemyTtan cong player gay  {Damage} sat thuong!");
        }
    }
}
