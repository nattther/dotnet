internal class Program
{
    private static void Main(string[] args)
    {
        // Person Robert = new Person("Robert", "Hue", 86);
        Car audi = new Car("Q7","Audi",2024,Colors.Gris);
        Camion Scannia = new Camion("M400", "Scania", 2024, Colors.Rouge, 400);
        Colis colis1 = new Colis(1, 100, false);
        Colis colis2 = new Colis(2, 500, false);
        Colis colis3 = new Colis(3, 20, false);
        Colis colis4 = new Colis(4, 100, false);
        Console.WriteLine($"nom complet de ma voiture : {audi.NomComplet} Année de fabrication: {audi.Annee}");

        //audi.StartEngine();
        Console.WriteLine($"nom complet de mon camion : {Scannia.NomComplet} Année de fabrication: {Scannia.Annee} poid max : {Scannia.ChargeMax} Litres");
       Scannia.StartEngine();
        Scannia.Charger(colis1);
        Scannia.Charger(colis2);
        Scannia.Charger(colis3);
        Scannia.Charger(colis4);
        
        Scannia.AfficherdernierColis();

        Console.WriteLine(Scannia.ChargeActuelle);


    }
}