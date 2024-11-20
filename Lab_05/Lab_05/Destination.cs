using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05
{
    internal class Destination
    {
        public string PortName {  get; set; }
        public int Distance { get; set; }

        public Destination(int distance, string portName)
        {
            PortName = portName;
            Distance = distance;
        }
    }
}
