
namespace CRUD_Semana5.Modelos
{
    public class Rol_Model
    {
        public int Id_Rol { get; set; }
        public string Nombre_Rol { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Creacion { get; set; } = DateTime.UtcNow;
        public bool Estado { get; set; } = true;
    }
}
