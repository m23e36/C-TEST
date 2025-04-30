using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            string text = textBox1.Text;
            // إذا آخر محرف هو نقطتين، نحذفها
            if (textBox1.Text.EndsWith(".."))
            {
                textBox1.Text = text.Substring(0, text.Length - 1);
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            string text = textBox1.Text;
            // إذا آخر محرف هو فاصلتين، نحذفها
            if (textBox1.Text.EndsWith(",,"))
            {
                textBox1.Text = text.Substring(0, text.Length - 1);
            }
        }


        private void button19_Click(object sender, EventArgs e)
        {

            double x = double.Parse(textBox1.Text);
            textBox1.Text = Math.Sqrt(x).ToString();
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            string[] parts = input.Split(',');
            // تحويل القيمتين إلى double
            double baseNumber = double.Parse(parts[0]);
            double exponent = double.Parse(parts[1]);

            // حساب القوة
            double result = Math.Pow(baseNumber, exponent);
            // عرض الناتج في TextBox
            textBox1.Text = result.ToString();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //برمجة زر الحذف 
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

        }
        private void button17_Click(object sender, EventArgs e)
        {

            string text = textBox1.Text;

            // المتغيرات لتخزين الرقمين والعملية
            double num1, num2;
            char operation = ' ';

            // البحث عن العملية داخل النص
            foreach (char c in text)
            {
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    operation = c;
                    break;
                }
            }

            // تقسيم النص بناءً على العملية
            string[] parts = text.Split(operation);

            // تحويل الأجزاء إلى أرقام
            if (parts.Length == 2 &&
                double.TryParse(parts[0], out num1) &&
                double.TryParse(parts[1], out num2))
            {
                double result = 0;
                switch (operation)
                {
                    case '+': result = num1 + num2;  break;                   
                    case '-': result = num1 - num2;break;
                    case '*':   result = num1 * num2;  break;                               
                    case '/':
                    if (num2 != 0)  result = num1 / num2;
                    else
                    MessageBox.Show("لا يمكن القسمة على صفر");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                   break;                   
                }

                //عرض الناتج
                textBox1.Text = (result.ToString());
            }
        }

        
    }
}
