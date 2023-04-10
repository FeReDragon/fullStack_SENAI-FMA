using System.Collections.Generic;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Student>> GetAllStudents()
    {
        return await _repository.GetAllStudents();
    }

    public async Task<Student> GetStudentById(int id)
    {
        return await _repository.GetStudentById(id);
    }

    public async Task<Student> AddStudent(Student student)
    {
        return await _repository.AddStudent(student);
    }

    public async Task<Student> UpdateStudent(Student student)
    {
        return await _repository.UpdateStudent(student);
    }

    public async Task<bool> DeleteStudent(int id)
    {
        return await _repository.DeleteStudent(id);
    }
}
