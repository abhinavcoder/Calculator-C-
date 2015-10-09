using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        Stack stack = new Stack();

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button2.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button7.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + button12.Text;
        }
        private void button4_Click(object sender, EventArgs e)   // dot
        {
            textBox2.Text = textBox2.Text + button4.Text;
        }

        private void button18_Click(object sender, EventArgs e)   //clear
        {
            textBox2.Clear();
        }
        double total1 = 0 ;
        double total2 = 0 ;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool divideButtonCLicked = false;

        
       
        private void button17_Click(object sender, EventArgs e)   //sum 
        {
            textBox3.Text = textBox2.Text + " " + button17.Text; 
            total1 = total1 + double.Parse(textBox2.Text);
            stack.Push(double.Parse(textBox2.Text));
            stack.Push("+");
            textBox2.Clear();

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonCLicked = false;
        }

        private void button3_Click(object sender, EventArgs e)    //equal 
        {
            textBox3.Clear();
            if (plusButtonClicked == true)
                total2 = total1 + double.Parse(textBox2.Text);
            else
            {
                if (minusButtonClicked == true)
                    total2 = total1 - double.Parse(textBox2.Text);
                else
                {
                    if (multiplyButtonClicked == true)
                        total2 = total1 * double.Parse(textBox2.Text);
                    else
                        total2 = total1 / double.Parse(textBox2.Text);
                }
            }
            textBox2.Text = total2.ToString();
            total1 = 0;
        }

        private void button15_Click(object sender, EventArgs e)  //minus 
        {
            textBox3.Text = textBox2.Text + " " + button15.Text;
            total1 = total1 + double.Parse(textBox2.Text);
            stack.Push(double.Parse(textBox2.Text));
            stack.Push("-");
            textBox2.Clear();

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonCLicked = false;

        }

        private void button16_Click(object sender, EventArgs e)  //multiply
        {
            textBox3.Text = textBox2.Text + " " + button16.Text;
            total1 = total1 + double.Parse(textBox2.Text);
            stack.Push(double.Parse(textBox2.Text));
            stack.Push("*");
            textBox2.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonCLicked = false;
        }

        private void button14_Click(object sender, EventArgs e)  //divide 
        {
            textBox3.Text = textBox2.Text + " " + button14.Text;
            total1 = total1 + double.Parse(textBox2.Text);
            stack.Push(double.Parse(textBox2.Text));
            stack.Push("/");
            textBox2.Clear();

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonCLicked = true;
        }




    }
}
