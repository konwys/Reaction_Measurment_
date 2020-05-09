using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        Timer t = new Timer();
        private bool bt_start_clicked = false;
        int s = 0; // zmienne uzywane do timerow 
        public int i = 0;
        public int j = 0;
        public int k = 0;
        public int p = 0;
        private bool x1 = false; // zmienne gdy pojawia sie obrazek
        private bool x2 = false;
        private bool x3 = false;
        private bool x4 = false;

        private bool y1 = false; // zmienne gdy wciskamy button
        private bool y2 = false;
        private bool y3 = false;
        private bool y4 = false;
        wykres wyk;

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj" + "\r\n\"" +
                "Za chwilę przystąpisz do testu Twojej reakcji" +
                "\r\n\"" + "Aby rozpocząć wcisnij START");
            chart1.Visible = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bt_start_clicked == true)
            {
                int wylosowana = rnd.Next(0, 6);

                switch (wylosowana)
                {
                    case 1:
                        x1 = true;
                        this.pictureBox1.Load(@"zielone.jpg");
                        break;

                    case 2:
                        x2 = true;
                        this.pictureBox2.Load(@"zielone.jpg");
                        break;

                    case 3:
                        x3 = true;
                        this.pictureBox3.Load(@"zielone.jpg");
                        break;

                    case 4:
                        x4 = true;
                        this.pictureBox4.Load(@"zielone.jpg");
                        break;

                }
                if (y1 == true & y2 == true & y3 == true & y4 == true)
                {
                    timer1.Stop();
                    timer2.Stop();

                    int wynik;
                    wynik = (i + j + k + p) / 4;
                    MessageBox.Show("Twój średni czas reakcji wynosi " + wynik.ToString() + "s");
                }

            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void bstart_Click(object sender, EventArgs e)
        {
            bt_start_clicked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            y4 = true;
            this.pictureBox4.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            y3 = true;
            this.pictureBox3.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y2 = true;
            this.pictureBox2.Image = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            y1 = true;
        }


        // timer główny
        private void timer2_Tick(object sender, EventArgs e)
        {
            string czas = "";
            if (bt_start_clicked == true)
            {
                int h = 0;
                int m = 0;
                s++;
                if (s == 60)
                {
                    m++;

                }
                if (m == 60)
                {
                    h++;
                }

                ///////////// wyswieltanie czasu

                if (h < 10)
                {
                    czas += "0" + h;
                }
                else
                {
                    czas += h;
                }

                czas += ":";

                if (m < 10)
                {
                    czas += "0" + m;
                }
                else
                {
                    czas += m;
                }
                czas += ":";

                if (s < 10)
                {
                    czas += "0" + s;
                }
                else
                {
                    czas += s;
                }

                label1.Text = czas;
                if (s == 10 & y1 == false & y2 == false & y3 == false & y4 == false)
                {
                    this.Close();
                }
            }

        }

        // timery liczace czas reakcji 
        private void timer3_Tick(object sender, EventArgs e)
        {

            if (x1 == true)
            {
                timer3.Start();
                i++;
            }


            if (y1 == true)
            {
                timer3.Stop();
            }


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (x2 == true)
            {
                timer4.Start();
                j++;
            }

            if (y2 == true)
            {
                timer4.Stop();
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (x3 == true)
            {
                timer5.Start();
                k++;
            }

            if (y3 == true)
            {
                timer5.Stop();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (x4 == true)
            {
                timer6.Start();
                p++;
            }

            if (y4 == true)
            {
                timer6.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad3)
            {
                this.button1.Focus();
                this.button1.PerformClick();

            }
            if (e.KeyCode == Keys.NumPad1)
            {
                this.button2.Focus();
                this.button2.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                this.button3.Focus();
                this.button3.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad7)
            {
                this.button4.Focus();
                this.button4.PerformClick();
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.b_start.Focus();
                this.b_start.PerformClick();
            }
        } // obsluga klawiatury

        private void bstop_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 3;
        }

    }
}
