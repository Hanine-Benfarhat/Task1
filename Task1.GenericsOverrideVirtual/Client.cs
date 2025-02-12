namespace Task1.GenericsOverrideVirtual;
public class Client
{
    public string Nom { get; set; }
    public virtual void AfficherClient()
    {
        Console.WriteLine($"Client : {Nom}");
    } 
    public override string ToString() => Nom;
}