
namespace Pioneersacademy.SMS.Domains.Entities;

public class Teacher: BaseEntitiy<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthOfDate { get; set; }
    public string PhoneNumber { get; set; }
    public List<Student> Students { get; set; }
}
