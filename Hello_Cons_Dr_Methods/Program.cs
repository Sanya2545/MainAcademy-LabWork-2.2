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
            Box box = new Box();
            List<int> array = box.returnArray();
            int MaxElement = box.MaxValue(array);
            Console.WriteLine("Max element : " + MaxElement);
            //try
            //{
            //    //Implement start position, width and height, symbol, message input
               
            //    //Create Box class instance

            //    //Use  Box.Draw() method

            //    Console.WriteLine("Press any key...");
            //Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error!");
            //}
            
        }
    }
}
