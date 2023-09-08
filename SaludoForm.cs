using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludoForm_G2_2024_1
{
    internal partial class SaludoForm
    {
        int c=0;
        public SaludoForm()
        {
            InitializeComponent();
        }
        
        internal void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombre.Text;
            MessageBox.Show("Hola " + nombre);
            c++;
            lbNombre.Text = "Ingresa tu nombre " + c.ToString();

        }

        internal void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbNombre.Clear();
        }

    }
}
