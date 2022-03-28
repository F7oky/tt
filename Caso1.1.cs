using System;

namespace Caso1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] direcFlechas; //Declaracion del Arreglo
            ushort cantidad_flechas;
            do
            {
                Console.WriteLine("Introducir las direcciones de las flechas");
                cantidad_flechas = UInt16.Parse(Console.Readline());
            } while (cantidad_flechas <=0);
            flechas=new string[cantidad_flechas];
            for (int i = 0; i < cantidad_flechas; i++)// i=0
            {
                Console.WriteLine("Intrucir caracteres");
                flechas[i] = Console.Readline();

            }
             
             Console.WriteLine("se han guardado las " + cantidad_flechas 
             + "posiciones de las flechas\n dale enter para mostrarlos");
             for(int i=0;i<cantidad_flechas;i++)
             {
                 Console,WriteLine("Posicion" +i+" :"flechas[i]);

             }
             Console.Readkey();
             
            

        }

    }
}

    
