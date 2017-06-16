using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RandomStringGenerator;

namespace pseudorandomstring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyRandomStringGenerator RSG = new MyRandomStringGenerator();
            RSG.UseSpecialCharacters = false;
            label1.Text = RSG.Generate(10);

          
            if (textBox1.Text.Length == 0)  {
                textBox1.Text = label1.Text; } else
            {
                textBox1.Text = textBox1.Text + System.Environment.NewLine + label1.Text;
            }


            
            
                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
