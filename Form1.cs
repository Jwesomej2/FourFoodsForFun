using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourFoodsForFun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        int totalCalories = 0;
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            totalCalories += 150;
            label6.Text = totalCalories.ToString(); ;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            totalCalories += 200;
            label6.Text = totalCalories.ToString(); ;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            totalCalories += 100;
            label6.Text = totalCalories.ToString(); ;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalCalories += 130;
            label6.Text = totalCalories.ToString(); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            totalCalories -= 200;
            label6.Text = totalCalories.ToString(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalCalories = 0;
            label6.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            totalCalories -= 150;
            label6.Text = totalCalories.ToString(); ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            totalCalories -= 100;
            label6.Text = totalCalories.ToString(); ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            totalCalories -= 130;
            label6.Text = totalCalories.ToString(); ;
        }
    }
}
