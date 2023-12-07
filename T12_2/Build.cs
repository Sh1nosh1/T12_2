using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_2
{
    internal class Build
    {
        /// <summary>
        /// Name
        /// </summary>
        public string name;
        /// <summary>
        /// Area
        /// </summary>
        public int area;
        /// <summary>
        /// Quantity
        /// </summary>
        public int kvo;
        /// <summary>
        /// Floors
        /// </summary>
        public int floor;
        /// <summary>
        /// Constructor without parametrs
        /// </summary>
        public Build() { }
        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="name"></param>
        /// <param name="area"></param>
        /// <param name="kvo"></param>
        public Build(string name, int area, int kvo)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
        }
        public Build(string name, int area, int kvo, int floor) : this(name, area, kvo)
        {
            this.floor = floor;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void ShowInfo()
        {
            WriteLine($"Name: {name}\tArea: {area}\tKvo: {kvo}\tArea per occupant: {area / kvo}\n");
        }
        public void ShowWarning()
        {
            WriteLine($"Name: {name}\tArea: {area}\nKvo: {kvo}\tArea per occupant: {area / kvo}\tFloor: {floor}\n");
        }
    }
}
