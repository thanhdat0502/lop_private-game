public class Tile
{
    public Character Occupant { get; set; }
    public int PosX { get; set; }
    public int PosY { get; set; }

    public Tile(int x, int y)
    {
        PosX = x;
        PosY = y;
        Occupant = null;
    }

    public bool IsOccupied()
    {
        return Occupant != null;
    }
}
