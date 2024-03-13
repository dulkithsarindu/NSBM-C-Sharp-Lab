using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplecal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }


        private void InitializeComboBox()
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");

          
            comboBox1.SelectedItem = "+";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "+":
                        label4.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        label4.Text = (num1 - num2).ToString();
                        break;
                    case "*":
                        label4.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        
                        if (num2 != 0)
                            label4.Text = (num1 / num2).ToString();
                        else
                            MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Invalid operation selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
