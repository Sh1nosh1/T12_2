using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_2
{
    internal class Transport
    {
        /// <summary>
        /// Type of transport
        /// </summary>
        public string type;
        /// <summary>
        /// Color
        /// </summary>
        public string color;
        /// <summary>
        /// Speed
        /// </summary>
        public int speed;
        /// <summary>
        /// Mass
        /// </summary>
        public int mass;
        /// <summary>
        /// Constructor without parametrs
        /// </summary>
        public Transport() { }
        /// <summary>
        /// Constructor with parametrs
        /// </summary>
        /// <param name="type"></param>
        /// <param name="color"></param>
        /// <param name="speed"></param>
        /// <param name="mass"></param>
        public Transport(string type, string color, int speed, int mass)
        {
            this.type = type;
            this.color = color;
            this.speed = speed;
            this.mass = mass;
        }
        /// <summary>
        /// Output
        /// </summary>
        public void ShowInfo()
        {
            WriteLine($"Тип: {type}\tЦвет: {color}\tСкорость: {speed} км/ч\tМасса: {mass} т\n");
        }
    }
}
