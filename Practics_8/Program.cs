using Practics_8;

class Program
{
    static void Main()
    {
        var tasks = new LinqTasks();

        Console.WriteLine("=== Task 1: GetEvenNumbers ===");
        var evens = tasks.GetEvenNumbers(new List<int> { 1, 2, 3, 4, 5, 6 });
        Console.WriteLine(string.Join(", ", evens));

        Console.WriteLine("\n=== Task 2: GetSum ===");
        int sum = tasks.GetSum(new List<int> { 1, 2, 3, 4 });
        Console.WriteLine($"Sum: {sum}");

        Console.WriteLine("\n=== Task 3: GetLongStrings ===");
        var longStrs = tasks.GetLongStrings(new List<string> { "hi", "hello", "ok", "world" });
        Console.WriteLine(string.Join(", ", longStrs));

        Console.WriteLine("\n=== Task 4: FindPersonByName ===");
        var people1 = new List<Person>
        {
            new Person { Name = "Anna", Age = 20 },
            new Person { Name = "John", Age = 30 }
        };
        var person = tasks.FindPersonByName(people1, "John");
        Console.WriteLine($"Found: {person.Name}, Age: {person.Age}");

        Console.WriteLine("\n=== Task 5: SortDescending ===");
        var sorted = tasks.SortDescending(new List<int> { 3, 1, 4, 2 });
        Console.WriteLine(string.Join(", ", sorted));

        Console.WriteLine("\n=== Task 6: GroupByAge ===");
        var people2 = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 25 }
        };
        var grouped = tasks.GroupByAge(people2);
        foreach (var group in grouped)
        {
            Console.WriteLine($"Age: {group.Key}");
            foreach (var p in group)
                Console.WriteLine($" - {p.Name}");
        }

        Console.WriteLine("\n=== Task 7: AnyNumberGreaterThanTen ===");
        var hasBig = tasks.AnyNumberGreaterThanTen(new List<int> { 3, 7, 11 });
        Console.WriteLine($"Any > 10? {hasBig}");

        Console.WriteLine("\n=== Task 8: SelectNames ===");
        var names = tasks.SelectNames(people2);
        Console.WriteLine(string.Join(", ", names));

        Console.WriteLine("\n=== Task 9: AllPositive ===");
        var allPos = tasks.AllPositive(new List<int> { 1, 2, 3 });
        Console.WriteLine($"All positive? {allPos}");

        Console.WriteLine("\n=== Task 10: ConcatenateLists ===");
        var merged = tasks.ConcatenateLists(new List<int> { 1, 2 }, new List<int> { 3, 4 });
        Console.WriteLine(string.Join(", ", merged));
    }
}
