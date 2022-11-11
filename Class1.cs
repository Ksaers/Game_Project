using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pervoe_prilozhenie_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Знакомство");
            Console.WriteLine("Как Вас зовут?");
            string myname;
            myname = Console.ReadLine();
            Console.WriteLine("Привет, " + myname);
            Console.WriteLine("Нажмите любую клавишу для выхода из программы");
            Console.ReadLine();
        }
    }
}