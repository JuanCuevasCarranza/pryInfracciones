using System;
using System.Windows.Forms;

namespace pryInfracciones
{
    // Cambia "frmInfraccionesDeTransito" por el nombre exacto de tu Form si se llama distinto (ej. Form1)
    public partial class frmInfraccionesDeTransito : Form
    {
        // 1. Estructura y Arreglo unidimensional con su dimensión [50]
        public struct INFRACCION
        {
            public int NroActa;
            public string Dominio;
            public string Tipo;
            public float Monto;
        }

        private INFRACCION[] actas = new INFRACCION[50];
        private int contadorActas = 0;

        public frmInfraccionesDeTransito()
        {
            InitializeComponent();
        }

        // Evento KeyPress: Solo números en NroActa
        private void txtNroActa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Evento KeyPress: Solo números en Monto
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Evento KeyPress: Convertir a mayúsculas en Dominio
        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Evento TextChanged: Habilitar botón Registrar
        private void ValidarCampos_TextChanged(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = (txtNroActa.Text != "" && txtDominio.Text != "" && txtMonto.Text != "");
        }

        // Evento Click: Registrar Acta
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (contadorActas < actas.Length)
            {
                INFRACCION nuevaActa;
                nuevaActa.NroActa = int.Parse(txtNroActa.Text);
                nuevaActa.Dominio = txtDominio.Text;
                nuevaActa.Tipo = cmbInfraccion.SelectedItem != null ? cmbInfraccion.SelectedItem.ToString() : "Sin especificar";
                nuevaActa.Monto = float.Parse(txtMonto.Text);

                actas[contadorActas] = nuevaActa;
                contadorActas++;

                dgvInfracciones.Rows.Add(nuevaActa.NroActa, nuevaActa.Dominio, nuevaActa.Tipo, nuevaActa.Monto);

                txtNroActa.Clear();
                txtDominio.Clear();
                txtMonto.Clear();
                txtNroActa.Focus();
            }
            else
            {
                MessageBox.Show("Límite de 50 actas alcanzado.");
            }
        }

        // Evento Click: Calcular Total
        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            float total = 0;
            for (int i = 0; i < contadorActas; i++)
            {
                total += actas[i].Monto;
            }
            txtTotalRecaudado.Text = total.ToString("0.00");
        }
    }
}