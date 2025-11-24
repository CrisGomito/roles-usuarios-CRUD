using CRUD_Semana5.Controladores;

namespace CRUD_Semana5.Vistas.Usuarios
{
    public partial class frm_lista_usuarios : Form
    {
        private readonly Usuarios_Controller _usuarios = new Usuarios_Controller();
        public frm_lista_usuarios()
        {
            InitializeComponent();
        }
        private void frm_lista_usuarios_Load(object sender, EventArgs e)
        {
            cargar_lista();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            frm_Insertar_Usuario agregar_Usuario = new frm_Insertar_Usuario();
            agregar_Usuario.ShowDialog();
            lst_Lista_Usuarios.DataSource = _usuarios.Todos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Lista_Usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }
            if (MessageBox.Show("¿Está seguro de eliminar el usuario seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id_usuario = (int)lst_Lista_Usuarios.SelectedValue;
                var resultado = _usuarios.Eliminar(id_usuario);
                if (!resultado.ok)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + resultado.error);
                }
                else
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
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
            lst_Lista_Usuarios.DataSource = _usuarios.Todos();
            lst_Lista_Usuarios.ValueMember = "Id_Usuario";
            lst_Lista_Usuarios.DisplayMember = "nombre_completo";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (lst_Lista_Usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario para editar.");
            }
            else
            {
                int id_usuario = (int)lst_Lista_Usuarios.SelectedValue;
                var editar_Usuario = new frm_Editar_Usuario(id_usuario);
                editar_Usuario.ShowDialog();
                this.Close(); 
            }
        }
    }
}

