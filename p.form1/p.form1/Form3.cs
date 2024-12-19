using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p.form1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var width = 1000; var height = 800;
            Point tempPoint = new Point(610, 50);
            this.DesktopLocation = tempPoint;
            this.Width = width;
            this.Height = height;

        }
        string Filename;
        FileStream FS;
        StreamReader SR;
        StreamWriter SW;

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog FD = new OpenFileDialog();
            DialogResult = FD.ShowDialog();
            if (DialogResult == DialogResult.Cancel)
                return;
            else
            {
                Filename = FD.FileName;
                FS = new FileStream(Filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                SR = new StreamReader(FS);
                SW = new StreamWriter(FS);
                Insert.Enabled = true;
                Read.Enabled = true;
                Delete.Enabled = true;
                SQUEEZE.Enabled = true;
                search.Enabled= true;
            }
        }

        private void SQUEEZE_Click(object sender, EventArgs e)
        {
            string line;
            FS.Seek(0, SeekOrigin.Begin);
            FileStream SQfile = new FileStream("SqueezeM.txt", FileMode.Create, FileAccess.Write);
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

        private void Insert_Click(object sender, EventArgs e)
        {
            FS.Seek(0, SeekOrigin.End);

            int ID = int.Parse(IDD.Text);
            string Name = Namee.Text;
            int Price = int.Parse(Pricee.Text);
            int amount = int.Parse(Amount.Text);
            
            

            string Record =IDD.Text + '|' + Name + "|" + Price + "|" + amount ;
            SW.WriteLine(Record);
            SW.Flush();
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

                if (field[0] == IDD.Text)
                {
                    FS.Seek(count, SeekOrigin.Begin);
                    SW.Write("*");
                    SW.Flush();
                }
                count += line.Length + 2;
            }
    }

            private void Read_Click(object sender, EventArgs e)
            {

                string Record = SR.ReadLine();
                string[] field;
                if (Record != null)
                {
                    field = Record.Split('|');

                    Namee.Text = field[0];
                    Pricee.Text = field[1];
                    Amount.Text = field[2];

                }
                else
                {
                    MessageBox.Show("The end of file");
                }
            }
        
        private void search_Click(object sender, EventArgs e)
        {
            string acc_num = IDD.Text;
            string record;
            string[] Field;
            

            while ((record = SR.ReadLine()) != null)
            {
                Field = record.Split('|');
                if (Field[0] == acc_num)
                {
                    IDD.Text = Field[0];
                    Namee.Text = Field[1];
                    Pricee.Text = Field[2];
                    Amount.Text = Field[3];

                    return;
                }
            }
            SR.Close();
            FS.Close();
        }



        private void IDBUY_Enter(object sender, EventArgs e)
        {
            if (IDBUY.Text == "ID")
            {
                IDBUY.Text = "";
                IDBUY.ForeColor = Color.Black;
            }

        }

        private void IDBUY_Leave(object sender, EventArgs e)
        {
            if (IDBUY.Text == "")

            {
                IDBUY.Text = "ID";
                IDBUY.ForeColor = Color.LightGray;
            }
        }
        private void NUMBUY_Enter(object sender, EventArgs e)
        {
            if (NUMBUY.Text == "NUMBER")
            {
                NUMBUY.Text = "";
                NUMBUY.ForeColor = Color.Black;
            }

        }

        private void NUMBUY_Leave(object sender, EventArgs e)
        {
            if (NUMBUY.Text == "")

            {
                NUMBUY.Text = "NUMBER";
                NUMBUY.ForeColor = Color.LightGray;
            }
        }
        private void IDSELL_Enter(object sender, EventArgs e)
        {
            if (IDSELL.Text == "ID")
            {
                IDSELL.Text = "";
                IDSELL.ForeColor = Color.Black;
            }

        }

        private void IDSELL_Leave(object sender, EventArgs e)
        {
            if (IDSELL.Text == "")

            {
                IDSELL.Text = "ID";
                IDSELL.ForeColor = Color.LightGray;
            }
        }
        private void NUMSELL_Enter(object sender, EventArgs e)
        {
            if (NUMSELL.Text == "NUMBER")
            {
                NUMSELL.Text = "";
                NUMSELL.ForeColor = Color.Black;
            }

        }

        private void NUMSELL_Leave(object sender, EventArgs e)
        {
            if (NUMSELL.Text == "")

            {
                NUMSELL.Text = "NUMBER";
                NUMSELL.ForeColor = Color.LightGray;
            }
        }

        private void BUY_Click(object sender, EventArgs e)
        {
            FS.Seek(0, SeekOrigin.Begin);
            string IDDbuy = IDBUY.Text;
            int num = int.Parse(NUMBUY.Text);
            string record;
            string[] Field;
            int count = 0;

            while ((record = SR.ReadLine()) != null)
            {
                Field = record.Split('|');
                if (Field[0] == IDDbuy)
                {

                    FS.Seek(count, SeekOrigin.Begin);

                    SW.WriteLine('*' + record);
                    FS.Seek(count, SeekOrigin.Begin);


                    int num1 =int.Parse(Field[3]);
                    num1 += num;
                    Convert.ToString(Field[3]);
                    Field[3] = Convert.ToString(num1);

                    string Record = Field[0] + "|" + Field[1] + "|" + Field[2] + '|' + Field[3];
                    SW.WriteLine(Record);
                    SW.Flush();

                    return;
                }
                count += record.Length + 2;

            }

        }

        private void SELL_Click(object sender, EventArgs e)
        {
            FS.Seek(0, SeekOrigin.Begin);
            string IDDsell = IDSELL.Text;
            int num = int.Parse(NUMSELL.Text);
            string record;
            string[] Field;
            int count = 0;

            while ((record = SR.ReadLine()) != null)
            {
                Field = record.Split('|');
                if (Field[0] == IDDsell)
                {

                    FS.Seek(count, SeekOrigin.Begin);

                    SW.WriteLine('*' + record);
                    FS.Seek(count, SeekOrigin.Begin);


                    int num1 = int.Parse(Field[3]);
                    num1 -= num;
                    Convert.ToString(Field[3]);
                    Field[3] = Convert.ToString(num1);

                    string Record = Field[0] + "|" + Field[1] + "|" + Field[2] + '|' + Field[3];
                    SW.WriteLine(Record);
                    SW.Flush();

                    return;
                }
                count += record.Length + 2;

            }

        }
    }
    }
