using System.Xml.Linq;

namespace SOLID.Implementation.SRP;

public class StudentService
{
    public DateTime GetAgeOfStudent()
    {
        return DateTime.UtcNow;
    }

    public string GetStudentName()
    {
        return "IsmiGul";
    }

}
