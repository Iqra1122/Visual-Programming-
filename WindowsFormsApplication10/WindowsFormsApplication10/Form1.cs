using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder s=new StringBuilder();
            if (checkBox1.Checked)
            {
                s.AppendLine(checkBox1.Text);
            }
            if (checkBox2.Checked)
            {
                s.AppendLine(checkBox2.Text);
            }
            if(checkBox3.Checked)
            {
                s.AppendLine(checkBox3.Text);
            }
            if(radioButton1.Checked)
            {
                s.AppendLine(radioButton1.Text);
            }
            if(radioButton2.Checked)
            {
                s.AppendLine(radioButton2.Text);
            }
             if(radioButton3.Checked)
             {
                 s.AppendLine(radioButton3.Text);
             }
             MessageBox.Show(s.ToString(), "Selected items are");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = listBox1.SelectedItem.ToString();
        }


        }
    }
