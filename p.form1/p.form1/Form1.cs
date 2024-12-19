using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p.form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        Form form2 = new Form2();
        Form form3 = new Form3();


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Nav App";
            var width = 500; var height = 800;
            Point tempPoint = new Point(100, 50);
            this.DesktopLocation = tempPoint;
            int left = this.DesktopLocation.X;
            int top = this.DesktopLocation.Y;
            this.Width = width;
            this.Height = height;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            form3.Hide();

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            form3.Show();
            form2.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            form2.Hide();
            form3.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            form2.Close();
            form3.Close();  

        }
    }
}
