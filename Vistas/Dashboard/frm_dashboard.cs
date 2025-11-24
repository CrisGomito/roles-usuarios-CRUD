
namespace CRUD_Semana5.Vistas.Dashboard
{
    using CRUD_Semana5.Vistas.Usuarios;
    using CRUD_Semana5.Vistas.Roles;

    public partial class frm_dashboard : Form
    {
        private frm_login _login;
        public frm_dashboard(frm_login login)
        {
            InitializeComponent();
            _login = login;
        }
        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_usuarios = new frm_lista_usuarios();
            frm_lista_usuarios.ShowDialog();
        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_insertar_usuario = new frm_Insertar_Usuario();
            frm_insertar_usuario.ShowDialog();
        }

        private void editarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_editar_usuario = new frm_lista_usuarios();
            frm_editar_usuario.ShowDialog();
        }

        private void eliminarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_eliminar_usuario = new frm_lista_usuarios();
            frm_eliminar_usuario.ShowDialog();
        }

        private void listaDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_lista_roles = new frm_lista_roles();
            frm_lista_roles.ShowDialog();
        }

        private void agregarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_insertar_rol = new frm_Insertar_Rol();
            frm_insertar_rol.ShowDialog();
        }

        private void editarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_editar_rol = new frm_lista_roles();
            frm_editar_rol.ShowDialog();
        }

        private void eliminarRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_eliminar_rol = new frm_lista_roles();
            frm_eliminar_rol.ShowDialog();
        }

        private void frm_dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _login.Show();
        }
    }
}
