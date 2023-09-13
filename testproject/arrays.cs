using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testproject
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            int[] sectors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;

            while(isOpen) 
            {
                Console.SetCursorPosition(0, 18);
                for(int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест.");
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Регистрация рейса");
                Console.WriteLine("\n\n1 - забронировать места\n \n2 - выходи из программы.");
                Console.WriteLine("Введите номер команды");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }
            }
        }
    }
}
