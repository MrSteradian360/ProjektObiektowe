﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form6_2 : Form
    {
        public Form6_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                textBox4.Text != "")
            {
                SpisDostawców.SpisDost.Add(
                    new Dostawca(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text));
                this.Close();
            }
            //Form1.Form2x.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_2_Load(object sender, EventArgs e)
        {

        }
    }
}
