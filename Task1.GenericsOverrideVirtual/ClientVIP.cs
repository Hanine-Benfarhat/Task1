namespace Task1.GenericsOverrideVirtual;

public class ClientVIP : Client
{
    public int PointFidelite { get; set; }
    public override void AfficherClient()
    {
        Console.WriteLine($"Client VIP : {Nom}");
    }

    public override void Register()
    {
        
    }

}
