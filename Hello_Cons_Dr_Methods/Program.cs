using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<int> array = box.returnArray();
            //int MaxElement = box.MaxValue(array);
            //Console.WriteLine("Max element : " + MaxElement);
            try
            {
                int startX = 50, startY = 50, length = 30, width = 5;
                char symbol = '*';
                string message = "Hello World ! Lorem ";
                Box box = new Box(startX, startY, length, width, symbol, message);
                box.Draw();
                Console.WriteLine("Press any key...");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
