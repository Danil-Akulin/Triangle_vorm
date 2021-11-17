using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projejct.v._2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear(); //Очистка формы от значений
            }
            if (num1.Text.Length > 0 && num2.Text.Length > 0 && num3.Text.Length > 0) // Проверка на введённые символы
            {
                double a, b, c;
                a = Convert.ToDouble(num1.Text);
                b = Convert.ToDouble(num2.Text);
                c = Convert.ToDouble(num3.Text);
                Triangle triangle = new Triangle(a, b, c);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Высота h");
                listView1.Items.Add("Периметр");
                listView1.Items[0].SubItems.Add(triangle.outputA());                     //заполняет первую ячейку
                listView1.Items[1].SubItems.Add(triangle.outputB());                     //заполняет вторую ячейку
                listView1.Items[2].SubItems.Add(Convert.ToString(triangle.Surfaces_v()));//заполняет третью ячейку
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();             
            f1.Show();                  //отвечает за переход на первую форму
            this.Hide();                // отвечает за скрытие формы
        }


    }
}