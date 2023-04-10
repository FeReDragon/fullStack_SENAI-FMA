using System.Collections.Generic;
using Escola_Bd_Api.Models;

public interface IStudentService
{
    Task<IEnumerable<Student>> GetAllStudents();
    Task<Student> GetStudentById(int id);
    Task<Student> AddStudent(Student student);
    Task<Student> UpdateStudent(Student student);
    Task<bool> DeleteStudent(int id);
}
