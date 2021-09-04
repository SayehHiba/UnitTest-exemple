using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculSimple monCalcul = new CalculSimple();
            monCalcul.Authentifier = new Authentification();
            monCalcul.Authentifier.Verifier("salah", "ali");
            Console.Write("Entrer la première opérande : ");
            double operande1 = Convert.ToDouble (Console.ReadLine());
            Console.Write("Entrer la deuxième opérande : ");
            double operande2 = Convert.ToDouble(Console.ReadLine());
            double resultat = monCalcul.Addition(operande1, operande2);
            Console.WriteLine(resultat);
            Console.ReadLine();
        }
    }
}
