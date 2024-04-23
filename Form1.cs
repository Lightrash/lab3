using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(SideTextBox.Text, out double side))
            {
                double area = side * side;

                resultLabel.Text = $"Площа квадрата: {area}";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректне число для сторони квадрата.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
