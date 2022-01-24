var queue = new PriorityQueue<Student, string>(new RoleComparer());

queue.Enqueue(new Student("Fábio"), "student");
queue.Enqueue(new Student("Bryan"), "premium");
queue.Enqueue(new Student("Ana"), "admin");
queue.Enqueue(new Student("Rita"), "student");

while (queue.TryDequeue(
    out var item, out var priority)) 
    Console.WriteLine($"Student: {item.Name}. Priority: {priority}.");

public record Student(string Name);


//The follow class Return -1, 0 or 1
//whith this values we can sort the data
public class RoleComparer : IComparer<string>
{
    public int Compare(string? roleA, string? roleB)
    {
        if (roleA == roleB)
            return 0;
        return roleA switch
        {
            "premium" => -1,
            "admin" => -1,
            _ => 1,
        };
    }
}