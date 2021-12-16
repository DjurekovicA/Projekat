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
        private List<string> recept = new List<string>();
        public static List<string> a = new List<string>();
        string Nz;
        string Tj;
        string R;
        public Recepti(string nz = "", string tj = "", string r = "")
        {
            Nz = nz;
            Tj = tj;
            R = r;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sastojci sastojci = new Sastojci(0);
            sastojci.Show();
            this.Close();
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

        private void button3_Click(object sender, EventArgs e)
        { 
            string NazivJela = textBox1.Text;
            string TipJela = comboBox1.Text;
            string Recept = textBox2.Text;
            List<string> sastojak = Sastojci.sastojak;

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

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            Sastojci.sastojak = new List<string>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 cl = new Class1();
            
            Sastojci sastojci = new Sastojci(1,textBox1.Text,cl.GetTipJela(),cl.GetRecept());
            sastojci.Show();
            this.Close();
        }

        private void Recepti_Load(object sender, EventArgs e)
        {
            textBox1.Text = Nz;
            textBox2.Text = R;
            comboBox1.Text = Tj;
        }
    }
}
