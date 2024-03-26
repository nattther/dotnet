using System.Dynamic;

public class Car
{
    public string Modele { get; private set; }
    public string Marque { get; private set; }
    public int Annee { get; private set; }
    public Colors Couleur { get; set; }
    public Queue<Tache> Checklist { get; set; }

    public Queue<string> ElementNotDone { get; set; }
    public void StartEngine()
    {
        do
        {
            AskForChecklist();
            if (IsCheckListOk())
            {
                Console.WriteLine("VROOOOOOOOOOOM VROOOOOOOOOOM");
            }
            else
            {
                Console.WriteLine("Checklist items not done:");
                foreach (var item in ElementNotDone)
                {
                    Console.WriteLine(item);
                }
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


    public virtual void Initchecklist()
    {
        Checklist = new Queue<Tache>();
        Checklist.Enqueue(new Tache("Présence de la clé"));
        Checklist.Enqueue(new Tache("Présence de Ceinture"));
        Checklist.Enqueue(new Tache("Présence de permis"));
        Checklist.Enqueue(new Tache("Essence remplis"));
        ElementNotDone = new Queue<string>();
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
        ElementNotDone.Clear(); // Clear previous elements
        foreach (var item in Checklist)
        {
            if (!item.isDone)
            {
                ElementNotDone.Enqueue(item.Nom);
            }
        }
        return ElementNotDone.Count == 0;
    }
}

