namespace Task1.GenericsOverrideVirtual;

using System;
using System.Collections.Generic;

//Type Generique T 
public class Stock<T>
{
    private List<T> _items = new List<T>();

    public void Ajouter(T item)
    {
        _items.Add(item);
        Console.WriteLine($"{item} ajouté !");
    }

    public void Supprimer(T item)
    {
        _items.Remove(item);
        Console.WriteLine($"{item} supprimé !");
    }

    public void AfficherTous()
    {
        Console.WriteLine("\nContenu du stock :");
        foreach (var item in _items)
        {
            Console.WriteLine($"- {item}");
        }
    }
}

