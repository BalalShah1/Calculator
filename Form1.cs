using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalc
{
    public partial class Calculator : Form
    {
        private double value = 0;
        private string operation = " ";
        private bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;

            var b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    {
                        result.Text = (value + Double.Parse(result.Text)).ToString();
                        break;
                    }

                case "-":
                    {
                        result.Text = (value - Double.Parse(result.Text)).ToString();
                        break;
                    }

                case "*":
                    {
                        result.Text = (value * Double.Parse(result.Text)).ToString();
                        break;
                    }

                case "/":
                    {
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                        break;
                    }

                default:
                    break;
            }

            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}
