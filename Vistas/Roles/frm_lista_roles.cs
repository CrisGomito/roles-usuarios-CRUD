using CRUD_Semana5.Controladores;

namespace CRUD_Semana5.Vistas.Roles
{
    public partial class frm_lista_roles : Form
    {
        private readonly Roles_Controller _roles = new Roles_Controller();
        public frm_lista_roles()
        {
            InitializeComponent();
        }

        private void frm_lista_roles_Load(object sender, EventArgs e)
        {
            cargar_lista();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            var frm_insertar = new frm_Insertar_Rol();
            frm_insertar.ShowDialog();
            cargar_lista();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Lista_Roles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar el rol seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)lst_Lista_Roles.SelectedValue;
                var resultado = _roles.Eliminar(id);
                if (!resultado.ok)
                {
                    MessageBox.Show("Error al eliminar el rol: " + resultado.error);
                }
                else
                {
                    MessageBox.Show("Rol eliminado correctamente.");
                    cargar_lista();
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargar_lista()
        {
            lst_Lista_Roles.DataSource = _roles.Todos();
            lst_Lista_Roles.ValueMember = "Id_Rol";
            lst_Lista_Roles.DisplayMember = "Nombre_Rol";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (lst_Lista_Roles.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol para editar.");
                return;
            }
            int id = (int)lst_Lista_Roles.SelectedValue;
            var frm_editar = new frm_Editar_Rol(id);
            frm_editar.ShowDialog();
            cargar_lista();
        }
    }
}
