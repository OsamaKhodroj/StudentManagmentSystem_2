using Mapster;
using Pioneersacademy.SMS.Domains.DTOs.Student;
using Pioneersacademy.SMS.Domains.Entities;
using Pioneersacademy.SMS.Domains.Enums;
using Pioneersacademy.SMS.Domains.Interfaces;

namespace Pioneersacademy.SMS.Services;

public class StudentService : IStudent
{

    #region Variables

    private readonly List<Student> _students;

    #endregion

    #region Constractores

    public StudentService()
    {
        if (_students == null)
        {
            _students = new List<Student>();
        }
    }

    #endregion

    #region Public Mehthods


    public OpStatus Add(AddStudentRequest request)
    {
        try
        {
            LogFile.WriteLog(LogType.Info, "Start add new student method");
            Check(request);
            var isExists = false;
            foreach (var s in _students)
            {
                if (request.PhoneNumber == s.PhoneNumber)
                {
                    isExists = true;
                    break;
                }
            }

            if (!isExists)
            {
                var stu = request.Adapt<Student>();
                stu.Id = UserAutoNumber();
                stu.StudentStatus = StudentStatus.Pass;

                _students.Add(stu);
                return OpStatus.Success;
            }
            else
            {
                return OpStatus.AlreadyExists;
            }
        }
        catch (Exception ex)
        {
            LogFile.WriteLog(LogType.Error, ex.StackTrace);
            return OpStatus.Failure;
        }
    }

    public List<Student> GetAll()
    {
        throw new NotImplementedException();
    }

    public Student GetById(int id)
    {
        throw new NotImplementedException();
    }

    public OpStatus Remove(int id)
    {
        throw new NotImplementedException();
    }

    public OpStatus Update(Student student)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Private Methods

    private void Check(AddStudentRequest request)
    {
        if (string.IsNullOrEmpty(request.FirstName))
            throw new ArgumentNullException("First Name is reqired");

        if (string.IsNullOrEmpty(request.LastName))
            throw new ArgumentNullException("Last Name is reqired");

    }

    private int UserAutoNumber()
    {
        return _students.Count + 1;
    }

    #endregion 

}
