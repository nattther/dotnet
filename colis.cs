public class Colis
{
    public int Id { get; set; }
    public int Poids { get; set; }
    public bool IsFragile { get; set; }

    public Colis(int id, int poids, bool isFragile)
    {
        Id = id;
        Poids = poids;
        IsFragile = isFragile;
    }
}