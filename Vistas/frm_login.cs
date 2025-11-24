
namespace CRUD_Semana5.Vistas
{
    using _CRUD_Semana5.Modelos;
    using CRUD_Semana5.Vistas.Dashboard;
    using CRUD_Semana5.Controladores;
    using CRUD_Semana5.Modelos;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class frm_login : Form
    {
        private readonly Auth_Controller _authController = new Auth_Controller();
        private int _coontador = 3;

        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar2_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            var correo = txt_Correo.Text.Trim();
            var clave = txt_Contrasenia.Text.Trim();

            if (string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Ingrese un correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Correo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Ingrese la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Contrasenia.Focus();
                return;
            }

            var mailOk = System.Text.RegularExpressions.Regex.IsMatch(correo,
                 @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            if (!mailOk)
            {
                MessageBox.Show("El correo no tiene el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Correo.Focus();
                return;
            }

            Login_Model model = new Login_Model
            {
                Correo_Usuario = correo,
                Contrasenia = clave
            };

            Usuario_Model usuario = _authController.login2(model);
            if (usuario != null)
            {
                MessageBox.Show($"Inicio de sesión exitoso. Bienvenido {usuario.Nombre_Usuario} ({usuario.RolNombre})", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var dash = new frm_dashboard(this);
                dash.Show();
                this.Hide();
                limpiarcajas();
            }
            else
            {
                _coontador--;
                if (_coontador == 0)
                {
                    MessageBox.Show("Has excedido el número de intentos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Credenciales incorrectas. Te quedan {_coontador} intento(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Contrasenia.Text = "";
                    txt_Contrasenia.Focus();
                }
            }
        }

        private void txt_Correo_Leave(object sender, EventArgs e)
        {
            var correo = txt_Correo.Text.Trim();
            if (string.IsNullOrEmpty(correo)) return;

            bool ok = System.Text.RegularExpressions.Regex.IsMatch(correo,
                 @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            if (!ok)
            {
                MessageBox.Show("El correo no tiene el formato correcto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Correo.Focus();
            }
        }
        public void limpiarcajas()
        {
            txt_Correo.Text = "";
            txt_Contrasenia.Text = "";
        }
    }
}
