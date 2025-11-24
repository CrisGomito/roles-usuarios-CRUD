using CRUD_Semana5.Controladores;
using CRUD_Semana5.Modelos;

namespace CRUD_Semana5.Vistas.Usuarios
{
    public partial class frm_Insertar_Usuario : Form
    {
        private readonly Auth_Controller _auth_controller = new Auth_Controller();
        private readonly Usuarios_Controller _usuariosController = new Usuarios_Controller();
        public frm_Insertar_Usuario()
        {
            InitializeComponent();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            if (!validacionCedula())
            {
                MessageBox.Show("Cédula inválida. Por favor, verifique e intente nuevamente.");
                return;
            }
            var usuario_model = new Usuario_Model
            {
                Cedula_Usuario = txt_Cedulas.Text.Trim(),
                Nombre_Usuario = txt_Nombres.Text.Trim(),
                Apellido_Usuario = txt_Apellidos.Text.Trim(),
                Correo_Usuario = txt_Correos.Text.Trim(),
                Contrasenia = txt_Contrasenias.Text.Trim(),
                Estado = chb_Estados.Checked == true,
            };
            var nuevo_usuario = _usuariosController.Insertar(usuario_model);
            if (nuevo_usuario.Item1 == null)
            {
                MessageBox.Show(nuevo_usuario.error);
            }
            else
            {
                MessageBox.Show("Usuario insertado correctamente.");
                limpiarcajas();
            }
        }

        public void limpiarcajas()
        {
            txt_Nombres.Text = "";
            txt_Apellidos.Text = "";
            txt_Cedulas.Text = "";
            txt_Correos.Text = "";
            txt_Contrasenias.Text = "";
            chb_Estados.Checked = false;
        }

        public bool validaciones()
        {
            if (txt_Apellidos.Text.Trim() == "" || txt_Nombres.Text.Trim() == "" || txt_Cedulas.Text.Trim() == "" || txt_Correos.Text.Trim() == "" || txt_Contrasenias.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void txt_Cedulas_Leave(object sender, EventArgs e)
        {
            validacionCedula();
        }
        public bool validacionCedula()
        {
            if (txt_Cedulas.Text.Length != 10)
            {
                MessageBox.Show("La cédula debe tener exactamente 10 dígitos.");
                return false;
            }

            bool validacion = _auth_controller.VerificarCedula(txt_Cedulas.Text.ToCharArray());
            if (!validacion)
            {
                MessageBox.Show("Cédula inválida. Por favor, verifique e intente nuevamente.");
                txt_Cedulas.Text = string.Empty;
                txt_Cedulas.Focus();
                return false;
            }
            return true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.limpiarcajas();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
