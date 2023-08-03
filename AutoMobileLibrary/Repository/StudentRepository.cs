using AutoMobileLibrary.BussinessObject;
using AutoMobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLibrary.Repository
{
    public class StudentRepository: IStudentRepository
    {
        public IEnumerable<Student> GetStudents() => StudentDbContext.Instance.GetStudentList();
        public Student GetStudentByID(int studentId) => StudentDbContext.Instance.GetStudentByID(studentId);
        public void InsertStudent(Student student) => StudentDbContext.Instance.AddNew(student);
        public void UpdateStudent(Student student) => StudentDbContext.Instance.Update(student);
        public void DeleteStudent(int studentId) => StudentDbContext.Instance.Delete(studentId);
    }
}
