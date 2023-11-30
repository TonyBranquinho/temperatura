using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            char escala;
            double f, c, temperatura;

            Console.WriteLine("Voce vai digitar a temperatura em qual escala (C/F)? ");
            escala = char.Parse(Console.ReadLine());

            if (escala == 'f') {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                temperatura = double.Parse(Console.ReadLine(), CI);
                f = (temperatura - 32) * 5 / 9;
                Console.WriteLine("Temperatura equivalente em Celsius: "+ f.ToString("F2"), CI);
            }
            else if (escala == 'c') {
                Console.Write("Digite a temperatura equivalente em Celsius: ");
                temperatura = double.Parse(Console.ReadLine(), CI);
                c = 1.8 * temperatura + 32;
                Console.WriteLine("Temperatura equivalente em Fahrenheit: "+ c.ToString("F2"), CI);

            }
        }
    }
}
