namespace HashSetCollection;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> firstHashSet = new HashSet<string>();
        firstHashSet.Add("Apple");
        firstHashSet.Add("Banana");
        firstHashSet.Add("Orange");
        firstHashSet.Add("Grape");
        firstHashSet.Add("Pineapple");

        HashSet<string> secondHashSet = new HashSet<string>();
        secondHashSet.Add("Mango");
        secondHashSet.Add("Papaya");
        secondHashSet.Add("Strawberry");
        secondHashSet.Add("Blueberry");
        secondHashSet.Add("Raspberry");

        HashSet<string> thirdHashSet = new HashSet<string>();
        thirdHashSet.Add("Grape");
        thirdHashSet.Add("Kiwi");
        thirdHashSet.Add("Watermelon");
        thirdHashSet.Add("Peach");
        thirdHashSet.Add("Mango");

        // Combine the first and second HashSet
        firstHashSet.UnionWith(secondHashSet);
        Console.WriteLine("Combined HashSet:");
        foreach (var item in firstHashSet)
        {
            Console.WriteLine(item);
        }

        // Create a new HashSet to store duplicates
        HashSet<string> duplicatesHashSet = new HashSet<string>(firstHashSet);
        // Retain only the items that appear in both firstHashSet and thirdHashSet
        duplicatesHashSet.IntersectWith(thirdHashSet);

        // Print out the contents of the HashSet containing duplicates
        Console.WriteLine("\nDuplicates HashSet:");
        foreach (var item in duplicatesHashSet)
        {
            Console.WriteLine(item);
        }
    }
}