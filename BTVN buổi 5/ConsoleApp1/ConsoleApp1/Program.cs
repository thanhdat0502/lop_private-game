using System;
using System.Collections.Generic;

public class ActiveGame
{
    public static void Main()
    {
        List<Weapon> weapons = new List<Weapon>()
        {
            new Weapon("Sword", 2, 2),
            new Weapon("Axe", 3, 1),
            new Weapon("Spear", 1.5, 3),
            new Weapon("Dagger", 1, 1)
        };

        GameManager.Instance.StartBattle(weapons);
    }
}

