using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class StudentForm : Form
    {
        private Student student;
        private Menu menu;
        public StudentForm(Student student, Menu menu)
        {
            this.student = student;
            this.menu = menu;
            InitializeComponent();
            welcomeL.Text = "Welcome back, " + student.name;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
