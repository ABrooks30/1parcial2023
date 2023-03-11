using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorradorParcial1
{
    internal class CIsmenu
    {
        //menu
        public static void main(String[] args)
        {
            int option = 0;
            do
            {

                Console.Clear();
                Console.WriteLine("=== Menú ===");
                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Ingresar Paso Vehicular.");
                Console.WriteLine("3. Consulta de vehículos x Número de Placa");
                Console.WriteLine("4. Modificar Datos Vehículos x número de Placa");
                Console.WriteLine("5. Reporte Todos los Datos de los vectores");
                Console.WriteLine("6. Salir");
                Console.Write("Ingrese su opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CIsTransacciones transacciones = new CIsTransacciones();
                        transacciones.InicializarVectores();
                        break;

                    case 2:


                        break;

                    case 3:


                        break;

                    case 4:


                        break;

                    case 5:


                        break;

                }
            } while (option != 6);
        }
    }
}