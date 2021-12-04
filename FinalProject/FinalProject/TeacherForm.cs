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
    public partial class TeacherForm : Form
    {
        private Menu menu;
        Teacher teacher;
        public TeacherForm(Teacher teacher, Menu menu)
        {
            this.teacher = teacher;
            this.menu = menu;
            this.teacher = teacher;
            InitializeComponent();
            welcomeL.Text = "Welcome back, " + teacher.name;
        }

        private void welcomeL_Click(object sender, EventArgs e)
        {

        }

        private void closeB_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menu.Visible = true;
        }
    }
}
