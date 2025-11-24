using CRUD_Semana5.Controladores;
using CRUD_Semana5.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Semana5.Vistas.Roles
{
    public partial class frm_Editar_Rol : Form
    {
        private readonly Roles_Controller _rolesController = new Roles_Controller();
        private int _id;

        public frm_Editar_Rol(int id_rol)
        {
            InitializeComponent();
            _id = id_rol;
        }

        private void frm_Editar_Rol_Load(object sender, EventArgs e)
        {
            var rol = _rolesController.ObtenerPorId(_id);
            if (rol == null)
            {
                MessageBox.Show("Rol no encontrado.");
                this.Close();
                return;
            }

            txt_Nombre.Text = rol.Nombre_Rol;
            txt_Descripcion.Text = rol.Descripcion;
            chb_Estados.Checked = rol.Estado;
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
                Id_Rol = _id,
                Nombre_Rol = txt_Nombre.Text.Trim(),
                Descripcion = txt_Descripcion.Text.Trim(),
                Estado = chb_Estados.Checked
            };

            var resultado = _rolesController.Actualizar(rol);
            if (!resultado.ok)
            {
                MessageBox.Show("Error al editar el rol: " + resultado.error);
            }
            else
            {
                MessageBox.Show("Rol editado correctamente.");
                limpiarcajas();
                var frm_lista = new frm_lista_roles();
                frm_lista.Show();
                this.Close();
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
