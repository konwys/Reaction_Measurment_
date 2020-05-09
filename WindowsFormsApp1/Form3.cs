using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Random rnd = new Random();
        Timer t = new Timer();
        private bool bt_start_clicked = false;
        int s = 0; // zmienne uzywane do timerow 
        int i = 0;
        int j = 0;
        int k = 0;
        int p = 0;
        int o = 0;
        private bool x1 = false; // zmienne gdy pojawia sie obrazek
        private bool x2 = false;
        private bool x3 = false;
        private bool x4 = false;
        private bool y1 = false; // zmienne gdy wciskamy button
        private bool y2 = false;
        private bool y3 = false;
        private bool y4 = false;

        int licznik = 0;
        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {


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

                }

            }

        }

        private void b_start_Click(object sender, EventArgs e)
        {
            bt_start_clicked = true;
        }

        private void bstop_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            y1 = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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

            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e) // obsluga klawiatury
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
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            o++;
            if (o == 1)
            {
                MessageBox.Show("Witaj w fazie szkoleniowej" + "\r\n\"" +
                "*Po wciśnięciu START w różnych miejscach wyświetlą się obrazki " +
                "\r\n\"" + "*Pod obrazkami znajduja się guziki, które musisz wcisnąć po pojawieniu się obrazka" + "\r\n"
                + "*W ten sposób zmierzymy czas Twojej reakcji " + "\r\n\"" + "*Numery na guzikach odpowiadają klawiszą na NumPadzie" + "\r\n\"" + "*Aby zakończyć wciśnij KONIEC");

            }
        }
    }

}
