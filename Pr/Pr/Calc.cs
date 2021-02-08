using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        public static double sum(double a, double b)
        {
            return a + b;
        }
        public static double razn(double a, double b)
        {
            return a - b;
        }
        public static double umnozh(double a, double b)
        {
            return a * b;
        }
        public static double delenie(double a, double b)
        {
            return a / b;
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            try
            {
                labelResult.Text = "Результат: " + Convert.ToString(sum(Convert.ToDouble(textBoxChislo1.Text), Convert.ToDouble(textBoxChislo2.Text)));
            }
            catch (Exception) { MessageBox.Show("Введите число"); }
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            try
            {
                labelResult.Text = "Результат: " + Convert.ToString(razn(Convert.ToDouble(textBoxChislo1.Text), Convert.ToDouble(textBoxChislo2.Text)));
            }
            catch (Exception) { MessageBox.Show("Введите число"); }
        }

        private void buttonDelenie_Click(object sender, EventArgs e)
        {
            try
            {
                labelResult.Text = "Результат: "  +Convert.ToString(delenie(Convert.ToDouble(textBoxChislo1.Text), Convert.ToDouble(textBoxChislo2.Text)));
            }
            catch (Exception) { MessageBox.Show("Введите число"); }
        }

        private void buttonUmnozh_Click(object sender, EventArgs e)
        {
            try
            {
                labelResult.Text = "Результат: " + Convert.ToString(umnozh(Convert.ToDouble(textBoxChislo1.Text), Convert.ToDouble(textBoxChislo2.Text)));
            }
            catch (Exception) { MessageBox.Show("Введите число"); }
        }
    }
}
