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
        private List<Class1> klasa = new List<Class1>();
        public Recepti()
        {
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
            Class1 c = new Class1(NazivJela, TipJela, Recept);
            listBox1.Items.Add(c.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sastojci sastojci = new Sastojci(1);
            sastojci.Show();
            this.Close();
        }
    }
}
