using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PañalHome
{
    public partial class FormSolicitudDomicilio : Form
    {
        public FormSolicitudDomicilio()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var Form = new FormMenu();
            Form.ShowDialog();
            Hide();
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            // Muestra el mensaje con todos los datos ingresados 
            MessageBox.Show("El pedido se realizó exitosamente", this.Text,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
        }
    }
}
