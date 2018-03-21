using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreolita
{
    public class AccionesCarreola
    {
        bool estadoCarreolaAbierta = true;
        bool estadoCarreolaCerrada = true;
        bool estadoPasear = true;
        bool estadoFrenar = true;
        bool estadoFreno = true;
        public void CarreolaAbierta()
        {
            if (estadoCarreolaAbierta == true)
            {
                Console.WriteLine("Carreola abierta");
                estadoCarreolaAbierta = false;
            }
            else
            {
                Console.WriteLine("La carreola esta abierta");
                estadoCarreolaAbierta = true;
            }
        }
        public void CarreolaCerrada()
        {
            if (estadoCarreolaCerrada == true)
            {
                Console.WriteLine("Carreola cerrada");
                estadoCarreolaCerrada = false;
            }
            else if (estadoCarreolaCerrada == false)
                Console.WriteLine("La carreola esta cerrada");
        }
        public void PasearBendicion()
        {
            if (estadoCarreolaCerrada == false && estadoPasear == true)
            {
                Console.WriteLine("La bendición no se puede pasear, la carreola esta cerrada");
                estadoPasear = false;
            }
            else 
            {
                Console.WriteLine("La bendicion se está paseando");
                estadoPasear = false;
            }
        }
        public void FrenarCarreola()
        {
            if (estadoPasear == true && estadoFrenar == true)
            {
                Console.WriteLine("El freno está puesto, no se puede pasear la bendición");
                estadoFrenar = false;
            }
            else
            {
                Console.WriteLine("La carreola no esta frenada");
                estadoFrenar = true;
            }
        }
        public void QuitarFreno()
        {
            if (estadoFreno == true)
            {
                Console.WriteLine("El freno esta aplicado");
                estadoFreno = false;
            }
            else
            {
                Console.WriteLine("El freno se ha retirado");
                estadoFreno = true;
            }
        }
    }
}
