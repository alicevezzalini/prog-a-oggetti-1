using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_a_oggetti_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato q = new Quadrato();    
            q.Lato = float.Parse(Console.ReadLine());
            Console.WriteLine("{0}", q.Lato * q.Lato);
            Console.ReadLine();
        }
    }
}
