using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bİLGİ_yARIŞMASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru_no = 0;
        int doğru   = 0;
        int yanlış  = 0;
        int süre    = 40 ;
        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button6.Text = "İleri";
            button1.Enabled = true; button2.Enabled = true;
            button3.Enabled = true; button4.Enabled = true;
            soru_no++;
            label1.Text = soru_no.ToString() + ". Soru";
            if (soru_no == 1)
            {
                richTextBox1.Text = "Musatafa Kemal kaç yılında doğmuştur?";
                button1.Text = "1920";
                button2.Text = "1923";
                button3.Text = "1881";
                button4.Text = "1877";
                label3.Text = 1881.ToString();
            }
            if (soru_no == 2)
            {
                richTextBox1.Text = "Türkiyede kaç coğrafi bölge vardır ?";
                button1.Text = "7";
                button2.Text = "13";
                button3.Text = "11";
                button4.Text = "5";
                label3.Text=7.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            richTextBox1.Enabled=false;
            label3.Visible = false;
            label2.Visible = false;
            button1.Enabled = false; button2.Enabled = false;
            button3.Enabled = false; button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text=button1.Text;
            if(label3.Text== label2.Text)
            {
                doğru++;
                label6.Text=doğru.ToString();
            }
            else
            {
                yanlış++;
                label7.Text=yanlış.ToString();
            }
            button1.Enabled = false; button2.Enabled=false;
            button3.Enabled=false;button4.Enabled=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = button2.Text;
            if (label3.Text == label2.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label7.Text = yanlış.ToString();
            }
            button1.Enabled = false; button2.Enabled = false;
            button3.Enabled = false; button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = button3.Text;
            if (label3.Text == label2.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label7.Text = yanlış.ToString();
            }
            button1.Enabled = false; button2.Enabled = false;
            button3.Enabled = false; button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = button4.Text;
            if (label3.Text == label2.Text)
            {
                doğru++;
                label6.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label7.Text = yanlış.ToString();
            }
            button1.Enabled = false; button2.Enabled = false;
            button3.Enabled = false; button4.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text=süre.ToString();
            süre = süre - 1;
            if (süre == 0)
            {
                timer1.Enabled = false;
                yanlış++;
                label7.Text = yanlış.ToString();
                button1.Enabled=false;
                button2.Enabled=false;
                button3.Enabled=false;
                button4.Enabled=false;
                button6.Enabled=false;
            }
        }
    }
}
