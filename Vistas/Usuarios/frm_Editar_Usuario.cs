
using CRUD_Semana5.Controladores;
using CRUD_Semana5.Modelos;

namespace CRUD_Semana5.Vistas.Usuarios
{
    public partial class frm_Editar_Usuario : Form
    {
        Usuarios_Controller _usuarios_controller = new Usuarios_Controller();
        private readonly Auth_Controller _auth_controller = new Auth_Controller();

        int _id;
        public frm_Editar_Usuario(int id_usuario)
        {
            InitializeComponent();
            _id = id_usuario;

        }

        private void frm_Editar_Usuario_Load(object sender, EventArgs e)
        {
            Usuario_Model usuario_Model = new Usuario_Model();
            usuario_Model = _usuarios_controller.ObtenerPorId(_id);

            txt_Nombres.Text = usuario_Model.Nombre_Usuario;
            txt_Apellidos.Text = usuario_Model.Apellido_Usuario;
            txt_Cedulas.Text = usuario_Model.Cedula_Usuario;
            txt_Correos.Text = usuario_Model.Correo_Usuario;
            txt_Contrasenias.Text = usuario_Model.Contrasenia;
            chb_Estados.Checked = usuario_Model.Estado;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
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
                Id_Usuario = _id
            };
            var nuevo_usuario = _usuarios_controller.Actualizar(usuario_model);
            if (!nuevo_usuario.ok)
            {
                MessageBox.Show("Error al editar el usuario: " + nuevo_usuario.error);
            }
            else
            {
                MessageBox.Show("Usuario editado correctamente.");
                limpiarcajas();
                var frm_lista = new frm_lista_usuarios();
                frm_lista.Show();
                this.Close();
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
            if (txt_Apellidos.Text.Trim() == "" || txt_Nombres.Text.Trim() == "" || txt_Correos.Text.Trim() == "" || txt_Contrasenias.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiarcajas();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

