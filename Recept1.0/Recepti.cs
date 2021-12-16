using System;
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
    public partial class Recepti : Form
    {
        public static List<string> sastojak = new List<string>();
        public static List<string> a = new List<string>();
        private List<string> recept = new List<string>();
        Class1 class1 = new Class1(sastojak);
        public Recepti()
        {
            InitializeComponent();
        }

        //dodavanje sastojka
        private void button1_Click(object sender, EventArgs e)
        {
            if (a.Contains(textBox3.Text))
            {
                MessageBox.Show("Već ste dodali ovaj sastojak");
                textBox3.Text = "";
                return;
            }

            if (textBox3.Text == "")
                return;

            string s = textBox3.Text.ToLower();
            a.Add(s);
            listBox2.Items.Add(s);
            sastojak.Add(s);
            class1.SetSastojak(sastojak);

            textBox3.Text = "";
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //dodavanje recepta
        private void button3_Click(object sender, EventArgs e)
        {
            string NazivJela = textBox1.Text;
            string TipJela = comboBox1.Text;
            string Recept = textBox2.Text;

            if (a.Contains(NazivJela))
            {
                MessageBox.Show("Imate već recept sa tim imenom");
                return;
            }
            if (sastojak.Count < 3)
            {
                MessageBox.Show("Morate imati bar 3 sastojka");
                return;
            }

            a.Add(NazivJela);
            Class1 c = new Class1(NazivJela, TipJela, Recept, sastojak);
            recept.Add(NazivJela + " " + TipJela + " " + sastojak + " " + Recept);
            listBox1.Items.Add(c.ToString());
            c.SetNazivRecepta(NazivJela);
            c.SetTipJelaa(TipJela);
            c.SetRecept(Recept);
            c.SetSastojak(sastojak);

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            //listBox2.Items.Clear();
            sastojak = new List<string>();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Edit f = new Edit(recept, listBox1.SelectedIndex);
            f.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Recepti_Load(object sender, EventArgs e)
        {

        }
    }
}
