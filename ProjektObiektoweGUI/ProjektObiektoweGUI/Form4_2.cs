using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjektObiektoweGUI
{
    public partial class Form4_2 : Form
    {
        public Form4_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ()
            {
                SpisTransakcji.SpisTrans.Add(
                    new Transakcja((Transakcja.Platformy)comboBox1.SelectedItem, (Transakcja.Rodzaje)comboBox2.DataSource,
                    Decimal.Parse(textBox1.Text), comboBox3.SelectedIndex ,textBox2.Text, (SpisOdbiorców.)comboBox4.SelectedItem,comboBox1.Controls));
                this.Close();
            }
            //Form1.Form2x.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
