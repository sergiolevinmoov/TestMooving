using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMooving.Ejercicio1
{
    public class Ejercicio1
        {
            private static string result ;

            public static void DiAlgo()
            {
                DiAlgoAsync();
                Console.WriteLine("Result :" + result);
            }

            static async Task<string> DiAlgoAsync()
            {
                await Task.Delay(5);
                result = "Hola!";
                return "Algo";
            }
        }
}
