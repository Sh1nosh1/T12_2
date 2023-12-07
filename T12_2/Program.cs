using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1

                /*Build dom1 = new Build("Darya",40,5);
                dom1.ShowInfo();

                Build dom2 = new Build("Artem", 55, 11);
                dom2.ShowInfo();

                Write("\nEnter name: ");
                string name = ReadLine();
                Write("\nEnter area: ");
                int area = Convert.ToInt32(ReadLine());
                Write("Enter kvo: ");
                int kvo = Convert.ToInt32(ReadLine());
                Write("\nEnter number of floors: ");
                int floor = Convert.ToInt32(ReadLine());

                Build dom3 = new Build(name,area,kvo,floor);
                dom3.ShowWarning();*/


                //Task 2

                /*Computer computer = new Computer("IBM",12,512);
                computer.Info();*/


                //Task 3

                /*Transport transport = new Transport("Автомобиль","Вишнёвый",340,2);
                transport.ShowInfo();*/

                //Task 4

                Figura figura = new Figura("Square", 5, 5, 5, 5);
                figura.ShowArea();

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();

        }
    }
}
