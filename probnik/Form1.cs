using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probnik
{
    public partial class Form1 : Form
    {
        DAL dal = new DAL();
        public Form1()
        {
            InitializeComponent();
            ArrayList getStud = dal.GetStud();
            dataGridView1.DataSource = getStud; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dal.SaveNewStud(textBox1.Text, Int32.Parse(textBox2.Text), textBox3.Text, textBox4.Text))
            {

                this.Hide();
                MessageBox.Show("Данные успешно добавлены");


            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dal.DeleteStud(Int32.Parse(textBox5.Text)))
            {
                this.Hide();
                MessageBox.Show("Строка успешно удалена");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void должникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
