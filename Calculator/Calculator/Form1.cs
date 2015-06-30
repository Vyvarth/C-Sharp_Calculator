using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int num01;
        int num02;
        int finalNum;
        string mathOperator;


        public Form1()
        {
            InitializeComponent();
        }
        //2
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }
        //=
        //Gets the second number, detirmines what math operator to use and performs the calculation an appends it to textBox1
        private void button2_Click(object sender, EventArgs e)
        {
            getNum02();
            textBox1.Text = "";
            if(mathOperator == "+")
            {
                finalNum = num01 + num02;
            } else if(mathOperator == "-")
            {
                finalNum = num01 - num02;
            } else if(mathOperator == "*")
            {
                finalNum = num01 * num02;
            } else if(mathOperator == "/")
            {
                finalNum = num01 / num02;
            }
            textBox1.AppendText(finalNum.ToString());
            label1.Text = "";

        }
        //1
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }
        //3
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }
        //0
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }
        //+
        private void button6_Click(object sender, EventArgs e)
        {
            getNum01();
            mathOperator = "+";
            label1.Text = textBox1.Text + mathOperator;
            textBox1.Text = "";
        }
        //Gets the number inputted into textBox1 and converts it to an int
        public void getNum01()
        {
            num01 = Convert.ToInt32(textBox1.Text); 
        }
        //Gets the second number inputted into textBox1 and converts it to an int
        public void getNum02()
        {
            num02 = Convert.ToInt32(textBox1.Text);
        }
        //5
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }
        //4
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }
        //6
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }
        //7
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }
        //8
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }
        //9
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }
        //C
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            num01 = 0;
            num02 = 0;
            label1.Text = "";
        }
        //-
        private void button7_Click(object sender, EventArgs e)
        {
            getNum01();
            mathOperator = "-";
            label1.Text = textBox1.Text + mathOperator;
            textBox1.Text = "";
        }
        //*
        private void button15_Click(object sender, EventArgs e)
        {
            getNum01();
            mathOperator = "*";
            label1.Text = textBox1.Text + mathOperator;
            textBox1.Text = "";
        }
        // '/'
        private void button16_Click(object sender, EventArgs e)
        {
            getNum01();
            mathOperator = "/";
            label1.Text = textBox1.Text + mathOperator;
            textBox1.Text = "";
        }
    }
}
