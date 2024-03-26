public class Car
{
    public string Modele{ get; private set;}
    public string Marque {get; private set;}
    public int Annee {get; private set;}
    public Colors Couleur {get; set;}
    public void StartEngine(){
        Console.WriteLine("VROOOOOOOOOOOM VROOOOOOOOOOM");}
    public string NomComplet{
        get
        {
            return $"{Marque} {Modele}";
        }
    }
    public Car(string modele, string marque, int annee, Colors couleur){
        Marque = marque;
        Modele = modele;
        Annee = annee;
        Couleur = couleur;

    }
}