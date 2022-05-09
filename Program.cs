using System;

namespace Armstrong
{
    class Program
    {
        // Rôle : Indique si un nombre donné est un nombre d'Armstrong.
        // Paramètres d'entrée :
        // - nombre : nombre à tester (en entrée pure).
        // Valeur de sortie : true si c'est un nb d'Armstrong, false sinon.

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

            int Nombre;

            try {

            Nombre = Convert.ToInt32(Console.ReadLine());

            }

            catch(Exception e) {

                Console.WriteLine("e.Message");
                return;
            }

            Console.Writeline(NombreArmstrong(Nombre));
        }
    }
}

