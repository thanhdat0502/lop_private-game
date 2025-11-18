using System;
using System.Collections.Generic;

public class GridManager
{
    public int xWide, yHigh;
    public Tile[,] grid;
    public List<Enemy> enemyList;
    public Player player;

    public GridManager(int x, int y)
    {
        xWide = x;
        yHigh = y;
        grid = new Tile[xWide, yHigh];
        enemyList = new List<Enemy>();
    }

    public void SpawnTile()
    {
        for (int i = 0; i < xWide; i++)
            for (int j = 0; j < yHigh; j++)
                grid[i, j] = new Tile(i, j);
    }

    public void UpdateGrid()
    {
        foreach (var t in grid)
            t.Occupant = null;

        if (player != null)
            grid[player.PosX, player.PosY].Occupant = player;

        foreach (var e in enemyList)
            if (e.Health > 0)
                grid[e.PosX, e.PosY].Occupant = e;
    }

    public void DrawGrid()
    {
        Console.WriteLine("--------------------------");

        for (int y = 0; y < yHigh; y++)
        {
            for (int x = 0; x < xWide; x++)
            {
                if (grid[x, y].Occupant is Player)
                    Console.Write("0 ");
                else if (grid[x, y].Occupant is Enemy)
                    Console.Write("1 ");
                else
                    Console.Write("X ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("--------------------------");
    }
}

