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
        Student student;
        public StudentForm(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void StudenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
