using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_de_empresa.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el mensaje
        /// 270923 - agb
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el Menu y recoge las ociones del menu
        /// 270923 - agb
        /// </summary>
        /// <returns></returns>

        public int mostrarMenuYSeleccion();
    }
}
