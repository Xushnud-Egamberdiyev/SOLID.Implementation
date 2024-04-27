namespace SOLID.Implementation.OCP;

public class StudentService : UserService
{
    public override void Display(string name)
    {
        Console.WriteLine($"Student: {name}");
    }
}
