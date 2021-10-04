using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student Student = new Student();

            Student.setname("Gabriel");
            MessageBox.Show(Student.getname());
            MessageBox.Show(Student.playBasketball());

            Teacher Teacher = new Teacher();
            Teacher.setname(" Carlos");
            MessageBox.Show(Teacher.getname());
            MessageBox.Show(Teacher.playBasketball());

        }
    }
}
