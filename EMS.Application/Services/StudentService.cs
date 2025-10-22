
using EMS.Domain.DTOs;
using EMS.Domain.Entities;
using EMS.Domain.Interfaces;

namespace EMS.Application.Services
{
    public class StudentService
    {
        private readonly IStudent _student;
        public StudentService(IStudent student)
        {
            _student = student;
        }
        public IEnumerable<StudentDTO> GetAllStudents()
        {
            return _student.GetAllStudents().Select(stu => new StudentDTO
            {
                Id = stu.Id,
                Name = stu.Name,
                Email = stu.Email,
                Phone = stu.Phone,
            });
        }
        public StudentDTO GetStudentById(int id) {
            var stu =  _student.GetStudentById(id);
            return new StudentDTO { Id= stu.Id,Name = stu.Name,Email= stu.Email,Phone=stu.Phone};
        }
        public void AddStudent(StudentDTO studentDto)
        {
            var student = new Student { Name = studentDto.Name, Email = studentDto.Email, Phone=studentDto.Phone};
            _student.AddStudent(student);
        }
        public void UpdateStudent(StudentDTO studentDTO) {
            Student student = new Student();
            student.Id = studentDTO.Id;
            student.Name = studentDTO.Name;
            student.Email = studentDTO.Email;
            student.Phone = studentDTO.Phone;
            _student.UpdateStudent(student);
        }
        public void DeleteStudent(int id) { 
            _student.DeleteStudent(id);
        }
    }
}
