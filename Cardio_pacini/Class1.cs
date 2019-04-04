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
        public static int FrequenzaCardiaca(int eta)
        {
            int fconsigliata = 220 - eta;
            return fconsigliata;
        }
    }
}
