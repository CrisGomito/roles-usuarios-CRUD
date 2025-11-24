
using CRUD_Semana5.Controladores;
using CRUD_Semana5.Modelos;

namespace CRUD_Semana5.Vistas.Roles
{
    public partial class frm_Insertar_Rol : Form
    {
        private readonly Roles_Controller _rolesController = new Roles_Controller();
        public frm_Insertar_Rol()
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

            var rol = new Rol_Model
            {
                Nombre_Rol = txt_Nombre.Text.Trim(),
                Descripcion = txt_Descripcion.Text.Trim(),
                Estado = chb_Estados.Checked
            };

            var resultado = _rolesController.Insertar(rol);
            if (resultado.rol == null)
            {
                MessageBox.Show("Error: " + resultado.error);
            }
            else
            {
                MessageBox.Show("Rol insertado correctamente.");
                limpiarcajas();
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

        public void limpiarcajas()
        {
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            chb_Estados.Checked = false;
        }

        public bool validaciones()
        {
            return !string.IsNullOrWhiteSpace(txt_Nombre.Text);
        }
    }
}
