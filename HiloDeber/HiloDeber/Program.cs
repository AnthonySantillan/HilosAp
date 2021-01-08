using System;
using System.Threading;

namespace HiloDeber
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread hilo1 = new Thread(MetodoPorEjecutar);
            Console.WriteLine("Voy a ejecutar el hilo 1");
            hilo1.Start();
            Thread hilo2 = new Thread(MetodoPorEjecutar);
            Console.WriteLine("Voy a ejecutar el hilo 2");
            hilo2.Start(); 
            Thread hilo3 = new Thread(MetodoPorEjecutar);
            Console.WriteLine("Voy a ejecutar el hilo 3");
            hilo3.Start();

            //el join retorna los hilos al principal
          
        }
        public static void MetodoPorEjecutar()
        {
            //TO DO: Aqui pon tu codigo
            //almacenar hilo actual
         
            string corredor1,corredor2,corredor3;
            byte K;
            Console.Write("SU NOMBRE ES: "); corredor1 = Console.ReadLine();
            Console.Write("SU NOMBRE ES: "); corredor2 = Console.ReadLine();
            Console.Write("SU NOMBRE ES: "); corredor3 = Console.ReadLine();
            for (K = 1; K <= 100; K++)
            {
                var random = new Random();

                Console.SetCursorPosition(K, 12);
                Console.Write(" " + corredor1);
                System.Threading.Thread.Sleep(random.Next(100, 500));

                Console.SetCursorPosition(K,13);
                Console.Write(" " + corredor2);
                System.Threading.Thread.Sleep(random.Next(100, 500));

                Console.SetCursorPosition(K, 14);
                Console.Write(" " + corredor3);
                System.Threading.Thread.Sleep(random.Next(100, 500));

                //REALIZAMOS UNA PAUSA;
                System.Threading.Thread.Sleep(random.Next(100, 500));
            }
            
            Console.WriteLine();
            Console.Write("Pulse una Tecla:"); Console.ReadLine();

        }

    }
}
