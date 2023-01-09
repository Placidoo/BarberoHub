using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberoHub
{
    public partial class Form1 : Form
    {

        public string BarberName;
        public string Service;
        public int Price;

        public Form1()
        {
            InitializeComponent();
            HidePages();
            page1.Show();
            this.Size = new Size(1024, 1016);
            page1.Location = new Point(0, 0);
        }

        void HidePages()
        {
            page1.Hide();
            page2.Hide();
            page3.Hide();
            page4.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HidePages();
            page2.Show();
            page2.Location = new Point(0, 0);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            HidePages();
            page1.Show();
            page1.Location = new Point(0, 0);
        }

        void _Page3()
        {
            HidePages();
            label23.Hide();
            label16.Text = BarberName;
            label14.Text = "PHP " + Price + ".00";
            pictureBox13.Image = null;
            Service = null;
            label22.Text = "";
            page3.Show();
            page3.Location = new Point(0, 0);
        }
        private void label12_Click(object sender, EventArgs e)
        {
            HidePages();
            page2.Show();
            page2.Location = new Point(0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BarberName = "Tom Marquez";
            pictureBox9.Image = Properties.Resources._1;
            Price = 80;
            _Page3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BarberName = "Emman Del Mundo";
            pictureBox9.Image = Properties.Resources._2;
            Price = 75;
            _Page3();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BarberName = "Robert Domingo";
            pictureBox9.Image = Properties.Resources._3;
            Price = 70;
            _Page3();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label23.Hide();
            pictureBox13.Image = Properties.Resources.haircut;
            Service = "Haircut";
            label22.Text = Service;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            label23.Hide();
            pictureBox13.Image = Properties.Resources.beard;
            Service = "Beard Trimming";
            label22.Text = Service;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label23.Hide();
            pictureBox13.Image = Properties.Resources.styling;
            Service = "Hair Styling";
            label22.Text = Service;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Service == null)
            {
                label23.Show();
            }
            else
            {
                HidePages();
                page4.Show();
                page4.Location = new Point(0, 0);
                label30.Text = BarberName;
                label31.Text = Service;
                label32.Text = "PHP " + Price + ".00";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HidePages();
            page1.Show();
            page1.Location = new Point(0, 0);
            BarberName = null;
            Service = null;
            Price = 0;
        }
    }
}
