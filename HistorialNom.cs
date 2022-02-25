using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nomlyzer
{
    public partial class HistorialNom : Form
    {
        List<string> listaNom1;
        public HistorialNom(List<string> listaNom)
        {
            InitializeComponent();
            listaNom1 = listaNom;
            var nomSel = NombresLista.SelectedItem;
            foreach (var item in listaNom1)
            {
                NombresLista.Items.Add(item);
            }
        }

        private void HistorialNom_Load(object Sender, EventArgs e)
        {
            var Nombres = Nomlyzer.Properties.Settings.Default.nombres;
            NombresLista.Items.Add(Nombres);
        }

        private void NombresLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NombresLista.Items.Clear();
        }
    }
}
