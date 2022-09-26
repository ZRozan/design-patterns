using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozan.Patterns.OOP
{
    public class Wolf : Dog
    {
        public string Hierarchy { get; set; }

        public Wolf(string hierarchy)
        {
            Sound = "Howl";
            Hierarchy = hierarchy;
        }

        public void Howl()
        {
            Console.WriteLine("Auu!");
        }
    }
}
