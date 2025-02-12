namespace Task1.GenericsOverrideVirtual;
abstract class Client
{
    public string Nom { get; set; }
    public virtual void AfficherClient()
    {
        Console.WriteLine($"Client : {Nom}");
    } 
    public override string ToString() => Nom;

    public virtual void Register() { }
}