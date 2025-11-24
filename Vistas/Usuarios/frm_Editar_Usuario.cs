
using CRUD_Semana5.Config;
using CRUD_Semana5.Controladores;
using CRUD_Semana5.Modelos;
using CRUD_Semana5.Vistas.Dashboard;

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
            CargarRoles();

            Usuario_Model usuario_Model = new Usuario_Model();
            usuario_Model = _usuarios_controller.ObtenerPorId(_id);

            txt_Nombres.Text = usuario_Model.Nombre_Usuario;
            txt_Apellidos.Text = usuario_Model.Apellido_Usuario;
            txt_Cedulas.Text = usuario_Model.Cedula_Usuario;
            txt_Correos.Text = usuario_Model.Correo_Usuario;
            txt_Contrasenias.Text = usuario_Model.Contrasenia;
            chb_Estados.Checked = usuario_Model.Estado;
            cb_Rol.SelectedValue = usuario_Model.Id_Rol;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            var correo = txt_Correos.Text.Trim();
            bool ok = System.Text.RegularExpressions.Regex.IsMatch(correo,
                 @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                 System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            if (!ok)
            {
                MessageBox.Show("El correo no tiene el formato correcto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Correos.Focus();
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
                Id_Usuario = _id,
                Id_Rol = (int?)cb_Rol.SelectedValue
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
                frm_dashboard.CargarVistaEnPanel(new frm_lista_usuarios());
                this.Hide();
                this.Dispose();
            }
        }
        private void CargarRoles()
        {
            using (var db = new sqlServer_dbcontext())
            {
                var roles = db.Roles
                              .Select(r => new { r.Id_Rol, r.Nombre_Rol })
                              .ToList();

                cb_Rol.DataSource = roles;
                cb_Rol.DisplayMember = "Nombre_Rol";
                cb_Rol.ValueMember = "Id_Rol";
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
            limpiarcajas();
            frm_dashboard.CargarVistaEnPanel(new frm_lista_usuarios());
            this.Hide();
            this.Dispose();
        }
    }
}

