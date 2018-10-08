﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Bitmap kaynak;

        public Form2()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renkgetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xKor.Text);
            int y = int.Parse(yKor.Text);

            Color rengim = kaynak.GetPixel(x, y);
            renkBox.BackColor = rengim;
            Console.WriteLine("R: " + rengim.R + " G: " + rengim.G + " B: " + rengim.B);

        }
    }
}
