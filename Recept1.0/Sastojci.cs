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
        public Sastojci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(numericUpDown1.Value + " " + comboBox1.Text + " " + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recepti recepti = new Recepti();
            recepti.Show();
            this.Close();
        }
    }
}
