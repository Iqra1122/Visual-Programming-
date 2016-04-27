using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const int max = 5;
        string[] student = new string[max];

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //student[0] = t1.Text;
            //student[1] = t2.Text;
            //student[2] = t3.Text;

           MessageBox.Show("Data is saved successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder t1 = new StringBuilder();
            t1.AppendLine(student [0]);
            t1.AppendLine(student[1]);
            t1.AppendLine(student[2]);
            MessageBox.Show(t1.ToString(), "data is");

        }
    }
}
