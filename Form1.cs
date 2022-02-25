using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Nomlyzer
{
    public partial class Form1 : Form
    {
        [DllImport("comctl32.dll", CharSet = CharSet.Unicode, EntryPoint = "TaskDialog")]
        static extern int TaskDialog2(IntPtr hWndParent, IntPtr hInstance, String pszWindowTitle,
            String pszMainInstruction, String pszContent, int dwCommonButtons, IntPtr pszIcon, out int pnButton);
        public static string Nombre = "Fulano";
        public List<String> listaNom = new List<String>();
        Strings st = new Strings();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Normlyzer ";
            this.Text += st.obtenerVersion();
            this.Text += " por elstef41";
        }
        // ReverseString, de dotnetperls. https://www.dotnetperls.com/reverse-string
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Nombre = NomBox.Text;
            int NomCar = NomBox.TextLength;
            int result;
            if (Nombre == "")
            {
                MessageBox.Show("El cuadro del nombre no puede estar vacío. ¿No crees?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Nombre.Contains(" "))
            {
                MessageBox.Show("El nombre no puede contener espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (genc.SelectedItem == null)
            {
                MessageBox.Show("No has selecionado un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NomCar >= 51)
            {
                MessageBox.Show("El nombre es demasiado largo. Asegúrate que no supere los 50 caracteres (tiene " + NomCar + ").", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /* Guardar dato para introducirlo en el historial */
                listaNom.Add(Nombre);
                /* Cambia la estructura del formulario */
                this.Width = 665;
                this.Height = 400;
                inicio.Visible = true;
                label3.Visible = false;
                genc.Visible = false;
                label1.Visible = false;
                button1.Visible = false;
                NomBox.Visible = false;
                label7.Visible = true;
                nom.Text = Nombre;
                nom.Visible = true;
                String gen = "o";
                label7.Text = "Género seleccionado: " + genc.Text;
                switch (genc.SelectedIndex)
                {
                    case 0:
                        {
                            gen = "o";
                            break;
                        }
                    case 1:
                        {
                            gen = "a";
                            break;
                        }
                }
                capitob.Text = "&Averiguar significado de " + Nombre;
                capitob.Visible = true;
                if (Nombre.EndsWith("i") == true)
                {
                    MiniNom.Text = Nombre + "t" + gen;
                }
                else if (Nombre.EndsWith("co"))
                {
                    String Nombren2 = Nombre.Remove(Nombre.Length - 2);
                    MiniNom.Text = Nombren2 + "quito";
                }
                else if (Nombre.EndsWith("l") || Nombre.EndsWith("r") || Nombre.EndsWith("n") || Nombre.EndsWith("a") || Nombre.EndsWith("e") || Nombre.EndsWith("o") || Nombre.EndsWith("u") || Nombre.EndsWith("y") || Nombre.EndsWith("x"))
                {
                    MiniNom.Text = Nombre + "sit" + gen;
                }
                else
                {
                    MiniNom.Text = Nombre + "it" + gen;
                }
                DescGroup.Visible = true;
                String NomNoCons = Regex.Replace(Nombre, "[zxcvbsdmnfghjklñqwrtpZXCVBSDMNFGHJKLÑQWRTP]", "");
                String NomNoVocs = Regex.Replace(Nombre, "[aeiouAEIOUáéíóúÁÉÍÓÚ]", "");
                String NomConNums = Nombre.Replace("A", "4").Replace("a", "4").Replace("Á", "4").Replace("á", "4").Replace("E", "3").Replace("e", "3").Replace("É", "3").Replace("é", "3").Replace("I", "1").Replace("i", "1").Replace("Í", "1").Replace("í", "1").Replace("O", "0").Replace("o", "0").Replace("Ó", "0").Replace("ó", "0");
                String textBur = Regex.Replace(Nombre, "a", "ᴀ")
                                      .Replace("e", "ᴇ")
                                      .Replace("i", "ɪ")
                                      .Replace("b", "ʙ")
                                      .Replace("d", "ᴅ")
                                      .Replace("f", "ғ")
                                      .Replace("g", "ɢ")
                                      .Replace("h", "ʜ")
                                      .Replace("j", "ᴊ")
                                      .Replace("k", "ᴋ")
                                      .Replace("l", "ʟ")
                                      .Replace("m", "ᴍ")
                                      .Replace("n", "ɴ")
                                      .Replace("p", "ᴘ")
                                      .Replace("q", "ǫ")
                                      .Replace("r", "ʀ")
                                      .Replace("t", "ᴛ")
                                      .Replace("y", "ʏ");
                String textMay = Nombre.ToUpper();
                String textMin = Nombre.ToLower();
                NoCons.Text = NomNoCons;
                NoVocs.Text = NomNoVocs;
                label11.Text = Nombre.Length + " caracteres (" + NomNoCons.Length + " vocales y " + NomNoVocs.Length + " consonantes).";
                ConNums.Text = NomConNums;
                nomBur.Text = textBur;
                nomBur.Text = textBur;
                tMay.Text = textMay;
                tMin.Text = textMin;
                button2.Visible = true;
                historialToolStripMenuItem.Enabled = true;
                nomVes.Text = ReverseString(Nombre);
            }
        }

        private void capitob_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se abrirá un sitio web ajeno al programa el cual tratará de mostrar la información del nombre solicitado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            SignificadoExt SignificadoE = new SignificadoExt(Nombre);
            SignificadoE.Show();
        }


        private void inicio_Click(object sender, EventArgs e)
        {
            this.Width = 340;
            this.Height = 155;
            inicio.Visible = false;
            label3.Visible = true;
            genc.Visible = true;
            label1.Visible = true;
            button1.Visible = true;
            NomBox.Visible = true;
            label7.Visible = false;
            nom.Visible = false;
            capitob.Visible = false;
            DescGroup.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistorialNom HNom = new HistorialNom(listaNom);
            HNom.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AcercaDe().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialNom HNom = new HistorialNom(listaNom);
            HNom.Show();
        }

        private void licenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.apache.org/licenses/LICENSE-2.0.html");
        }

        private void repositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/elstef41/nomlyzer");
        }
    }
}
