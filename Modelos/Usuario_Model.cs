
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Semana5.Modelos
{
    public class Usuario_Model
    {
        public int Id_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Apellido_Usuario { get; set; }
        public string Cedula_Usuario { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public bool Estado { get; set; }
        public string Contrasenia { get; set; }
        public string Correo_Usuario { get; set; }
        [NotMapped]
        public string nombre_completo { get; set; }        //Es solo de lectura
        public int? Id_Rol { get; set; }// FK
        // PROPIEDADES CALCULADAS (NO EXISTEN EN LA BD)
        [NotMapped]
        public string RolNombre { get; set; }              // para mostrar en listados
    }
}
