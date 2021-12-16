using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] pb = new PictureBox[9];
        int sirano, adimsayisi, skorx = 0, skoro = 0;
        string sirakimde;

        private void Form1_Load(object sender, EventArgs e)
        {
            adimsayisi = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sirano = i * 3 + j;

                    pb[sirano] = new PictureBox();
                    pb[sirano].Parent = this;
                    pb[sirano].Size = new Size(40, 40);
                    pb[sirano].Location = new Point(90 + j * 40, 50 + i * 40);
                    pb[sirano].Click += new EventHandler(pbtikla);
                    pb[sirano].BorderStyle = BorderStyle.FixedSingle;
                    pb[sirano].SizeMode = PictureBoxSizeMode.StretchImage;
                    pb[sirano].Tag = sirano * -1 - 1;
                }
            }
            sirakimde = "X";



        }

        private void pbtikla(object sender, EventArgs e)
        {
            adimsayisi = adimsayisi + 1;
            if (sirakimde == "X") { (sender as PictureBox).Image = Image.FromFile("G:/Görsel Programlama/WindowsFormsApplication4/x1.png"); (sender as PictureBox).Tag = 1; }
            else { (sender as PictureBox).Image = Image.FromFile("G:/Görsel Programlama/WindowsFormsApplication4/o1.png"); (sender as PictureBox).Tag = 0; }
            (sender as PictureBox).Enabled = false;
            kontrol();
            if (sirakimde == "X") { sirakimde = "O"; }
            else { sirakimde = "X"; }
        }

        private void kontrol()
        {
            string bir, iki, uc, dort, bes, alti, yedi, sekiz, dokuz;
            bir = pb[0].Tag.ToString();
            iki = pb[1].Tag.ToString();
            uc = pb[2].Tag.ToString();
            dort = pb[3].Tag.ToString();
            bes = pb[4].Tag.ToString();
            alti = pb[5].Tag.ToString();
            yedi = pb[6].Tag.ToString();
            sekiz = pb[7].Tag.ToString();
            dokuz = pb[8].Tag.ToString();

            if (
                bir == iki && bir == uc ||
                dort == bes && dort == alti ||
                yedi == sekiz && yedi == dokuz ||
                bir == dort && bir == yedi ||
                iki == bes && iki == sekiz ||
                uc == alti && uc == dokuz ||
                bir == bes && bir == dokuz ||
                uc == bes && uc == yedi)
            {
                MessageBox.Show(" Bitti " + sirakimde + "  Oyuncusu kazandı !");
                if (sirakimde == "X") { skorx = skorx + 1; }
                else { skoro = skoro + 1; }
                label1.Text = "X = " + skorx.ToString();
                label2.Text = "O = " + skoro.ToString();

            }

            else if (adimsayisi == 9)
            {

                MessageBox.Show("BİTTİ BERABERE !");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                pb[i].Dispose();

            }
            Form1_Load(sender, e);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        
            {
                for (int i = 0; i < 9; i++)
                {
                    pb[i].Dispose();

                }
                Form1_Load(sender, e);

            }
        }


    }

