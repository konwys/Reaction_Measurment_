using System;
using System.Media;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        SoundPlayer airhorn = new SoundPlayer(@"airhorn.wav");
        SoundPlayer slon = new SoundPlayer(@"slon.wav");
        SoundPlayer syrena = new SoundPlayer(@"syrena.wav");
        Random rnd = new Random();
        int i, j, k, l = 0;
        int s = 0;
        bool xs = false;
        bool x1 = false;
        bool x2 = false;
        bool x3 = false;
        bool p1, p2, p3 = false;

        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (xs == true)
            {
                timer1.Start();
                i++;
                int wylosowana = rnd.Next(0, 6);

                switch (wylosowana)
                {
                    case 1:
                        p1 = true;
                        airhorn.Play();

                        break;

                    case 2:
                        p2 = true;
                        slon.Play();

                        break;

                    case 3:
                        p3 = true;
                        syrena.Play();

                        break;
                }

                if (x1 == true & x2 == true & x3 == true)
                {
                    timer1.Stop();
                    int wynik;
                    wynik = (j + k + l) / 3;
                    MessageBox.Show("Twój czas reakcji to" + wynik.ToString() + "s");

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1 = true;
            airhorn.Stop();
        }

        private void bstart_Click(object sender, EventArgs e)
        {
            xs = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x2 = true;
            slon.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x3 = true;
            syrena.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            string czas = "";
            if (xs == true)
            {
                timer5.Start();

                int h = 0;
                int m = 0;

                s++;

                if (s == 10)
                {
                    m++;

                }
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

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj" + "\r\n\"" +
                "Za chwilę przystąpisz do testu Twojej reakcji" +
                "\r\n\"" + "Aby rozpocząć wcisnij START");
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                this.button1.Focus();
                this.button1.PerformClick();
            }
            if (e.KeyCode == Keys.A)
            {
                this.button2.Focus();
                this.button2.PerformClick();
            }
            if (e.KeyCode == Keys.D)
            {
                this.button3.Focus();
                this.button3.PerformClick();
            }
            if (e.KeyCode == Keys.Shift)
            {
                this.bstart.PerformClick();
            }
            if (e.KeyCode == Keys.Space)
            {
                this.button4.PerformClick();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            airhorn.Stop();
            slon.Stop();
            syrena.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (p1 == true)
            {
                timer2.Start();

                j++;
            }

            if (x1 == true)
            {
                timer2.Stop();
            }
        }



        private void timer3_Tick(object sender, EventArgs e)
        {
            if (p2 == true)
            {
                timer3.Start();
                k++;
            }

            if (x2 == true)
            {
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            if (p3 == true)
            {
                timer3.Start();
                l++;
            }

            if (x3 == true)
            {
                timer3.Stop();
            }
        }
    }


}
