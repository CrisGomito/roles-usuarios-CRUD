
namespace CRUD_Semana5.Vistas.Dashboard
{
    using CRUD_Semana5.Vistas.Usuarios;
    using CRUD_Semana5.Vistas.Roles;

    public partial class frm_dashboard : Form
    {
        public static Panel PanelContenedorGlobal;
        private frm_login _login;
        public frm_dashboard(frm_login login)
        {
            InitializeComponent();
            _login = login;
            PanelContenedorGlobal = panelContenedor;
        }
        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lista_usuarios vista = new frm_lista_usuarios();
            CargarVistaEnPanel(vista);
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
            frm_lista_roles vista = new frm_lista_roles();
            CargarVistaEnPanel(vista);
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

        //método general para cargar formularios dentro del panel contenedor
        public static void CargarVistaEnPanel(Form vista)
        {
            PanelContenedorGlobal.Controls.Clear();

            //configuramos el formulario para funcionar como control
            vista.TopLevel = false;
            vista.FormBorderStyle = FormBorderStyle.None;
            vista.Dock = DockStyle.Fill;

            PanelContenedorGlobal.Controls.Add(vista); //agrega al panel
            vista.Show();
        }
    }
}
