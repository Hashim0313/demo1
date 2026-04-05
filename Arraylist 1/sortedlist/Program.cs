using System.Collections;


internal class Program
{
    private static void Main(string[] args)
    {
        SortedList inventory = new SortedList();

        inventory.Add(10, "apple");
        inventory.Add(20, "banana");
        inventory.Add(5, "grape");
        inventory.Add(15, "orange");
        inventory.Add(25, "mango");

        Console.WriteLine("Items in the inventory:");
        DisplayInventory(inventory);

        inventory.Remove(15);
        Console.WriteLine("\nItems in the inventory after removing key 15:");
        DisplayInventory(inventory);

        int searchKey = 20;
        Console.WriteLine($"\nInventory contains key {searchKey}: {inventory.ContainsKey(searchKey)}");


        int KeyToFind = 5;
        int indexKey = inventory.IndexOfKey(KeyToFind);
        Console.WriteLine($"\nIndex of key {KeyToFind}: {indexKey}");
        Console.ReadLine();

        string searchValue = "banana";
        int indexValue = inventory.IndexOfValue(searchValue);
        Console.WriteLine($"\nIndex of value '{searchValue}': {indexValue}");
        Console.ReadLine();

        Console.WriteLine($"\nTotal number of items in the inventory: {inventory.Count}");
        Console.ReadLine();
    }

    public static void DisplayInventory(SortedList inventory)
    {
        foreach (DictionaryEntry item in inventory)
        {
            Console.WriteLine($"Key: {item.Key}, Name: {item.Value}");
        }
    }
}

