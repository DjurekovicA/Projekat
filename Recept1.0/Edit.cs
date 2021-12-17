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
        List<Class1> Recept = new List<Class1>();
        List<Class1> Class1 = new List<Class1>();
        string Naz;
        string Tip;
        string Rec;
        int N;
        public Edit(string naz, string tip, string rec, int n)
        {
            Naz = naz;
            Tip = tip;
            Rec = rec;
            N = n;
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNazad_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        // " Izmeni recept "
        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        // " + "
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        // " - "
        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Edit_Load_1(object sender, EventArgs e)
        {
            Class1 c = new Class1(Recept, 1);

            for (int i = 0; i < Recept.Count; i++)
            {
                if (i == N)
                {
                    textBox1.Text = Naz;
                    textBox2.Text = Rec;
                    comboBox1.Text = Tip;
                    listBox2.Items.Add(c.GetSastojak());
                }
            }
        }
    }
}
