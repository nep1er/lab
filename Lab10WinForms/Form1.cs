using System;
using System.Drawing.Printing;

namespace Lab8WinForms
{
    public partial class Form1 : Form
    {
        double a, b, x, y, z, Zoo;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateStatus()
        {
            double result = 0;

            if (toolStripComboBox3.Text == "Уравнение 1")
            {
                result = (Math.Pow(x, 3) + y) / (Math.Pow(y, 2) + 1);
            }
            else if (toolStripComboBox3.Text == "Уравнение 2")
            {
                result = Math.Sqrt((x / (y + 1)) + y);
            }

            toolStripStatusLabel1.Text = $"Результат: {result:F2}";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            UpdateStatus();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void UpdateResult()
        {
            try
            {
                a = double.Parse(toolStripComboBox1.Text);
                b = double.Parse(toolStripComboBox2.Text);
                x = double.Parse(toolStripTextBox1.Text);
                y = double.Parse(toolStripTextBox2.Text);
                z = double.Parse(toolStripTextBox3.Text);
                Zoo = algebta(z, a, b, x, y);
                Text = Zoo.ToString();
            }
            catch
            {
            }
        }

        private double algebta(double x, double y, double a, double b, double z)
        {
            return a * x + (b - a) * y + Math.Sin(z);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox3.SelectedIndex = 0;
        }
    }


}
