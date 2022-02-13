using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio01DirectoriosGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TiposArchivos> listaArchivos = new List<TiposArchivos>()
            {
                new TiposArchivos {Archivo = ".txt", NombreArchivo = "Archivos txt"},
                new TiposArchivos { Archivo = ".hs", NombreArchivo = "Archivos Haskell"},
                new TiposArchivos {Archivo = ".cs", NombreArchivo = "Archivos C#"}


            };

            comboBox1.DataSource = listaArchivos;
            comboBox1.DisplayMember = "NombreArchivo";
            comboBox1.ValueMember = "Archivo";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog().Equals(DialogResult.OK)) // make to visible the dialog window.
            {
                string path = fbd.SelectedPath; // stored the path selected in the dialog window.

                txtRuta.Text = path;

                MessageBox.Show("the path selacted is : " + path);

            }
        }
    }
}
