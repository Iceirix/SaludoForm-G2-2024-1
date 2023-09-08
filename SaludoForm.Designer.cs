using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaludoForm_G2_2024_1
{
    internal partial class SaludoForm:Form
    {
        private Label lbNombre;
        private TextBox txtbNombre;
        private Button btnAceptar;
        private Button btnLimpiar;

        public void InitializeComponent()
        {
            // Redimensionando y configurando la ventana
            this.Size = new Size(600, 400);
            this.Text = "Form Saludo";

            // Label: Ingresa tu nombre
            lbNombre = new Label(); // Instanciamos objeto
            lbNombre.Text = "Ingresa tu nombre";
            lbNombre.Location = new Point(225,100);

            // TextBox
            txtbNombre = new TextBox();
            txtbNombre.Size = new Size(200,50);
            txtbNombre.Location = new Point(175, 150);

            // Button Aceptar
            btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(175, 200);
            btnAceptar.Click += new EventHandler(btnAceptar_Click);

            // Button Limpiar
            btnLimpiar = new Button();
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Location = new Point(300, 200);

            this.Controls.Add(lbNombre);
            this.Controls.Add(txtbNombre);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(btnLimpiar);
        }

    }
}
