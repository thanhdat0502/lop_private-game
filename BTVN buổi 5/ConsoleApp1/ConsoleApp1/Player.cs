using System;

public class Player : Character
{
    public Weapon CurrentWeapon { get; set; }

    public Player(int x, int y, Weapon wp)
        : base(x, y, wp.Damage, wp.RangeAttack, 10)
    {
        CurrentWeapon = wp;
    }

    public override void Move(char direction = ' ')
    {
        int newX = PosX, newY = PosY;

        switch (char.ToUpper(direction))
        {
            case 'W': newY--; break;
            case 'S': newY++; break;
            case 'A': newX--; break;
            case 'D': newX++; break;
            default: return;
        }

        GameManager gm = GameManager.Instance;

        if (!gm.IsInsideGrid(newX, newY)) return;

        Tile next = gm.gridManager.grid[newX, newY];

        if (!next.IsOccupied())
        {
            PosX = newX;
            PosY = newY;
        }
    }

    public override void Attack(Tile[,] grid)
    {
        Character target = CheckRangeAttack(grid);

        if (target is Enemy enemy)
        {
            enemy.TakeDamage(CurrentWeapon.Damage);
            Console.WriteLine($"Ban tan cong Emty gay  {CurrentWeapon.Damage} sat thuong!");
        }
    }

    public override Character CheckRangeAttack(Tile[,] grid)
    {
        return base.CheckRangeAttack(grid);
    }
}

