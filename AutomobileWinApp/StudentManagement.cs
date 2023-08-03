using AutoMobileLibrary.BussinessObject;
using AutoMobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{

    public partial class StudentManagement : Form
    {
        IStudentRepository studentRepository = new StudentRepository();
        BindingSource source;
        Student st;
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            LoadStudentList();
            dgvStudent.Columns.Add("RankedColumn", "Ranked");
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                row.Cells["RankedColumn"].Value = CalculatorSize(Convert.ToInt32(row.Cells[4].Value));
            }
        }
        private void LoadStudentList()
        {
            var students = studentRepository.GetStudents();
            try
            {
                source = new BindingSource();
                source.DataSource = students;
                txtStudenID.DataBindings.Clear();
                txtStudentName.DataBindings.Clear();
                txtGender.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtDiemTB.DataBindings.Clear();

                txtStudenID.DataBindings.Add("Text", source, "StudentID");
                txtStudentName.DataBindings.Add("Text", source, "StudentName");
                txtGender.DataBindings.Add("Text", source, "Gender");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtDiemTB.DataBindings.Add("Text", source, "DiemTB");
                //-------------------------------------------------
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = source;

                if (students.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private string CalculatorSize(int diemTB)
        {
            if (diemTB < 4)
            {
                return "Yeu";
            }
            else if (diemTB < 6.5)
            {
                return "Trung Binh";
            }
            else if (diemTB < 8)
            {
                return "Kha";
            }
            else
            {
                return "Gioi";
            }
        }
        private void ClearText()
        {
            txtStudenID.Clear();
            txtStudentName.Clear();
            txtGender.Clear();
            txtAddress.Clear();
            txtDiemTB.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                studentRepository.DeleteStudent(st.StudentID);
                LoadStudentList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private Student GetStudentObject()
        {
            Student student = null;
            try
            {
                student = new Student()
                {
                    StudentID = Convert.ToInt32(txtStudenID.Text),
                    StudentName = txtStudentName.Text,
                    Gender = txtGender.Text,
                    Address = txtAddress.Text,
                    DiemTB = float.Parse(txtDiemTB.Text)
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student()
                {
                    StudentName = txtStudentName.Text,
                    Gender = txtGender.Text,
                    Address = txtAddress.Text,
                    DiemTB = double.Parse(txtDiemTB.Text)
                };
                studentRepository.InsertStudent(student);
                MessageBox.Show("Insert student successfully");
                LoadStudentList();
                ClearText();
                txtStudentName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert student");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student()
                {
                    StudentID = int.Parse(txtStudenID.Text),
                    StudentName = txtStudentName.Text,
                    Gender = txtGender.Text,
                    Address = txtAddress.Text,
                    DiemTB = double.Parse(txtDiemTB.Text)
                };
                studentRepository.UpdateStudent(student);
                MessageBox.Show("Update student successfully");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Update student");
            }
        }
    }
}
