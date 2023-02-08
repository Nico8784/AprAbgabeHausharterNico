using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestÜbung
{
    internal abstract class Baum
    {
        public int hoehe { get; set; }
        public int Stammdurchmesser { get; set; }

        private DateTime setzDatum;

        public DateTime SetzDatum
        {
            get { return setzDatum; }
            protected set 
            {
                if (value<=DateTime.Now)
                {
                    setzDatum = value;
                }
            }
        }
        public void Heizen()
        {
            Console.WriteLine("Der Baum brennt gut!");
        }
        public abstract void Wachsen();
    }
    
}
