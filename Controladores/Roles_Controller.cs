
using CRUD_Semana5.Config;
using CRUD_Semana5.Modelos;

namespace CRUD_Semana5.Controladores
{
    public class Roles_Controller
    {
        // Lista todos los roles
        public List<Rol_Model> Todos()
        {
            using (var db = new sqlServer_dbcontext())
            {
                return db.Roles.OrderBy(r => r.Nombre_Rol).ToList();
            }
        }

        // Obtener por id
        public Rol_Model ObtenerPorId(int id)
        {
            using (var db = new sqlServer_dbcontext())
            {
                return db.Roles.Find(id);
            }
        }

        // Inserta un rol (retorna tupla con objeto y mensaje)
        public (Rol_Model rol, string error) Insertar(Rol_Model rol)
        {
            if (rol == null || string.IsNullOrWhiteSpace(rol.Nombre_Rol))
                return (null, "El nombre del rol es obligatorio.");

            using (var db = new sqlServer_dbcontext())
            {
                // Validar duplicados
                if (db.Roles.Any(r => r.Nombre_Rol == rol.Nombre_Rol))
                    return (null, "Ya existe un rol con ese nombre.");

                db.Roles.Add(rol);
                db.SaveChanges();
                return (rol, null);
            }
        }

        // Actualizar
        public (bool ok, string error) Actualizar(Rol_Model rol)
        {
            if (rol == null || rol.Id_Rol == 0) return (false, "Rol inválido.");

            using (var db = new sqlServer_dbcontext())
            {
                var exist = db.Roles.Find(rol.Id_Rol);
                if (exist == null) return (false, "Rol no existe.");
                exist.Nombre_Rol = rol.Nombre_Rol;
                exist.Descripcion = rol.Descripcion;
                exist.Estado = rol.Estado;
                db.SaveChanges();
                return (true, null);
            }
        }

        // Eliminar (logico o fisico)
        public (bool ok, string error) Eliminar(int id)
        {
            if (id == 0) return (false, "Id inválido.");
            using (var db = new sqlServer_dbcontext())
            {
                var exist = db.Roles.Find(id);
                if (exist == null) return (false, "Rol no encontrado.");
                db.Roles.Remove(exist);
                db.SaveChanges();
                return (true, null);
            }
        }
    }
}
