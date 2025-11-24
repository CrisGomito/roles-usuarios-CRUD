
namespace CRUD_Semana5.Controladores
{
    using CRUD_Semana5.Config;
    using CRUD_Semana5.Modelos;
    public class Usuarios_Controller
    {
        public List<Usuario_Model> Todos()
        {
            using (var db = new sqlServer_dbcontext())
            {
                return db.Usuarios
                         .Select(u => new Usuario_Model
                         {
                             Id_Usuario = u.Id_Usuario,
                             Nombre_Usuario = u.Nombre_Usuario,
                             Apellido_Usuario = u.Apellido_Usuario,
                             Cedula_Usuario = u.Cedula_Usuario,
                             Fecha_Ingreso = u.Fecha_Ingreso,
                             Estado = u.Estado,
                             Correo_Usuario = u.Correo_Usuario,
                             Id_Rol = u.Id_Rol,
                             RolNombre = db.Roles.Where(r => r.Id_Rol == u.Id_Rol).Select(r => r.Nombre_Rol).FirstOrDefault(),
                             nombre_completo = u.Nombre_Usuario + " " + u.Apellido_Usuario
                         })
                         .OrderBy(u => u.nombre_completo)
                         .ToList();
            }
        }

        public Usuario_Model ObtenerPorId(int id)
        {
            using (var db = new sqlServer_dbcontext())
            {
                var u = db.Usuarios.Find(id);
                if (u != null)
                {
                    u.RolNombre = db.Roles.Where(r => r.Id_Rol == u.Id_Rol)
                                          .Select(r => r.Nombre_Rol)
                                          .FirstOrDefault();

                    u.nombre_completo = u.Nombre_Usuario + " " + u.Apellido_Usuario;
                }

                return u;
            }
        }

        public (Usuario_Model usuario, string error) Insertar(Usuario_Model usuario)
        {
            if (usuario == null) return (null, "Los campos son obligatorios");
            if (string.IsNullOrWhiteSpace(usuario.Correo_Usuario)) return (null, "El correo es obligatorio");

            using (var db = new sqlServer_dbcontext())
            {
                if (db.Usuarios.Any(u => u.Correo_Usuario == usuario.Correo_Usuario))
                    return (null, "Ya existe un usuario con ese correo.");

                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return (usuario, null);
            }
        }

        public (bool ok, string error) Actualizar(Usuario_Model usuario)
        {
            if (usuario == null || usuario.Id_Usuario == 0) return (false, "Usuario inválido.");
            using (var db = new sqlServer_dbcontext())
            {
                var exist = db.Usuarios.Find(usuario.Id_Usuario);
                if (exist == null) return (false, "Usuario no encontrado.");
                exist.Nombre_Usuario = usuario.Nombre_Usuario;
                exist.Apellido_Usuario = usuario.Apellido_Usuario;
                exist.Cedula_Usuario = usuario.Cedula_Usuario;
                exist.Estado = usuario.Estado;
                // Solo actualizamos la contraseña si nos enviaron una, así evitamos sobreescribir si viene vacío
                if (!string.IsNullOrWhiteSpace(usuario.Contrasenia))
                    exist.Contrasenia = usuario.Contrasenia;
                exist.Correo_Usuario = usuario.Correo_Usuario;
                exist.Id_Rol = usuario.Id_Rol;
                db.SaveChanges();
                return (true, null);
            }
        }

        public (bool ok, string error) Eliminar(int id)
        {
            if (id == 0) return (false, "Id inválido");
            using (var db = new sqlServer_dbcontext())
            {
                var exist = db.Usuarios.Find(id);
                if (exist == null) return (false, "Usuario no encontrado.");
                db.Usuarios.Remove(exist);
                db.SaveChanges();
                return (true, null);
            }
        }
    }
}
