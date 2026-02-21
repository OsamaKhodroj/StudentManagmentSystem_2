
using System.ComponentModel.DataAnnotations;

namespace Pioneersacademy.SMS.Domains.DTOs.Student;

public class AddStudentRequest
{
    [Obsolete("Use FullName instead.")]
    public string FirstName { get; set; }

    [Obsolete("Use FullName instead.")]
    public string LastName { get; set; }

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; }
    public DateTime BirthOfDate { get; set; }
    public string PhoneNumber { get; set; }
}
