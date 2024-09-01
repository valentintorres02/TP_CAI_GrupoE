using TP_CAI.Archivos.Usuario;
using TP_CAI.Archivos.Validaciones;

namespace TP_CAI.Archivos.Usuario.Entidad
{
    internal class InicioDeSesionModel
    {
        public List<UsuarioEntidad> Usuarios = new()
        {
            new() {NombreUsuario = "admin", Contrasenia = "admin", Rol = UsuarioRoles.Admin},
            new() {NombreUsuario = "jefedeposito", Contrasenia = "jefedeposito", Rol = UsuarioRoles.JefeDeposito},
            new() {NombreUsuario = "operariodeposito", Contrasenia = "operariodeposito", Rol = UsuarioRoles.OperarioDeposito},
            new() {NombreUsuario = "cliente", Contrasenia = "cliente", Rol = UsuarioRoles.Cliente},
        };

        public Validacion<UsuarioEntidad> ValidarUsuarioIngresado(string nombreUsuario, string contrasenia)
        {
            Validacion<UsuarioEntidad> validacion = new Validacion<UsuarioEntidad>();

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia))
            {
                validacion.Estado = ValidacionEstados.Error;
                validacion.Mensaje = "Por favor, complete todos los campos.";

                return validacion;
            }

            foreach (var usuario in Usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario && usuario.Contrasenia== contrasenia)
                {
                    validacion.Estado = ValidacionEstados.Ok;
                    validacion.Data = usuario;
                    return validacion;
                }
            }

            validacion.Estado= ValidacionEstados.Error;
            validacion.Mensaje = "Credenciales Incorrectas";
            return validacion;

        }
    }
}
