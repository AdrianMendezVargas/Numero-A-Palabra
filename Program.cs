using System;

namespace Numero_A_Palabra {
    class Program {
        static void Main(string[] args) {

            int numero;

            Console.Write("Introduzca un Numero: ");

            numero = Convert.ToInt32(Console.ReadLine());

            if(numero > 0 && numero <= 5) {

                Console.WriteLine(numero + " Se escribe: " + ToWord(numero));

            } else {
                Console.WriteLine("Numero no soportado");
            }
            
        }

        static string ToWord(int numero) {

            switch (numero) {

                case 1:
                    return "Uno";

                case 2:
                    return "Dos";

                case 3: 
                    return "Tres";

                case 4:
                    return "Cuatro";

                case 5:
                    return "Cinco";

            }

            return "numero no soportado";

        }

    }
}
