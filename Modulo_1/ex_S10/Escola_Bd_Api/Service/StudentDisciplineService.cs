using System.Collections.Generic;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;

public class StudentDisciplineService : IStudentDisciplineService
{
    private readonly IStudentDisciplineRepository _studentDisciplineRepository;

    public StudentDisciplineService(IStudentDisciplineRepository studentDisciplineRepository)
    {
        _studentDisciplineRepository = studentDisciplineRepository;
    }

    public async Task<IEnumerable<StudentDiscipline>> GetAllStudentDisciplines()
    {
        return await _studentDisciplineRepository.GetAllStudentDisciplines();
    }

    public async Task<StudentDiscipline> GetStudentDisciplineById(int studentId, int disciplineId)
    {
        return await _studentDisciplineRepository.GetStudentDisciplineById(studentId, disciplineId);
    }

    public async Task<StudentDiscipline> AddStudentDiscipline(StudentDiscipline studentDiscipline)
    {
        return await _studentDisciplineRepository.AddStudentDiscipline(studentDiscipline);
    }

    public async Task<StudentDiscipline> UpdateStudentDiscipline(StudentDiscipline studentDiscipline)
    {
        return await _studentDisciplineRepository.UpdateStudentDiscipline(studentDiscipline);
    }

    public async Task<bool> DeleteStudentDiscipline(int studentId, int disciplineId)
    {
        return await _studentDisciplineRepository.DeleteStudentDiscipline(studentId, disciplineId);
    }
}
