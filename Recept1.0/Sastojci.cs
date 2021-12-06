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
    public partial class Sastojci : Form
    {
        private List<Class1> klasa = new List<Class1>(); 
        public Sastojci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sastojci = new string[20];
            Class1 Sastojak = new Class1(sastojci);
            for (int i = 0; i < klasa.Count; i++)
            {
                sastojci[i] = numericUpDown1.Value + " " + comboBox1.Text + " " + textBox1.Text;
            }
            listBox1.Items.Add(numericUpDown1.Value + " " + comboBox1.Text + " " + textBox1.Text);
            klasa.Add(Sastojak);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recepti recepti = new Recepti();
            recepti.Show();
            this.Close();
        }

        private void Sastojci_Load(object sender, EventArgs e)
        {
        }
    }
}
