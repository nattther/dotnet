public class Camion : Car
{
    public int ChargeMax { get; set; }
    public int ChargeActuelle
    {
        get
        {
            return GetPoidsTotal();
        }
    }
    public void Charger(Colis colis)
    {
        // Console.WriteLine("Quelle charge a ajouter ?");
        // chargeAjoutee = Console.ReadLine();
        // ChargeActuelle += chargeAjoutee;
        var poidf = colis.Poids + ChargeActuelle;

        if (poidf > ChargeMax)
        {
            Console.WriteLine("Vous avez depassé la charge maximale");

        }
        else
        {

            ColisList.Add(colis);
        }

    }
    public List<Colis> ColisList { get; set; }



public void AfficherdernierColis()
{
    Stack<Colis> Colislis = new Stack<Colis>(ColisList);

        //Console.WriteLine("Dechargement");
    //for (int i = ColisList.Count - 1; i >= 0; i--)
    //{
     //   Console.WriteLine($"Colis ID: {ColisList[i].Id}, Poids: {ColisList[i].Poids}");
    //}

    foreach (var colis in Colislis)
    {
        Console.WriteLine($"Colis ID: {colis.Id}, Poids: {colis.Poids}, Fragile: {colis.IsFragile}");
    }
}



    private int GetPoidsTotal()
    {
        var poditemp = 0;
        foreach (var colis in ColisList)
        {
            poditemp += colis.Poids;
        }

        return poditemp;
    }
    public Camion(string modele, string marque, int annee, Colors couleur, int chargeMax) : base(marque, modele, annee, couleur)
    {
        ChargeMax = chargeMax;
        ColisList = new List<Colis>();
    }
}