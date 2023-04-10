using System.Collections.Generic;
using Escola_Bd_Api.Models;

public interface ITeacherRepository
{
    Task<IEnumerable<Teacher>> GetAllTeachers();
    Task<Teacher> GetTeacherById(int id);
    Task<Teacher> AddTeacher(Teacher teacher);
    Task<Teacher> UpdateTeacher(Teacher teacher);
    Task<bool> DeleteTeacher(int id);
}
