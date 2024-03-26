using System.Dynamic;

public class Car
{
    public string Modele { get; private set; }
    public string Marque { get; private set; }
    public int Annee { get; private set; }
    public Colors Couleur { get; set; }
    public Queue<Tache> Checklist { get; set; }

    public void StartEngine()
    {
        do
        {
            AskForChecklist();
            if (IsCheckListOk())
            {
                Console.WriteLine("VROOOOOOOOOOOM VROOOOOOOOOOM");
            }
        }
        while (IsCheckListOk() == false);



    }
    public string NomComplet
    {
        get
        {
            return $"{Marque} {Modele}";
        }
    }
    public Car(string modele, string marque, int annee, Colors couleur)
    {
        Marque = marque;
        Modele = modele;
        Annee = annee;
        Couleur = couleur;
        Initchecklist();
    }


    public virtual void Initchecklist(){
        Checklist = new Queue<Tache>();
        Checklist.Enqueue(new Tache("Présence de la clé"));
        Checklist.Enqueue(new Tache("Présence de Ceinture"));
        Checklist.Enqueue(new Tache("Présence de permis"));
        Checklist.Enqueue(new Tache("Essence remplis"));
    }
    public void AskForChecklist()
    {
        foreach (var question in Checklist)
        {
            Console.WriteLine($"As-tu fait : {question.Nom} y/n");
            var reponse = Console.ReadLine();
            if (reponse == "y")
            {
                question.isDone = true;
            }
        }
    }

    public bool IsCheckListOk()
    {
        foreach (var item in Checklist)
        {
            if (item.isDone == false)
            {
                Console.WriteLine($"cette element :{item.Nom} nest pas fait");
                return false;
            }
        }
        return true;

    }
    public void Checklist3()
    {
        Console.Write("Avez-vous votre permis ? y/n");
        string permisInput = Console.ReadLine().ToLower();
        bool aPermis = permisInput == "y";
        Console.Write("Avez-vous votre ceinture ? y/n");
        string ceintureInput = Console.ReadLine().ToLower();
        bool aCeinture = ceintureInput == "y";
        Console.Write("Avez-vous votre cles ? y/n");
        string ClesInput = Console.ReadLine().ToLower();
        bool aCles = ClesInput == "y";

        Console.WriteLine("\nChecklist:");

        if (aPermis && aCeinture && aCles)
        {
            Console.WriteLine(" - Checklist ok");
            StartEngine();
        }
        else
        {
            Console.WriteLine(" - Checklist: Non");
        }

    }
}
