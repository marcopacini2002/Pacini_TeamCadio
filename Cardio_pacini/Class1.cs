using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardio_pacini
{
    public class Class1
    {
        //ho creato il metodo per il controllo della frequenza cardiaca
        public static double FrequenzaCardiaca(int eta,ref double minimo)
        {
            double risultato = 0;
            int fconsigliata = 220 - eta;

            risultato=fconsigliata*0.9;
            minimo = fconsigliata * 0.7;

            return risultato;
        }
    }
}
