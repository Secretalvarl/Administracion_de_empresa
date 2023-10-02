using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_de_empresa.Servicios
{
    /// <summary>
    /// Clase de implementacion del Menu
    /// 270923 - agb
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Gestion";
            Console.WriteLine(mensaje);

        }


        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("1. Empleados");
            Console.WriteLine("2. Probedores");
            Console.WriteLine("3. Cerrar");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("4. Seleccione una opcion");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }

    }
}

