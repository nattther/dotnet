public class Person
{
    public string Prenom{ get; private set; }
    public string Nom{ get; private set; }
    public int Age { get; private set; }
    public string Nomcomplet
    {
        get
        {
            return $"{Prenom} {Nom}";
        }
    }
    public Person(string prenom, string nom, int age)
    {
        Prenom = prenom;
        Nom = nom;
        Age = age;
    }

}