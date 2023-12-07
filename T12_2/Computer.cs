using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_2
{
    internal class Computer
    {
        /// <summary>
        /// Model
        /// </summary>
        public string model;
        /// <summary>
        /// OZU
        /// </summary>
        public int OZU;
        /// <summary>
        /// PZU
        /// </summary>
        public int PZU;
        public Computer() { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="model"></param>
        /// <param name="OZU"></param>
        /// <param name="PZU"></param>
        public Computer(string model, int OZU, int PZU)
        {
            this.model = model;
            this.OZU = OZU;
            this.PZU = PZU;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void Info()
        {
            WriteLine($"Model:{model}\nOZU:{OZU}\tPZU:{PZU}");
        }
    }
}
