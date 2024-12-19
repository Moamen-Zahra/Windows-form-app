using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Xml.Linq;
using System.Reflection;

namespace p.form1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var width = 1000; var height = 800;
            Point tempPoint = new Point(610, 50);
            this.DesktopLocation = tempPoint;
            this.Width = width;
            this.Height = height;   
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "6 Digits")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6 Digits";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "To third name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "To third name")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "yyyy/mm/dd")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "yyyy/mm/dd";
                textBox4.ForeColor = Color.LightGray;
            }
        }
        string Filename;
        FileStream FS;
        StreamReader SR;
        StreamWriter SW;
        private void button1_Click(object sender, EventArgs e)
        {
            




            OpenFileDialog FD = new OpenFileDialog();
            DialogResult = FD.ShowDialog();
            if (DialogResult == DialogResult.Cancel)
                return;
            else { 
            Filename = FD.FileName;
            FS = new FileStream (Filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SR = new StreamReader (FS);
            SW = new StreamWriter (FS);
                Insert.Enabled = true;
                Read.Enabled = true;
                Delete.Enabled = true;
                Clear.Enabled = true;
                Start.Enabled = true;
                Emd.Enabled = true;
                SQUEEZE.Enabled = true;

            }
    }

        private void Insert_Click(object sender, EventArgs e)
        {

            FS.Seek (0, SeekOrigin.End);
            long loc = FS.Position;
            int ID = int.Parse(textBox1.Text);
            string Name = textBox2.Text;
            string birth = textBox4.Text;
            string Gender = textBox3.Text;
            string phone = textBox5.Text;

            insert_key(ID, loc);

            string Record = textBox1.Text + "|" + textBox2.Text + "|" + textBox4.Text + "|" + textBox3.Text + "|" + textBox5.Text;
            SW.WriteLine (Record);
            SW.Flush ();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox1.ForeColor = Color.Black;
            textBox2.Text = ""; textBox2.ForeColor = Color.Black;
            textBox4.Text = ""; textBox4.ForeColor = Color.Black;
            string Record = SR.ReadLine ();
            string[] field;
            if (Record != null)
            {
                field = Record.Split('|');
                textBox1.Text = field[0] ;
                textBox2.Text = field[1] ;
                textBox4.Text = field[2] ;
                textBox3.Text = field[3];
                textBox5.Text = field[4];
            }
            else
            {
                MessageBox.Show("The end of file");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            FS.Seek(0, SeekOrigin.Begin);
            FS.Flush();
            SW.Flush();
            string line;
            string[] field;
            int count = 0;
            while ((line = SR.ReadLine()) != null)
            {
                field = line.Split('|');

                if (field[0] == textBox1.Text)
                {
                    FS.Seek(count, SeekOrigin.Begin);
                    SW.Write("*");
                    SW.Flush();
                }
                count += line.Length + 2;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6 Digits"; textBox1.ForeColor = Color.LightGray;
            textBox2.Text = "To third name"; textBox2.ForeColor = Color.LightGray;
            textBox4.Text = "yyyy/mm/dd"; textBox4.ForeColor = Color.LightGray;
            textBox3.Text = null;
            textBox5.Text = null;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            FS.Seek(0, SeekOrigin.Begin);
            MessageBox.Show("Begin of the file");
        }

        private void Emd_Click(object sender, EventArgs e)
        {
            FS.Seek(0, SeekOrigin.End);
            MessageBox.Show("End of the file");

        }
        FileStream IS;
        StreamReader IR;
        StreamWriter IW;
        int n_rec = 0;
        int key_len = 10, loc_len = 10;
        int[] keys = new int[100];
        int[] locs = new int[100];
        void insert_key(int k, long newloc)
        {
         
        }

        private void rewrite_index_Click(object sender, EventArgs e)
        {
            

        }

        private void SQUEEZE_Click(object sender, EventArgs e)
        {
            string line;
            FS.Seek(0, SeekOrigin.Begin);
            FileStream SQfile = new FileStream("Squeeze.txt", FileMode.Create, FileAccess.Write);
            StreamWriter SQwriter = new StreamWriter(SQfile);
            while ((line = SR.ReadLine()) != null)
            {
                if (line[0] != '*')
                {
                    SQwriter.WriteLine(line);
                    SQwriter.Flush();
                }
            }
            SQwriter.Close();
            SQfile.Close();

        }
        
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string acc_num = textBox1.Text;
            string record ;
            string[] Field;
            textBox2.ForeColor = Color.Black;
            textBox4.ForeColor = Color.Black;

            while ((record = SR.ReadLine()) != null)
            {
                Field = record.Split('|');
                if (Field[0] == acc_num)
                {
                    textBox1.Text = Field[0];
                    textBox2.Text = Field[1];
                    textBox4.Text = Field[2];
                    textBox3.Text = Field[3];
                    textBox5.Text = Field[4];
                    return;
                }
            }
            SR.Close();
            FS.Close();
        }

        private void load_index_Click(object sender, EventArgs e)
        {
            
        }

        



    }
}
