using System;

namespace ControlPeaje
{
    class ClsTransacciones
    {

        // declara vectores
        private string[] numFactura = new string[15];
        private string[] numPlaca = new string[15];
        private string[] fecha = new string[15];
        private string[] hora = new string[15];
        private int[] tipoVehiculo = new int[15];
        private int[] numCaseta = new int[15];
        private double[] montoPagar = new double[15];
        private double[] pagaCon = new double[15];
        private double[] vuelto = new double[15];


        // inicia los vectores
        public void InicializarVectores()
        {

            for (int i = 0; i < 15; i++)
            {
                numFactura[i] = "";
                numPlaca[i] = "";
                fecha[i] = "";
                hora[i] = "";
                tipoVehiculo[i] = 0;
                numCaseta[i] = 0;
                montoPagar[i] = 0;
                pagaCon[i] = 0;
                vuelto[i] = 0;
            }
            Console.WriteLine("Vectores inicializados");
        }

        // ingresar dtos
        public void IngresarDatos()

        {
            int i = 0;
            while (i < 15)
            {
                Console.WriteLine("Ingrese los datos de la transacción:");
                Console.Write("Número de factura: ");
                numFactura[i] = Console.ReadLine();
                Console.Write("Número de placa: ");
                numPlaca[i] = Console.ReadLine();
                Console.Write("Fecha (DD/MM/AAAA): ");
                fecha[i] = Console.ReadLine();
                Console.Write("Hora (HH:MM): ");
                hora[i] = Console.ReadLine();

                // Validar tipo auto
                int tipo;
                do
                {
                    Console.Write("Tipo de vehículo (1= Moto ,2= Vehículo Liviano, 3 =Camión o Pesado 4=Autobús): ");
                    tipo = Convert.ToInt32(Console.ReadLine());
                    if (tipo < 1 || tipo > 4)
                    {
                        Console.WriteLine("Tipo de vehículo inválido. Intente nuevamente.");
                    }
                } while (tipo < 1 || tipo > 4);
                tipoVehiculo[i] = tipo;

                // Validar caseta
                int caseta;
                do
                {
                    Console.Write("Número de caseta (1, 2, 3): ");
                    caseta = Convert.ToInt32(Console.ReadLine());
                    if (caseta < 1 || caseta > 3)
                    {
                        Console.WriteLine("Número de caseta inválido. Intente nuevamente.");
                    }
                } while (caseta < 1 || caseta > 3);
                numCaseta[i] = caseta;

                // monto pagar
                double monto = 0;
                switch (tipo)
                {
                    case 1:
                        monto = 5;
                        break;
                    case 2:
                        monto = 10;
                        break;
                    case 3:
                        monto = 15;
                        break;
                    case 4:
                        monto = 20;
                        break;
                }
            }
        }
    }
}






