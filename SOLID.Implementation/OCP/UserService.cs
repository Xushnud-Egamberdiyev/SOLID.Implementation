namespace SOLID.Implementation.OCP;

public class UserService
{
    public virtual void Display(string name)
    {
        Console.WriteLine($"Name : {name}");
    }
}
