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
        public Recepti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sastojci sastojci = new Sastojci();
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
    }
}
