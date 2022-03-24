using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dias_vividos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe sua idade um anos:");
            uint anos = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Informe sua idade em meses:");
            uint meses = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Informe sua idade em dias:");
            uint dias = Convert.ToUInt16(Console.ReadLine());

            uint vividos = (anos * 365) + (meses * 30) + dias;
            Console.Write("O total de dias vividos é:" + vividos);
            Console.ReadLine();
        }
    }
}
