using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenTecnico
{
    class Program
    {

        static void Main(string[] args)
        {  
            Console.WriteLine("Ingrese el numero a comparar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            //Punto 1
            
            List<int> numerosPunto1CasoTrue =new List<int> {  1,3,4,4};
            Console.WriteLine("Los elemento de la lista son : 1, 3, 4, 4");
            Console.WriteLine($"El numero ingresado es: {numero}");
            var resultado = numerosPunto1CasoTrue.Any(primerNumero=> numerosPunto1CasoTrue.Any(segundoNumero=> primerNumero + segundoNumero == numero));
            Console.WriteLine($"El resultado es: {resultado}");
            
            //Punto 2
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            List<int> numerosPunto1CasoFalse = new List<int>{ 1, 4, 3, 9};
            Console.WriteLine("Los elemento de la lista son : 1, 4, 3, 9");
            Console.WriteLine($"El numero ingresado es: {numero}");
            int i = 0;
            int j = 0;
            int suma = 0;
            bool encontrado = false;
            while (i < numerosPunto1CasoFalse.Count && !encontrado)
            {
                j = i + 1;
                while (j < numerosPunto1CasoFalse.Count && !encontrado)
                {
                    suma = numerosPunto1CasoFalse[i] + numerosPunto1CasoFalse[j];
                    if (suma == numero)
                    {
                        encontrado = true;
                    }
                    j++;
                }
                i++;
            }
            Console.WriteLine($"el resultado es :{encontrado}");
        }
    }
}
