using System.Collections.Generic;
using System.Threading.Tasks;
using Escola_Bd_Api.Models;

public class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _teacherRepository;

    public TeacherService(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }

    public async Task<IEnumerable<Teacher>> GetAllTeachers()
    {
        return await _teacherRepository.GetAllTeachers();
    }

    public async Task<Teacher> GetTeacherById(int id)
    {
        return await _teacherRepository.GetTeacherById(id);
    }

    public async Task<Teacher> AddTeacher(Teacher teacher)
    {
        return await _teacherRepository.AddTeacher(teacher);
    }

    public async Task<Teacher> UpdateTeacher(Teacher teacher)
    {
        return await _teacherRepository.UpdateTeacher(teacher);
    }

    public async Task<bool> DeleteTeacher(int id)
    {
        return await _teacherRepository.DeleteTeacher(id);
    }
}
