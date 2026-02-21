
namespace Pioneersacademy.SMS.Domains.Entities;

public class Student : BaseEntitiy<long>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public DateTime BirthOfDate { get; set; }
    public string PhoneNumber { get; set; }
    public StudentStatus StudentStatus { get; set; }
}
