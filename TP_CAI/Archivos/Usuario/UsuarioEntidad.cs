using TP_CAI.Archivos.Usuario;

namespace TP_CAI.Forms.InicioDeSesion.Model
{
    public class UsuarioEntidad
    {
        public UsuarioEntidad()
        { }

        public string NombreUsuario { get; internal set; }
        public string Contrasenia { get; internal set; }
        public UsuarioRoles Rol {  get; internal set; }

    }
}
