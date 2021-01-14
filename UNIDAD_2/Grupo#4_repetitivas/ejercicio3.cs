using System;

public class MainClass {
  public static void Main (string[] args) {
    string dia;
    int diurna, nocturna, horas1, horas2, pago;
    Console.WriteLine ("Escriba el dia de la semana");
    dia =Console.ReadLine().ToLower();
    if (dia=="domingo"){
      diurna = 10;
      nocturna = 20;

      int i;
      for(i=1; i<21;i++)
      {
        try
        {
          Console.WriteLine("\n Digite las horas diurnas del empleado {0}", i );
          horas1 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("\n Digite las horas nocturnas del empleado {0}", i );
          horas2 = Convert.ToInt32(Console.ReadLine());

          pago= (horas1*diurna) + (horas2*nocturna);

          Console.WriteLine("\n El salario del dia {0} para el empleado {1} es: {2}$", dia, i, pago);

          Console.WriteLine("\n *******************************************************");
        }
        catch(Exception error)
        {
         Console.WriteLine("Error "+error.Message);
        }

      }



    }
    else if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes" || dia == "sabado"){
      diurna = 5;
      nocturna = 10;

      int i;
      for(i=1; i<21;i++)
      {
        try
        {
          Console.WriteLine("\n Digite las horas diurnas del empleado {0}", i );
          horas1 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("\n Digite las horas nocturnas del empleado {0}", i );
          horas2 = Convert.ToInt32(Console.ReadLine());

          pago= (horas1*diurna) + (horas2*nocturna);

          Console.WriteLine("\n El salario del dia {0} para el empleado {1} es: {2}$", dia, i, pago);

          Console.WriteLine("\n *******************************************************");
        }
        catch(Exception error)
        {
         Console.WriteLine("Error: "+error.Message);
        }

      }
    }
    else{
      Console.WriteLine("Error : Escriba un dia de la semana correctamente");
    }

  }
}