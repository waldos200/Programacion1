using System;
class Ejemplo
{
    static void Main(string[] args)
    {
        int limite=10,num=1;
        while (num<=limite){
            for(int i=1;i<=10;i++){
                Console.WriteLine("{0}x{1}={2}",num,i,num*i);
            }
            limite++;
        }
    }
}