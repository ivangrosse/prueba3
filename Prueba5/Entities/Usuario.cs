using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba5.Entities
{
    public class Usuario
    {
        private int idEmpleado { get; set; }
        private string nombreUsuario { get; set; }
        private string contrasena { get; set; }
        private bool esAdministrador { get; set; }
        private bool habilitado { get; set; }
        private bool contrasenaRestaurada { get; set; }


    }
}