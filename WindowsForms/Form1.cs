using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        private List<Student> _students;
        public Form1()
        {
            InitializeComponent();
            _students = new List<Student>();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string fname = txtFirstname.Text.Trim();
            string lname = txtLastname.Text.Trim();
            string email = txtEmail.Text.Trim();

            Student student;
            try
            {
                student = new Student
                { Firstname = fname,
                  Lastname = lname,
                  Email = email
                };
            }
            catch (Exception )
            {

                MessageBox.Show("Please, fill valid values for student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _students.Add(student);
            FillStudentsLB();
        }
        private void FillStudentsLB()
        {
            lstbStudent.Items.Clear();
            foreach ( Student stu in _students)
            {
                lstbStudent.Items.Add(stu);
            }
        }
    }
}
