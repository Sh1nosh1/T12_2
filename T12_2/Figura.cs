using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_2
{
    internal class Figura
    {
        /// <summary>
        /// Name
        /// </summary>
        public string name;

        /// <summary>
        /// The first side
        /// </summary>
        public int st1;

        /// <summary>
        /// The second side
        /// </summary>
        public int st2;

        /// <summary>
        /// The third side
        /// </summary>
        public int st3;

        /// <summary>
        /// The fourth side
        /// </summary>
        public int st4;

        /// <summary>
        /// Constructor without parametrs
        /// </summary>
        public Figura() { }

        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="name"></param>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <param name="st3"></param>
        /// <param name="st4"></param>
        public Figura(string name, int st1, int st2, int st3, int st4)
        {
            this.name = name;
            this.st1 = st1;
            this.st2 = st2;
            this.st3 = st3;
            this.st4 = st4;
        }

        /// <summary>
        /// Output
        /// </summary>
        public void ShowArea()
        {
            WriteLine($"Figure: {name}\n\nFirst side: {st1}\tSecomd side: {st2}\tThird side: {st3}\tFourth side: {st4}\n\nArea: {st1 * st2}");
        }
    }
}
