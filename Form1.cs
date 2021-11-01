using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncriptadoraASCII
{
    public partial class Form1 : Form
    {
        string textoEncriptado = "", textoDesencriptado = "";
        int caracteresEncriptados = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            lblPantalla.Text = "";
            lblPantalla.Text = textoDesencriptado;
            textoDesencriptado = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPantalla.Text = "";
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            lblPantalla.Text = "";
            //SI EL TEXT BOX NO ESTA VACIO COMENZAMOS A ENCRIPTAR//
            if (txtTexto.Text != "" && txtClave.Text != "")
            {
                foreach (var c in txtTexto.Text.ToString())
                {
                    //Encriptacion//
                    caracteresEncriptados = (int)c;
                    caracteresEncriptados = (caracteresEncriptados * 3) / 5;
                    textoEncriptado += caracteresEncriptados.ToString();
                    //Desencriptacion//
                    textoDesencriptado = txtTexto.Text;
                }
                lblPantalla.Text = textoEncriptado;
            } else {
                MessageBox.Show("ERROR: Tienes que Completar todos los campos",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textoEncriptado = "";
        }
    }
}
