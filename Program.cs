using System;

namespace Armstrong
{
    class Program
    {
        static bool NombreArmstrong(int nb) {

            if (((nb/100)<1) || (nb/100)>=10) {

                Console.WriteLine("l'entier doit contenir trois chiffres");

            }
            else {

                int Centaine;
                int Dizaine;
                int Unite;
                int Reste;

                Centaine=nb/100;

                Reste=nb%100;

                Dizaine=Reste/10;

                Unite=Reste%10;

                if(Centaine*Centaine*Centaine + Dizaine*Dizaine*Dizaine + Unite*Unite*Unite == nombre) {

                    return true;
                }

                return false;


        }

        static void Main(string[] args)
        {
            Console.WriteLine(Armstrong(370));
        }
    }
}
