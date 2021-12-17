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
        public static List<string> NaziviJela = new List<string>();
        public List<Class1> recept = new List<Class1>();
        Class1 class1 = new Class1(sastojak);
        public Recepti()
        {
            InitializeComponent();
        }

        //dodavanje sastojka
        private void button1_Click(object sender, EventArgs e)
        
        {
            if (sastojak.Contains(textBox3.Text)) {
                MessageBox.Show("Već ste dodali ovaj sastojak");
                textBox3.Text = "";
                return;
            }

            if (textBox3.Text == "")
                return;

            string s = textBox3.Text.ToLower();
            sastojak.Add(s);
            listBox2.Items.Add(s);
            class1.SetSastojak(sastojak);

            textBox3.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //dodavanje recepta
        private void button3_Click(object sender, EventArgs e)
        {
            Dodaj();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }// " - "
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != 0) {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    if (i == listBox2.SelectedIndex)
                    {
                        sastojak.RemoveAt(listBox2.SelectedIndex);
                        listBox2.Items.Clear();
                        for (int j = 0; j < sastojak.Count; j++)
                        {
                            listBox2.Items.Add(sastojak[j]);
                        }
                    }
                }
            }
        }

        private void Recepti_Load(object sender, EventArgs e)
        {

        }

        //prikaz recepta
        public void Dodaj()
        {
            string NazivJela = textBox1.Text;
            string TipJela = comboBox1.Text;
            string Recept = textBox2.Text;
            string Sastojak = textBox3.Text;
            List<string> ss = new List<string>(sastojak);

            if (NaziviJela.Contains(NazivJela))
            {
                MessageBox.Show("Imate već recept sa tim imenom");
                return;
            }
            if (sastojak.Count < 3)
            {
                MessageBox.Show("Morate imati bar 3 sastojka");
                return;
            }

            Class1 c = new Class1(NazivJela, TipJela, sastojak, Recept);
            recept.Add(c);
            listBox1.Items.Add(c.ToString());
            NaziviJela.Add(NazivJela);
            c.SetNazivRecepta(NazivJela);
            c.SetTipJelaa(TipJela);
            c.SetRecept(Recept);
            c.SetSastojak(sastojak);

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            listBox2.Items.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Show();
            button5.Show();
            button6.Show();
            listBox2.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox2.Text = "";
            comboBox1.Text = "";

            int r = listBox1.SelectedIndex;
            for (int i = 0; i < recept.Count; i++)
            {
                Class1 n = recept[i];
                if (i == r)
                {
                    textBox1.Text = n.GetNazivRecepta();
                    textBox2.Text = n.GetRecept();
                    comboBox1.Text = n.GetTipJela();
                    for (int j = 0; j < sastojak.Count; j++)
                    {
                        listBox2.Items.Add(sastojak[j]);
                    }
                }
            }
        }

        // " izmeni " 
        private void button4_Click_1(object sender, EventArgs e)
        {
            string NazivJela = textBox1.Text;
            string TipJela = comboBox1.Text;
            string Recept = textBox2.Text;
            Class1 c = new Class1(NazivJela, TipJela, sastojak, Recept);

            for (int i = 0; i < recept.Count; i++) {
                if (i==listBox1.SelectedIndex) {
                    c.SetNazivRecepta("");
                    c.SetTipJelaa("");
                    c.SetRecept("");
                    recept.RemoveAt(listBox1.SelectedIndex);
                    c.SetSastojak(new List<string>());
                    Dodaj();
                    //c.SetNazivRecepta(NazivJela);
                    listBox1.Items.Clear();
                    for (int j = 0; j < recept.Count; j++)
                        listBox1.Items.Add(recept[j]);
                }
            }

            listBox2.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
        
        // " obrisi "
        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < recept.Count; i++) {
                if (i == listBox1.SelectedIndex) {
                    recept.RemoveAt(i);
                    listBox1.Items.Clear();
                }
                for (int j = 0; j < recept.Count; j++) {
                    listBox1.Items.Add(recept[j]);
                }
            }
            listBox2.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        // " odustani "
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            for (int i = 0; i < recept.Count; i++) {
                listBox1.Items.Add(recept[i]);
            }

        }
    }
}
