﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recept1._0
{
    public partial class Sastojci : Form
    {
        public static List<string> sastojak = new List<string>();
        Class1 class1 = new Class1(sastojak);
        int C;
        public Sastojci(int c)
        {
            C = c;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = numericUpDown1.Value + " " + comboBox1.Text + " " + textBox1.Text;
            listBox1.Items.Add(s);
            sastojak.Add(s);
            class1.SetSastojak(sastojak);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recepti recepti = new Recepti();
            recepti.Show();
            this.Close();
        }
       
        public void Sastojci_Load(object sender, EventArgs e)
        {
            
            //Class1 class1 = new Class1(sastojak);
            if (C == 0)
            {
                textBox1.Show();
                numericUpDown1.Show();
                comboBox1.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                button1.Show();
                listBox1.Show();
                listBox2.Hide();

            }
            if (C == 1)
            {
                textBox1.Hide();
                numericUpDown1.Hide();
                comboBox1.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                button1.Hide();
                listBox1.Hide();
                listBox2.Show();
                for (int i = 0; i < sastojak.Count; i++) 
                {
                    listBox2.Items.Add(sastojak[i]);
                }
            }

        }
    }
}
