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
    public partial class Edit : Form
    {
        List<string> Recept = new List<string>();
        List<Class1> Class1 = new List<Class1>();
        int N;
        public Edit(List<string> recept, int n)
        {
            Recept = recept;
            N = n;
            InitializeComponent();
        }

        // " Izmeni recept "
        private void button3_Click(object sender, EventArgs e)
        {

        }

        // " + "
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // " - "
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            Class1 c = new Class1(Recept, 1);

            for (int i = 0; i < Recept.Count; i++)
            {
                if (i == N)
                {
                    textBox1.Text = c.GetNazivRecepta();
                    textBox2.Text = c.GetRecept();
                    comboBox1.Text = c.GetTipJela();
                    listBox2.Items.Add(c.GetSastojak());
                }
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
