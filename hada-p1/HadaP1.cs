using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
        //Método que calcula los minutos equivalentes a ciertos segundos dados
        public static double Seconds2Minutes(double s)
        {
            double i = 0; //Variable para guardar el resultado de la operación
            if(s == 0) //Si se dan 0 segundos el resultado de minutos es 0
            {
                i = 0;
            }
            else
            {//Para lo demás, el resultado es dividir los segundos entre 60
                i = s / 60;
            }
            return i;
        }
        //Método que calcula los segundos equivalentes a ciertos minutos dados
        public static double Minutes2Seconds(double m)
        {
            double i = 0;//Variable para guardar el resultado de la operación
            if (m == 0)//Si se dan 0 minutos el resultado de segundos es 0
            {
                i = 0;
            }
            else
            {//Para lo demás, el resultado es multiplicar los minutos por 60
                i = m * 60;
            }
            return i; //Devolvemos el valor de la operación
        }
        //Método que calcula los minutos equivalentes a ciertas horas dadas
        public static double Hours2Minutes(double h)
        {
            double i = 0;//Variable para guardar el resultado de la operación
            if (h == 0)//Si se dan 0 minutos el resultado de segundos es 0
            {
                i = 0;
            }
            else//Para lo demás, el resultado es multiplicar los minutos por 60
            {
                i = h * 60;
            }
            return i;//Devolvemos el valor de la operación
        }

    }
}
