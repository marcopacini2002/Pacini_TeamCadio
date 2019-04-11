using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardio_pacini
{
    class ControlloValori
    {

        //metodo per il controllo del minimo
        public static int ControlloMin(double minimo)
        {
            int i = 0;
            try
            {
                if(minimo>0&&minimo<200)
                {
                    
                }else
                {
                    i = -1;
                }

            }catch(Exception)
            {
                i = -1;
            }
            return i;
        }
        //metodo per controllare età 
        public static int ControlloEta(int età)
        {
            int i = 0;
            try
            {
                Convert.ToInt32(età);
                if (età > 0 && età <= 120)
                {
                 
                }
                else
                {
                   i = -1;
                }

            }
            catch (Exception)
            {
                i = -1;
            }


            return i;
        }

        //metodo per controllare Peso
        public static double ControlloPeso(double peso)
        {
            int i = 0;
            try
            {
                Convert.ToDouble(peso);
                if (peso > 0 && peso <= 700)
                {
                   
                }
                else
                {
                    i = -1;
                }

            }
            catch (Exception)
            {
                i = -1;
            }


            return i;
        }

        //metodo per controllare frequenza
        public static double ControlloFrequenza(double frequenza)
        {
            int i = 0;
            try
            {
                Convert.ToDouble(frequenza);
                if (frequenza > 0 && frequenza <= 200)
                {
                    
                }
                else
                {
                    i = -1;
                }

            }
            catch (Exception)
            {
                i = -1;
            }


            return i;
        }

        //metodo per il controllo della durata
        public static double ControlloDurata(double durata)
        {
            int i = 0;
            try
            {
                Convert.ToDouble(durata);
                if (durata >= 0 && durata <= 40)
                {
                    
                }
                else
                {
                    i = -1;
                }

            }
            catch (Exception)
            {
                i = -1;
            }


            return i;
        }

        //metodo per il controllo di km
        public static int ControlloKm(int km)
        {
            int i = 0;
            try
            {
                Convert.ToDouble(km);
                if (km >= 0 && km <= 200)
                {

                }
                else
                {
                    i = -1;
                }

            }
            catch (Exception)
            {
                i = -1;
            }


            return i;
        }
    }
}
