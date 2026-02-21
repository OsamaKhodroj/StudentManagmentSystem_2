
using Pioneersacademy.SMS.Domains.DTOs.Student;

namespace Pioneersacademy.SMS.Domains.Interfaces;

public interface IStudent
{
    OpStatus Add(AddStudentRequest student);
    OpStatus Remove(int id);
    OpStatus Update(Student student);
    Student GetById(int id);
    List<Student> GetAll();
}
