using System;
using System.Collections.Generic;

class GenericList
{
    private List<object> items;

    public GenericList()
    {
        items = new List<object>();
    }

    // Método para agregar un elemento a la lista
    public void AddItem(object item)
    {
        items.Add(item);
        Console.WriteLine($"Item '{item}' agregado a la lista.");
    }

    // Método para eliminar un elemento de la lista
    public void RemoveItem(object item)
    {
        if (items.Remove(item))
        {
            Console.WriteLine($"Item '{item}' eliminado de la lista.");
        }
        else
        {
            Console.WriteLine($"Item '{item}' no encontrado en la lista.");
        }
    }

    // Método para buscar un elemento en la lista
    public bool ContainsItem(object item)
    {
        bool contains = items.Contains(item);
        Console.WriteLine(contains ? $"La lista contiene '{item}'." : $"La lista no contiene '{item}'.");
        return contains;
    }

    // Método para imprimir todos los elementos de la lista
    public void PrintAllItems()
    {
        Console.WriteLine("Elementos en la lista:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }


}

class Program
{
    static void Main(string[] args)
    {
        GenericList list = new GenericList();

        // Agregar elementos a la lista
        list.AddItem(42);
        list.AddItem("Hola");
        list.AddItem(3.14);
        list.AddItem("QA");

        // Imprimir todos los elementos
        list.PrintAllItems();

        // Buscar elementos en la lista
        list.ContainsItem(42);
        list.ContainsItem("Adiós");

        // Eliminar elementos de la lista
        list.RemoveItem(3.14);
        list.RemoveItem("Adiós");

        // Imprimir todos los elementos nuevamente
        list.PrintAllItems();
    }
}
