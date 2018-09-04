using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public enum operation
    {
        plus, subtract, multiply, divide
    }
    public partial class Form1 : Form
    {
        private double firstnumber;
        private double secondnumber;
        private double result;
        private double memory;
        private operation operation;
        

        public Form1()
        {
            InitializeComponent();
        }
                
        private void btn_plus_Click(object sender, EventArgs e)
        {
            operation = operation.plus;
            firstnumber = Convert.ToDouble(Result.Text);
            Result.Text = "";
            Sum.Text += "+";
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            operation = operation.subtract;
            firstnumber = Convert.ToDouble(Result.Text);
            Result.Text = "";
            Sum.Text += "-";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            operation = operation.multiply;
            firstnumber = Convert.ToDouble(Result.Text);
            Result.Text = "";
            Sum.Text += "*";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            operation = operation.divide;
            firstnumber = Convert.ToDouble(Result.Text);
            Result.Text = "";
            Sum.Text += "/";
        }
                
        private void btn_equals_Click(object sender, EventArgs e)
        {
            secondnumber = Convert.ToDouble(Result.Text);
            if (operation == operation.plus)
            {
                var result = firstnumber + secondnumber;
                Result.Text = result.ToString();            
            } 
            else if (operation == operation.subtract)
            {
                var result = firstnumber - secondnumber;
                Result.Text = result.ToString();               
            }
            else if (operation == operation.multiply)
            {
                var result = firstnumber * secondnumber;
                Result.Text = result.ToString();
            }
            else if (operation == operation.divide)
            {
                var result = firstnumber / secondnumber;
                Result.Text = result.ToString();
            }

            result = Convert.ToDouble(Result.Text);
            memory = result;
        }

        private void btn_memoryrecall_Click(object sender, EventArgs e)
        {
            Result.Text = memory.ToString();
            Sum.Text = memory.ToString();
        }

        private void btn_memoryclear_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(null);
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {           
            firstnumber = Convert.ToDouble(null);
            secondnumber = Convert.ToDouble(null);
            Result.Text = "";
            Sum.Text = "";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            Sum.Text = "";
        }

        private void btn_nr1_Click(object sender, EventArgs e)
        {
            Result.Text += "1";
            Sum.Text += "1";
        }

        private void btn_nr2_Click(object sender, EventArgs e)
        {
            Result.Text += "2";
            Sum.Text += "2";
        }

        private void btn_nr3_Click(object sender, EventArgs e)
        {
            Result.Text += "3";
            Sum.Text += "3";
        }

        private void btn_nr4_Click(object sender, EventArgs e)
        {
            Result.Text += "4";
            Sum.Text += "4";
        }

        private void btn_nr5_Click(object sender, EventArgs e)
        {
            Result.Text += "5";
            Sum.Text += "5";
        }

        private void btn_nr6_Click(object sender, EventArgs e)
        {
            Result.Text += "6";
            Sum.Text += "6";
        }

        private void btn_nr7_Click(object sender, EventArgs e)
        {
            Result.Text += "7";
            Sum.Text += "7";
        }

        private void btn_nr8_Click(object sender, EventArgs e)
        {
            Result.Text += "8";
            Sum.Text += "8";
        }

        private void btn_nr9_Click(object sender, EventArgs e)
        {
            Result.Text += "9";
            Sum.Text += "9";
        }

        private void btn_nr0_Click(object sender, EventArgs e)
        {
            Result.Text += "0";
            Sum.Text += "0";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            Result.Text += ".";
            Sum.Text += ".";
        }

       
    }
}
