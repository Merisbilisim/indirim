﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSayac.Text = "0";
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            sayac++;
            lblSayac.Text =sayac.ToString();

            if (0 < 10)
            {
                lblSayac.Text=sayac.ToString();
            }

        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            sayac--;
            lblSayac.Text=sayac.ToString();
            if(0 < -10)
            {
                lblSayac.Text = sayac.ToString();

            }
        }
    }
}
