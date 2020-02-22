using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(multiply(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(devide(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(substract(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        public static double sum(double a, double b) // Сумма 
        {
            return a + b;
        }
        public static double devide(double a, double b) // Деление 
        {
            return a / b;
        }
        public static double substract(double a, double b) // Вычетание 
        {
            return a - b;
        }
        public static double multiply(double a, double b) // Умножение 
        {
            return a * b;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
