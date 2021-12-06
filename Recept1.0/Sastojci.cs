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
        private static string sastojci = "";
        Class1 c = new Class1(sastojci);
        public Sastojci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sastojci == "")
                sastojci = numericUpDown1.Value + " " + comboBox1.Text + " " + textBox1.Text;
            else
                sastojci += "\n " + numericUpDown1.Value + " " + comboBox1.Text + " " + textBox1.Text;
            listBox1.Items.Add(numericUpDown1.Value + " " + comboBox1.Text + " " + textBox1.Text);
            c.SetSastojci(sastojci);   
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
