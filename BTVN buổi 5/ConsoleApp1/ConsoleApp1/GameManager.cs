using System;
using System.Collections.Generic;

public class GameManager
{
    public static GameManager Instance = new GameManager();

    public int xWide = 5, yHigh = 5;
    public Player player;
    public List<Enemy> enemyList;
    public GridManager gridManager;

    public int turn = 0; // 0 = Player, 1 = Enemy

    private GameManager() { }

    public bool IsInsideGrid(int x, int y)
    {
        return x >= 0 && y >= 0 && x < xWide && y < yHigh;
    }

    public void StartBattle(List<Weapon> wps)
    {
        gridManager = new GridManager(xWide, yHigh);
        gridManager.SpawnTile();

        Random rd = new Random();

        // Random chọn vũ khí
        Weapon wp = wps[rd.Next(wps.Count)];

        SpawnEntity(wp);

        Console.WriteLine("Bat dau game!");
        Console.WriteLine($"vu khi cua ban la: {wp.Name}");
        Console.WriteLine($"Tam danh: {wp.RangeAttack}");
        Console.WriteLine($"Sat thuong: {wp.Damage}");

        while (true)
        {
            gridManager.UpdateGrid();
            gridManager.DrawGrid();
            PrintStats();

            if (CheckWinOrLose()) break;

            if (turn == 0)
            {
                TurnPlayer();
                turn = 1;
            }
            else
            {
                TurnEnemy();
                turn = 0;
            }
        }
    }

    public void SpawnEntity(Weapon wp)
    {
        Random rd = new Random();

        // Spawn Player
        int px = rd.Next(xWide);
        int py = rd.Next(yHigh);
        player = new Player(px, py, wp);
        gridManager.player = player;

        // Spawn Enemy
        enemyList = new List<Enemy>();
        int count = rd.Next(2, 4); // 2–3 quái

        for (int i = 0; i < count; i++)
        {
            int ex, ey;
            do
            {
                ex = rd.Next(xWide);
                ey = rd.Next(yHigh);
            } while (ex == px && ey == py);

            enemyList.Add(new Enemy(ex, ey, 1, 1, rd.Next(5, 9)));
        }
        gridManager.enemyList = enemyList;
    }

    public void TurnPlayer()
    {
        Console.Write("Nhap huong (W/A/S/D): ");
        char key = Console.ReadKey().KeyChar;
        Console.WriteLine();

        player.Move(key);
        player.Attack(gridManager.grid);
    }

    public void TurnEnemy()
    {
        foreach (var e in enemyList)
        {
            if (e.Health <= 0) continue;

            e.Move();
            e.Attack(gridManager.grid);
        }
    }

    public bool CheckWinOrLose()
    {
        if (player.Health <= 0)
        {
            Console.WriteLine("Ban da thua!");
            return true;
        }

        bool allDead = true;
        foreach (var e in enemyList)
            if (e.Health > 0)
                allDead = false;

        if (allDead)
        {
            Console.WriteLine("Ban da WIN!");
            return true;
        }
        return false;
    }

    public void PrintStats()
    {
        Console.WriteLine($"Mau Player: {player.Health}");
        for (int i = 0; i < enemyList.Count; i++)
            Console.WriteLine($"Enemy {i + 1}: {enemyList[i].Health} HP");
    }
}

