
using _CRUD_Semana5.Config;
using _CRUD_Semana5.Modelos;
using CRUD_Semana5.Modelos;
using Microsoft.Data.SqlClient;

namespace CRUD_Semana5.Controladores
{
    public class Auth_Controller
    {
        private readonly Conexion _cn = new Conexion();


        // Login con ADO.NET parametrizado (compara contrasenia en texto o hash segun tu implementación)
        public Usuario_Model login2(Login_Model login)
        {
            if (login == null || string.IsNullOrWhiteSpace(login.Correo_Usuario) || string.IsNullOrWhiteSpace(login.Contrasenia))
                return null;

            using (var cn = _cn.getConexion())
            {
                cn.Open();
                string cadena = @"SELECT U.*, R.Nombre_Rol FROM Usuarios U
                                  LEFT JOIN Roles R ON U.Id_Rol = R.Id_Rol
                                  WHERE U.Correo_Usuario = @correo AND U.Estado = 1";

                using (SqlCommand cmd = new SqlCommand(cadena, cn))
                {
                    cmd.Parameters.AddWithValue("@correo", login.Correo_Usuario);

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (!lector.Read()) return null;

                        var hashedOrPlain = lector["Contrasenia"].ToString();

                        // Si usas hashing (recomendado), compara con el hash
                        // Aquí se asume contraseña en texto para pruebas:
                        if (hashedOrPlain == login.Contrasenia)
                        {
                            Usuario_Model usuario = new Usuario_Model
                            {
                                Id_Usuario = Convert.ToInt32(lector["Id_Usuario"]),
                                Nombre_Usuario = lector["Nombre_Usuario"].ToString(),
                                Apellido_Usuario = lector["Apellido_Usuario"].ToString(),
                                Cedula_Usuario = lector["Cedula_Usuario"].ToString(),
                                Estado = Convert.ToBoolean(lector["Estado"]),
                                Contrasenia = hashedOrPlain,
                                Correo_Usuario = lector["Correo_Usuario"].ToString(),
                                Id_Rol = lector["Id_Rol"] == DBNull.Value ? null : (int?)Convert.ToInt32(lector["Id_Rol"]),
                                RolNombre = lector["Nombre_Rol"] == DBNull.Value ? null : lector["Nombre_Rol"].ToString()
                            };
                            return usuario;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public bool VerificarCedula(char[] validarCedula)
        {
            int aux = 0, par = 0, impar = 0, verifi;
            for (int i = 0; i < 9; i += 2)
            {
                aux = 2 * int.Parse(validarCedula[i].ToString());
                if (aux > 9)
                    aux -= 9;
                par += aux;
            }
            for (int i = 1; i < 9; i += 2)
            {
                impar += int.Parse(validarCedula[i].ToString());
            }

            aux = par + impar;
            if (aux % 10 != 0)
            {
                verifi = 10 - (aux % 10);
            }
            else
                verifi = 0;
            if (verifi == int.Parse(validarCedula[9].ToString()))
                return true;
            else
                return false;
        }
    }
}
