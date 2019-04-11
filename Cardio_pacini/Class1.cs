using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardio_pacini
{
    public class Class1
    {
        //1:ho creato il metodo per il controllo della frequenza cardiaca
        public static double FrequenzaCardiaca(int eta,ref double minimo)
        {
            double risultato = 0;
            int fconsigliata = 0;
            int ControlloE = ControlloValori.ControlloEta(eta);
            int ControlloMin = ControlloValori.ControlloMin( minimo);

            if (ControlloE != -1 || ControlloMin != -1)
            {
                fconsigliata = 220 - eta;
                minimo = fconsigliata * 0.7;
                risultato = fconsigliata * 0.9;
            }

            return risultato;
        }


        //3: UOMO
        public static double CalorieBruciateUomo(int età, double peso, double frequenza, double durata)
        {
            double CalorieB = 0;
            int ControlloEtà = ControlloValori.ControlloEta(età);//richiamo il metodo ControlloEtà
            double ControlloPeso = ControlloValori.ControlloPeso(peso);//Richiamo il metodo ControlloPeso
            double ControlloFrequenza = ControlloValori.ControlloFrequenza(frequenza);//Richiamo il metodo ControlloFrequenza
            double ControlloDurata = ControlloValori.ControlloDurata(durata);//Richiamo il metodo ControlloDurata

            if (ControlloEtà != -1 && ControlloPeso != -1 && ControlloFrequenza != -1 && ControlloDurata != -1)
            {
                double calorie = (età * 0.2017) + (peso * 0.199) + (frequenza * 0.6309) - 55.0969;

                CalorieB = Math.Round(calorie * durata / 4.184);
            }
            else
            {
                CalorieB = 0;
            }

            return CalorieB;
        }

        //3: DONNA
        public static double CalorieBruciateDonna(int età, double peso, double frequenza, double durata)
        {
            double CalorieB = 0;
            int ControlloEtà = ControlloValori.ControlloEta(età);//richiamo il metodo ControlloEtà
            double ControlloPeso = ControlloValori.ControlloPeso(peso);//Richiamo il metodo ControlloPeso
            double ControlloFrequenza = ControlloValori.ControlloFrequenza(frequenza);//Richiamo il metodo ControlloFrequenza
            double ControlloDurata = ControlloValori.ControlloDurata(durata);//Richiamo il metodo ControlloDurata

            if (ControlloEtà != -1 && ControlloPeso != -1 && ControlloFrequenza != -1 && ControlloDurata != -1)
            {
                double calorie = (età * 0.074) + (peso * 0.126) + (frequenza * 0.4472) - 20.4022;

                CalorieB = Math.Round(calorie * durata / 4.184);
            }
            else
            {
                CalorieB = 0;
            }

            return CalorieB;
        }

    }
}
