using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domenik_Milohanic_PPZ02
{
    public partial class Form1 : Form
    {
        List<Gazirana> listaGazirana = new List<Gazirana>();
        List<Negazirana> listaNegazirana = new List<Negazirana>();
        List<Alkoholna> listaAlkoholna = new List<Alkoholna>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNunos_Click(object sender, EventArgs e)
        {
            Gazirana gazirana = new Gazirana(RDBgazirana.Checked, TXTnaziv.Text, CMBkolicina.Text, CMBpakiranje.Text, TXTcijena.Text, TRBalkohol.Value);
            listaGazirana.Add(gazirana);

            Negazirana negazirana = new Negazirana(RDBnegazirana.Checked, TXTnaziv.Text, CMBkolicina.Text, CMBpakiranje.Text, TXTcijena.Text, TRBalkohol.Value);
            listaNegazirana.Add(negazirana);

            Alkoholna alkoholna = new Alkoholna(RDBalkoholna.Checked, TXTnaziv.Text, CMBkolicina.Text, CMBpakiranje.Text, TXTcijena.Text, TRBalkohol.Value);
            listaAlkoholna.Add(alkoholna);
            
        }

        private void BTNispis_Click(object sender, EventArgs e)
        {
            RTBispis.Clear();

            foreach (Gazirana gazirana in listaGazirana)
            {
                RTBispis.AppendText(gazirana.ToString());
            }
        }
    }
}
