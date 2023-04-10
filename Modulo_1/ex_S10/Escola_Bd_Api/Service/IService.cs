using Escola_Bd_Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Escola_Bd_Api.Services
{
    public interface IDisciplineService
    {
        Task<IEnumerable<Discipline>> GetDisciplines();
        Task<Discipline> GetDisciplineById(int id);
        Task<Discipline> CreateDiscipline(Discipline discipline);
        Task<Discipline> UpdateDiscipline(int id, Discipline discipline);
        Task DeleteDiscipline(int id);
    }
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudentById(int id);
        Task<Student> CreateStudent(Student student);
        Task<Student> UpdateStudent(int id, Student student);
        Task DeleteStudent(int id);
    }

    public interface ITeacherService
    {
        Task<IEnumerable<Teacher>> GetTeachers();
        Task<Teacher> GetTeacherById(int id);
        Task<Teacher> CreateTeacher(Teacher teacher);
        Task<Teacher> UpdateTeacher(int id, Teacher teacher);
        Task DeleteTeacher(int id);
    }

    public interface IQuizService
    {
        Task<IEnumerable<Quiz>> GetQuizzes();
        Task<Quiz> GetQuizById(int id);
        Task<Quiz> CreateQuiz(Quiz quiz);
        Task<Quiz> UpdateQuiz(int id, Quiz quiz);
        Task DeleteQuiz(int id);
    }

    public interface IQuestionService
    {
        Task<IEnumerable<Question>> GetQuestions();
        Task<Question> GetQuestionById(int id);
        Task<Question> CreateQuestion(Question question);
        Task<Question> UpdateQuestion(int id, Question question);
        Task DeleteQuestion(int id);
    }

    public interface IAnswerService
    {
        Task<IEnumerable<Answer>> GetAnswers();
        Task<Answer> GetAnswerById(int id);
        Task<Answer> CreateAnswer(Answer answer);
        Task<Answer> UpdateAnswer(int id, Answer answer);
        Task DeleteAnswer(int id);
    }

}