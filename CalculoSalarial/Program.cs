using System;

namespace CalculoSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------Bienvenido a la Applicacion de Calculo Salarial----------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("---Adams Del Rosario           17-EIIT-1-055-------------------------------------------------");
            Console.WriteLine("---Javier Moronta              17-EIIN-1-072-------------------------------------------------");
            Console.WriteLine("---Sebastian Mejia             17-EIIT-1-109-------------------------------------------------");
            Console.WriteLine("---Yeudy Cuevas                17-EIIN-1-177-------------------------------------------------");
            Console.WriteLine("---Gilbert Matos               17-EIIT-1-018-------------------------------------------------");
            Console.WriteLine("---Natanael Leger              17-EIIN-1-076 ------------------------------------------------");
            Console.WriteLine("---Angel Tavera                14-MIIN-1-089-------------------------------------------------");
            Console.WriteLine("---Sagiory Cuevas              17-EIIN-1-071-------------------------------------------------");
            Console.WriteLine("---Luis Beriguete              17-EIIN-1-092-------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Por favor introduzca el numero de Empleados");
            String respuesta = Console.ReadLine();
            int numeroDeEmpleado = Convert.ToInt32(respuesta);

            for (int i = 0; i < numeroDeEmpleado; i++ ) {
                Console.WriteLine("Por favor introduzca la cantidad de horas trabajadas");
                respuesta = Console.ReadLine();
                Decimal horasTrabajadas = Convert.ToDecimal(respuesta);

                Decimal salario = 0.0M;

                if (horasTrabajadas < 0) {
                    Console.WriteLine("Valor incorrecto. La cantidad debe ser mayor o igual a cero.");
                    System.Environment.Exit(1);

                } else if (horasTrabajadas <= 40) {
                    salario = horasTrabajadas * 20;
                } else {
                    salario = (40 * 20) + (horasTrabajadas - 40) * 25;
                }

                Console.WriteLine("El salario a pagar es: " + salario);
                
            }
            System.Environment.Exit(0);
        }
    }
}
