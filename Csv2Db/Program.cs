using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv2Db
{
    class Program
    {
        static void Main(string[] args)
        {
            var inicio = DateTime.Now;
            Read.Vendedor();
            Console.WriteLine(DateTime.Now - inicio);
        }
    }
}
