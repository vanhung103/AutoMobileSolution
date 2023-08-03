using AutoMobileLibrary.BussinessObject;
using Microsoft.Data.SqlClient;
using QLBanHangLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMobileLibrary.DataAccess
{
    public class StudentDbContext: BaseDAL
    {
        private static StudentDbContext instance;
        private static readonly object instanceLock = new object();
        public StudentDbContext() { }

        public static StudentDbContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StudentDbContext();
                    }
                    return instance;
                }
            }
        }
        //-------------------------------------------------------
        public IEnumerable<Student> GetStudentList()
        {
            IDataReader reader = null;
            string sql = "SELECT * FROM Students";
            var students = new List<Student>();
            try
            {
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection);
                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        StudentID = reader.GetInt32(0),
                        StudentName = reader.GetString(1),
                        Gender = reader.GetString(2),
                        Address = reader.GetString(3),
                        DiemTB = reader.GetDouble(4)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return students;
        }
        //-------------------------------------------------------
        public Student GetStudentByID(int studentID)
        {
            Student student = null;
            IDataReader reader = null;
            string sql = "SELECT * FROM Students WHERE StudentID= @StudentID";
            try
            {
                var param = dataProvider.CreateParameter("@StudentID", 4, studentID, DbType.Int32);
                reader = dataProvider.GetDataAdapter(sql, CommandType.Text, out connection, param);
                if (reader.Read())
                {
                    student = new Student
                    {
                        StudentID = reader.GetInt32(0),
                        StudentName = reader.GetString(1),
                        Gender = reader.GetString(2),
                        Address = reader.GetString(3),
                        DiemTB = reader.GetFloat(4)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return student;
        }
        //------------------------------------------------------------
        public void AddNew(Student student)
        {
            try
            {
                Student s = GetStudentByID(student.StudentID);
                if (s == null)
                {
                    string sql = "INSERT INTO Students(StudentName, Gender, Address, DiemTB) Values(@StudentName, @Gender, @Address,@DiemTB)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@StudentName", 50, student.StudentName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Gender", 50, student.Gender, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Address", 50, student.Address, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiemTB", 50, student.DiemTB, DbType.Int32));
                    dataProvider.Insert(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //-----------------------------------------------------------------
        public void Update(Student student)
        {
            try
            {
                Student s = GetStudentByID(student.StudentID);
                if (s != null)
                {
                    string sql = "UPDATE Students Set StudentName=@StudentName, Gender=@Gender, Address=@Address, DiemTB=@DiemTB WHERE StudentID=@StudentID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@StudentName", 50, student.StudentName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Gender", 50, student.Gender, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Address", 50, student.Address, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@DiemTB", 50, student.DiemTB, DbType.Int32));
                    dataProvider.Insert(sql, CommandType.Text, parameters.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //-------------------------------------------------------------
        public void Delete(int studentID)
        {
                try
                {
                    Student s = GetStudentByID(studentID);
                    if (s != null)
                    {
                        string sql = "DELETE Students where StudentID=@StudentID";
                        var parameters = new List<SqlParameter>();
                        parameters.Add(dataProvider.CreateParameter("@StudentID", 4, studentID, DbType.Int32));
                        dataProvider.Delete(sql, CommandType.Text, parameters.ToArray());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    CloseConnection();
                }
            }
        }
}
