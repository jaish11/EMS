using EMS.Domain.Entities;

namespace EMS.Domain.Interfaces
{
    public interface IStudent
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);

    }
}
