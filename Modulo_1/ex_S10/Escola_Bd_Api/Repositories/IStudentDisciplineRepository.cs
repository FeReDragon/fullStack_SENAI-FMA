using System.Collections.Generic;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;

public interface IStudentDisciplineRepository
{
    Task<IEnumerable<StudentDiscipline>> GetAllStudentDisciplines();
    Task<StudentDiscipline> GetStudentDisciplineById(int studentId, int disciplineId);
    Task<StudentDiscipline> AddStudentDiscipline(StudentDiscipline studentDiscipline);
    Task<StudentDiscipline> UpdateStudentDiscipline(StudentDiscipline studentDiscipline);
    Task<bool> DeleteStudentDiscipline(int studentId, int disciplineId);
}
