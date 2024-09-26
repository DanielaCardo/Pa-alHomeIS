using PañalHome;

namespace PañalHome
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingreso exitoso", "Bienvenido a PañalHome ", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            var form=new FormMenu();
            form.ShowDialog();
            Hide();
        }
        
    }
}
