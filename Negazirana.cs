using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domenik_Milohanic_PPZ02
{
    internal class Negazirana
    {
        bool negazirana;
        string naziv, kolicina, pakiranje, cijena;
        int alkohol;

        public Negazirana(bool negazirana, string pića, string naziv, string kolicina, string pakiranje, string cijena, int alkohol)
        {
            this.negazirana = negazirana;
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.pakiranje = pakiranje;
            this.cijena = cijena;
            this.Alkohol = alkohol;
        }
        public override string ToString()
        {
            if (negazirana = true)
            {
                return "Pića su negazirana? " + this.negazirana + Environment.NewLine + "Količina: " + this.kolicina + Environment.NewLine
                   + "Pakiranje: " + this.pakiranje + Environment.NewLine + "Postotak alkohola: " + this.Alkohol + Environment.NewLine
                   + "Cijena: " + this.cijena + Environment.NewLine;
            }
        }

        public bool NegaziranA { get => negazirana; set => negazirana = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public string Cijena { get => cijena; set => cijena = value; }
        public int Alkohol { get => alkohol; set => alkohol = value; }
    }
}
