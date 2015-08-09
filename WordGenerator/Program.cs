using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Create("Dico.xt");

            StreamReader reader;
            StreamWriter writer = new StreamWriter("Dico.txt");

            writer.WriteLine("Fuuuuuck");

            
        }
    }
}
