using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreolita
{
    public class AccionesCarreola
    {
        bool estadoCarreola = false;
        bool estadoPasear = false;
        bool estadoFrenar = false;
        //metodo de  carreola abierta
        public void CarreolaAbierta()
        {
            if (estadoCarreola == false)
            {
                Console.WriteLine("Carreola abierta");
                estadoCarreola = true;
            }
            else
            {
                Console.WriteLine("La carreola esta abierta");
            }
        }
        public void CarreolaCerrada()
        {
            if (estadoCarreola == true && estadoPasear == true)
            {
                Console.WriteLine("NO ES POSIBLE PASEAR AL BEBE, LA CARREOLA ESTA CERRADA.");
            }
            else if (estadoCarreola == true && estadoPasear == false)
            {
                Console.WriteLine("Carreola cerrada");
                estadoCarreola = false;
            }else if (estadoCarreola == false)
            {
                Console.WriteLine("La carreola se encuentra cerrada");
            }
        }
        public void PasearBendicion()
        {
            if (estadoPasear == false && estadoCarreola == true)
            {
                Console.WriteLine("La bendición se está paseando...");
                estadoPasear = true;
            }
            else if(estadoCarreola == false)
            {
                Console.WriteLine(" ------------PRECAUCIÓN");
                Console.WriteLine(" NO SE PUEDE PASEAR LA BENDICIÓN, LA CARREOLA ESTÁ CERRADA");
                estadoCarreola = false;
            }else if (estadoPasear == true)
            {
                Console.WriteLine("La bendción se encuentra paseandose.");
            }
        }
        public void FrenarCarreola()
        {
            if (estadoFrenar == false)
            {
                Console.WriteLine("La carreola está frenada.");
                estadoFrenar = true;
            }
            else if(estadoFrenar == true && estadoPasear == true)
            {
                Console.WriteLine("LA CARREOLA SE ENCUENTRA FRENADA.");
                estadoFrenar = false;
            }else if (estadoFrenar == true)
            {
                Console.WriteLine("LA CARREOLA YA ESTÁ FRENADA");
            }
        }
        public void QuitarFreno()
        {
            if (estadoFrenar == true)
            {
                Console.WriteLine("Se ha quitado el freno");
                estadoFrenar = false;
            }
            else if(estadoFrenar == false)
            {
                Console.WriteLine("LA CARREOLA NO ESTÁ FRENADA");
            }
        }
    }
}
