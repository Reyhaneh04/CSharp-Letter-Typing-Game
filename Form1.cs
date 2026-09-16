using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace فعالیت_منزل_191
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
            timer1.Enabled = true;
            Random rnd = new Random();
            char letter = (char)rnd.Next(65, 91);
            label3.Text = letter.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int code = (int)char.Parse(label3.Text);
            if (e.KeyValue == code)
            {
                label5.Text = (int.Parse(label5.Text) + 1).ToString();
                Console.Beep(1500, 200);
                Random rnd = new Random();
                char letter = (char)rnd.Next(65, 91);
                label3.Text = letter.ToString();
            }
            else
            {
                timer1.Enabled = false;
                Console.Beep(500, 1500);
                MessageBox.Show("شما بازنده شدید");
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = (int.Parse(label4.Text) - 1).ToString();
            if (label4.Text=="0")
            {
                timer1.Enabled = false;
                int score = int.Parse(label5.Text);
                if (score >= 30)
                    MessageBox.Show("عالی");
                else if (score >= 25)
                    MessageBox.Show("خیلی خوب");
                else if (score >= 20)
                    MessageBox.Show("خوب");
                else if (score >= 15)
                    MessageBox.Show("متوسظ");
                else if (score >= 10)
                    MessageBox.Show("ضعیف");
            }
        }
    }
}
