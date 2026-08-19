using System.Threading.Channels;

namespace repaso_funciones_ahora_metodos_
{
    internal class Program
    {

        // arriba
        //proto 1
        // visibilidad - comportamiento - tipo de retorno - nombre - si recibe parametros - llaves(no siempre)

        private static void Main(string[] args)
        {
            
           
        }

        private static void Sumar1()
        {
            Console.Write("Ingrese el primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"La suma entre {numero1} y {numero2} = {numero1 + numero2}");
        }
        //proto 2
        private static int Sumar2()
        {
            Console.Write("Ingrese el primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());
            int suma = numero1 + numero2;
            return suma;

        }
        //proto 3
        private static void Sumar3(int numero1, int numero2)
        {
            Console.WriteLine($"La suma entre {numero1} y {numero2} = {numero1 + numero2}");
        }

        //proto 4
        private static int Sumar4(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            return suma;
        }


        // abajo



    }

}
