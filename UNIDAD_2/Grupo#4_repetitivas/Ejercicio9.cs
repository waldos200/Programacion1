using System;
class Ejercicio9
{
    static void Main(string[] args)
    {
        int edad, h, hombre_men_edad, m, mujer_men_edad;
        double edadhombres, edadmujeres, i, numero, prom_edad_hombres, prom_edad_mujeres;
        string sexo;

        hombre_men_edad = 0;
        mujer_men_edad = 0;
        h = 0;
        m = 0;
        prom_edad_hombres = 0;
        prom_edad_mujeres = 0;
        edadhombres = 0;
        edadmujeres = 0;

        Console.WriteLine("Cuantas Personas Desea Ingresar?");
        try
        {
            numero = Double.Parse(Console.ReadLine());
            for (i = 1; i <= numero; i++)
            {
                Console.WriteLine("Ingrese Edad");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Sexo");
                sexo = Console.ReadLine().ToUpper();
                if (edad > 0 && sexo.Equals("M") || sexo.Equals("F"))
                {
                    if (sexo.Equals("M"))
                    {
                        if (edad < 18)
                        {
                            hombre_men_edad = hombre_men_edad + 1;
                        }
                        edadhombres = edadhombres + edad;
                        h = h + 1;
                        prom_edad_hombres = edadhombres / h;
                    }
                    else
                    {
                        if (edad < 18)
                        {
                            mujer_men_edad = mujer_men_edad + 1;
                        }
                        edadmujeres = edadmujeres + edad;
                        m = m + 1;
                        prom_edad_mujeres = edadmujeres / m;
                    }
                }
            }
            Console.WriteLine("Asistieron A La Fiesta: " + numero + " Personas");
            Console.WriteLine("Hombres: " + h);
            Console.WriteLine("Mujeres: " + m);
            Console.WriteLine("Promedio Edad Hombres: " + prom_edad_hombres + " Años");
            Console.WriteLine("Promedio Edad Mujeres: " + prom_edad_mujeres + " Años");
            Console.WriteLine("Cantidad hombres que son menores de edadr: " + hombre_men_edad);
            Console.WriteLine("Cantidad mujeres que son menores de edad: " + mujer_men_edad);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}