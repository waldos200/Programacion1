using System;
class arreglos
{
    static void Main(string[] args)
    {
        int numeros[] = new int[5] { 0, 1, 2, 3, 4 };
        string colores[] = new string[3] { "rojo", "azul", "verde" };

        // Inicializacion omitiendo el tamaño de la matriz
        int[] numeros = new int[] { 0, 1, 2, 3, 4 };
        string[] colores = new string[] { "rojo", "azul", "verde" };

        // tambien podemos omitir el operador new
        int[] valores = { 0, 1, 2, 3, 4 };
        string[] colores = { "rojo", "azul", "verde" };
    }
}