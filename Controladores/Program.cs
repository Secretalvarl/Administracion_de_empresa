using Administracion_de_empresa.Servicios;

namespace Administracion_de_empresa.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 270923 - agb
    /// </summary>
    class Program
    {

        /// <summary>
        /// Metodo de inicio de la aplicacion
        /// 2709233 - agb
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz alpha = new MenuImplementacion();
            alpha.mostrarMensajeBienvenida();

            //Variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;

            //contener la opcion del usuario
            int opcionSeleccionada;

            //Desde la primera iteracin debe cumplirse la condicion
            while (!cerrarMenu)
            {
                opcionSeleccionada = alpha.mostrarMenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 1:
                        Console.WriteLine("[INFO] - SE EJECUTA CASO 1");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - SE EJECUTA CASO 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - SE EJECUTA CASO 3");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna");
                        break;
                }
            }
        }
    }
}
