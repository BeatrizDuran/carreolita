using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreolita
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int valor;
            AccionesCarreola acciones = new AccionesCarreola();
            try
            {
                Console.WriteLine("-------------------MENU DE CARREOLA----------------");
                Console.WriteLine("     1. Carreola abierta");
                Console.WriteLine("     2. Carreola cerrada");
                Console.WriteLine("     3. Pasear bendición");
                Console.WriteLine("     4. Frenar carreola");
                Console.WriteLine("     5. Quitar freno");
                Console.WriteLine("     6. Salir");
                Console.WriteLine("     Ingrese alguna opción:");
                do
            {
                    valor = int.Parse(Console.ReadLine());
                    switch (valor)
                    {
                        case 1:
                            acciones.CarreolaAbierta();
                            break;
                        case 2:
                            acciones.CarreolaCerrada();
                            break;
                        case 3:
                            acciones.PasearBendicion();
                            break;
                        case 4:
                            acciones.FrenarCarreola();
                            break;
                        case 5:
                            acciones.QuitarFreno();
                            break;
                        case 6:
                            break;
                    }
            } while (valor != 7);
            }
            //Mandar el mensaje de error 
            catch (FormatException er)
            {
                Console.WriteLine(er.ToString());
            }
            catch(StackOverflowException error)
            {
                Console.WriteLine(error.ToString());
            }
            Console.ReadKey();
        }
    }
}
