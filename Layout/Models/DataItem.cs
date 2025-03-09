namespace APIEstherMM.Models;

public class DataItem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty; // Évite les valeurs nulles
    public string Description { get; set; } = string.Empty; // Nouvelle propriété

    // Constructeur par défaut
    public DataItem() {}

    // Constructeur avec paramètres pour faciliter l'initialisation
    public DataItem(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    // Surcharge de ToString() pour un affichage plus lisible
    public override string ToString()
    {
        return $"{Id}: {Name} - {Description}";
    }
}