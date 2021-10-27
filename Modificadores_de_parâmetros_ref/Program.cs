using System;

namespace Modificadores_de_parâmetros_ref_e_out {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            Caculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
