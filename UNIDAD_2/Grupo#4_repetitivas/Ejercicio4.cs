/* En una empresa de 50 trabajadores, se hará un aumento al salario de
acuerdo con el tiempo de servicio, para este aumento se tomará en cuenta
lo siguiente: 

Tiempo de servicio -------------- Aumento
1 a menos de 5 años                 $25
De 5 y menos de 10 años             $50
De 10 y menos de 20 años            $100
De 20 años a más                    $150

Al final deberá imprimir el nombre, salario actual, el aumento y el nuevo
sueldo de cada trabajador. */

using System;

class Ejercicio4
{
    static void Main(string[] args)
    {
        string nombre;
        double salarioAct, nuevoSalario = 0;
        int anios;


        for (int i = 0; i <= 50; i++)
        {
            Console.Write("Digite su nombre completo: ");
            nombre = Console.ReadLine().ToUpper();

            try
            {
                Console.Write("Digite su salario actual: ");
                salarioAct = Convert.ToDouble(Console.ReadLine());
                Console.Write("Cuantos años a trabajado en la empresa: ");
                anios = Convert.ToInt32(Console.ReadLine());

                if (anios < 5)
                {
                    nuevoSalario = salarioAct + 25.00;
                }
                else if (anios >= 5 && anios < 10)
                {
                    nuevoSalario = salarioAct + 50.00;
                }
                else if (anios >= 10 && anios < 20)
                {
                    nuevoSalario = salarioAct + 100.00;
                }
                else
                {
                    nuevoSalario = salarioAct + 150.00;
                }

                Console.WriteLine("Este es el nombre del trabajador {0}, este es el salario actual {1:C2} y este es el nuevo salario a obtener {2:C2}", nombre, salarioAct, nuevoSalario);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                i--;
            }
        }
    }
}