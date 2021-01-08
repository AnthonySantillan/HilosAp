using System;
using System.Threading;

namespace hilovertical
{
    class Program
    {
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        static void Main(string[] args)
        {
            Thread hilo1 = new Thread(MetodoPorEjecutar);
            Console.WriteLine("Voy a ejecutar el hilo 1");
            hilo1.Start();
            Thread hilo2 = new Thread(Corredor2);
            Console.WriteLine("Voy a ejecutar el hilo 2");
            hilo2.Start();
            Thread hilo3 = new Thread(Corredor3);
            Console.WriteLine("Voy a ejecutar el hilo 3");
            hilo3.Start();

            hilo1.Join();
            hilo2.Join();
            hilo3.Join();

            //el join retorna los hilos al principal

        }
        public static void MetodoPorEjecutar()
        {
            string corredor1;
            //Console.Write("SU NOMBRE ES: "); corredor1 = Console.ReadLine();
            //Console.Write("SU NOMBRE ES: "); corredor2 = Console.ReadLine();
            //Console.Write("SU NOMBRE ES: "); corredor3 = Console.ReadLine(); 
            corredor1 = "Sol";
             //string NOM;
            string UN;
            int K = 0;
            int P = 0;
            int CI = 0;
            Console.Clear();
            Console.Write(corredor1);
            Console.SetCursorPosition(25, 1);
            CI = 25;
            corredor1 = corredor1.ToUpper();
            for (P = 1; P <= corredor1.Length; P++)
            {
                UN = Mid(corredor1, P - 1, 1);
                for (K = 1; K <= 10; K++)
                {
                    Console.SetCursorPosition(CI, K);
                    Console.Write(UN);
                    var random = new Random();
                    System.Threading.Thread.Sleep(random.Next(100, 500));
                    Console.SetCursorPosition(CI, K);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(CI, K);
                Console.Write(UN);
                CI = CI + 1;
            }
            Console.WriteLine();
            Console.Write("Ganador hilo1");
            Console.ReadKey();
        }
        public static void Corredor2()
        {
            string corredor2;
            //Console.Write("SU NOMBRE ES: "); corredor1 = Console.ReadLine();
            //Console.Write("SU NOMBRE ES: "); corredor2 = Console.ReadLine();
            //Console.Write("SU NOMBRE ES: "); corredor3 = Console.ReadLine();       
            corredor2 = "Sol";
  
            //string NOM;
            string DO;

            int K2 = 0;
            int P1 = 0;
            int CI2 = 0;
            Console.Clear();
            Console.Write(corredor2);
            Console.SetCursorPosition(50, 2);


            CI2 = 50;


            corredor2 = corredor2.ToUpper();

            for (P1 = 1; P1 <= corredor2.Length; P1++)
            {
                DO = Mid(corredor2, P1 - 1, 1);
                for (K2 = 1; K2 <= 10; K2++)
                {
                    Console.SetCursorPosition(CI2, K2);
                    Console.Write(DO);
                    var random = new Random();
                    System.Threading.Thread.Sleep(random.Next(100, 500));
                    Console.SetCursorPosition(CI2, K2);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(CI2, K2);
                Console.Write(DO);
                CI2 = CI2 + 2;
            }
            Console.WriteLine();
            Console.Write("Ganador hilo2");
            Console.ReadKey();
        }

        public static void Corredor3()
        {
            string corredor3;
            //Console.Write("SU NOMBRE ES: "); corredor1 = Console.ReadLine();
            //Console.Write("SU NOMBRE ES: "); corredor2 = Console.ReadLine();
            //Console.Write("SU NOMBRE ES: "); corredor3 = Console.ReadLine();       
            corredor3 = "Sol";

            //string NOM;
            string DO;

            int K3 = 0;
            int P1 = 0;
            int CI3 = 0;
            Console.Clear();
            Console.Write(corredor3);
            Console.SetCursorPosition(50, 2);


            CI3 = 100;


            corredor3 = corredor3.ToUpper();

            for (P1 = 1; P1 <= corredor3.Length; P1++)
            {
                DO = Mid(corredor3, P1 - 1, 1);
                for (K3 = 1; K3 <= 10; K3++)
                {
                    Console.SetCursorPosition(CI3, K3);
                    Console.Write(DO);
                    // REALIZAMOS UNA PAUSA
                    var random = new Random();
                     System.Threading.Thread.Sleep(random.Next(100, 500));
                    Console.SetCursorPosition(CI3, K3);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(CI3, K3);
                Console.Write(DO);
                CI3 = CI3 + 2;
            }
            Console.WriteLine();
            Console.Write("Ganador hilo3");
            Console.ReadKey();
        }

    }
}