using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recept1._0
{
    internal class Class1
    {
        private string NazivRecepta;
        private string Recept;
        private string TipJela;
        private string[] Sastojci = new string[20];
        public string GetNazivRecepta()
        {
            return NazivRecepta;
        }
        public void SetNazivRecepta(string a)
        {
            NazivRecepta = a;
        }
        public string GetRecept()
        {
            return Recept;
        }
        public void SetRecept(string a)
        {
            Recept = a;
        }
        public string GetTipJela()
        {
            return TipJela;
        }
        public void SetTipJelaa(string a)
        {
            TipJela = a;
        }
        public string[] GetSastojci()
        {
            return Sastojci;
        }
        public void SetSastojci(string[] a)
        {
            Sastojci = a;
        }

        public Class1(string[] s)
        {
            Sastojci = s;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
