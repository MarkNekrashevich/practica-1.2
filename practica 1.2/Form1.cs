using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practica_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения переменных a и b из текстовых полей и преобразуем их в double
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                // Вычисляем значение выражения
                double result = Math.Exp((Math.Cos(Math.Pow(b, 2)) + Math.Sin(a)) / Math.Sqrt(Math.Pow((a + b), 3))) * Math.Tan(Math.Sin(Math.PI + Math.Pow(b, 2)) / Math.Pow(Math.Cos(b - a), 2));

                // Выводим результат на текстовое поле labelResult
                label1.Text = $"Результат: {result:F4}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Неверный формат числа. Пожалуйста, введите числовое значение для всех полей.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
