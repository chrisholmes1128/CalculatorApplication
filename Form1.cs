using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        // Variables
        String operation = "";
        Double num = 0;
        bool command = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            //Clears the '0' once user clicks on a digit
            if ((result.Text == "0")||(command))
                result.Clear();
            command = false;
            // Here the value from the button clicked on is collected
            // and displayed to the text field (result)
            Button btn = (Button)sender;
            result.Text = result.Text + btn.Text;


        }

        // This function resets the calculator to 0 (CE)
        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            prior_entry.Text = "";
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            num = Double.Parse(result.Text);
            command = true;
            prior_entry.Text = num + " " + operation;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            prior_entry.Text = "";// Clears prior entry
        
            // This switch statement allows the operation pressed to calculate the 
            // equation the user wants
            switch(operation)
            {
                case "/":
                    result.Text = (num / Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (num * Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (num - Double.Parse(result.Text)).ToString();
                    break;
                case "+":
                    result.Text = (num + Double.Parse(result.Text)).ToString();
                    break;
                case "%":
                    result.Text = (num % Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result.Clear();
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        //Scientific Functions:

        private void sin_Click(object sender, EventArgs e)
        {
            
            prior_entry.Text = ("Sin(" + result.Text);
            double sin = Math.Sin(Double.Parse(result.Text));
            result.Text = sin.ToString();

        }

        private void Cos_Click(object sender, EventArgs e)
        {
            prior_entry.Text = ("Cos(" + result.Text);
            double cos = Math.Cos(Double.Parse(result.Text));
            result.Text = cos.ToString();
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            prior_entry.Text = ("Tan(" + result.Text);
            double tan = Math.Tan(Double.Parse(result.Text));
            result.Text = tan.ToString();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            prior_entry.Text = ("Ln(" + result.Text);
            double ln = Math.Log(Double.Parse(result.Text));
            result.Text = ln.ToString();
        }

        private void pi_Click(object sender, EventArgs e)
        {
            
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            prior_entry.Text = ("√(" + result.Text);
            double sqrt = Math.Sqrt(Double.Parse(result.Text));
            result.Text = sqrt.ToString();
        }
    }
}
