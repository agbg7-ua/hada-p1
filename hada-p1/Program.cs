using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta1,respuesta3;
            double respuesta2;
            do
            {
                HadaP1 hadap1 = new HadaP1();
                Console.WriteLine("¿Cuál es la unidad?");
                respuesta1 = Console.ReadLine();
                Console.WriteLine("¿Cantidad?");
                respuesta2 = Console.ReadLine().double.Parse;
                if(respuesta1 == "segundos")
                {
                    hadap1.Secons2Minutes(respuesta2);
                }else if(respuesta1 == "minutos")
                {
                    hadap1.Minutes2Seconds(respuesta2);
                }
                else
                {
                    hadap1.Hours2Minutes(respuesta2);
                }
                Console.WriteLine("¿Quiere realizar más conversiones?");
                respuesta3 = Console.ReadLine();
            } while (respuesta3 == "si");
            
            

            }
        }
    }
}
