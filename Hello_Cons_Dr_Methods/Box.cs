using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    //1
    class Box
    {
        private char symbolBorder = ' ';
        public int StartX{ get; private set; }
        public int StartY{ get; private set; }
        public int Length{ get; private set; }
        public int Width{ get; private set; }
        public Box(int startX = 0, int startY = 0, int width = 0, int height = 0, char symbol = ' ', string message = "")
        {
            StartX = startX;
            StartY = StartY;
            Length = width;
            Width = height;
            SymbolBorder = symbol;
            Message = message;
        }
        public char SymbolBorder {
            get
            {
               return symbolBorder;
            }
            private set
            {
                if(value == '*' || value == '+' || value == '.')
                {
                    symbolBorder = value;
                }
                else
                {
                    throw new ArgumentException("Wrong symbol to print border !");
                }
            }
         }
        public string Message { get; set; }
        //2
        public void Draw ()
        {
            draw(StartX, StartY, Length, Width, SymbolBorder, Message);

        }
        private void draw(int startX = 0, int startY = 0, int length = 0, int width = 0, char symbol = ' ', string message = "")
        {

            int X = StartX, Y = StartY;
            Console.SetCursorPosition(X, Y);
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < length; i++)
                {
                    if (j == 0 || j == width - 1) 
                    {
                        Console.SetCursorPosition(X + i, Y + j);
                        Console.Write(symbol);
                    }
                    else if (i == 0 || i == length - 1) 
                    {
                        Console.SetCursorPosition(X + i, Y + j);
                        Console.Write(symbol);
                    }
                    else Console.Write(" ");
                    if(i == Convert.ToInt32(length / 4) && j == width / 2)
                    {
                        Console.Write(Message);
                    }
                    if(Message.Length + length/4 > length)
                    {
                        throw new ArgumentOutOfRangeException("Text is too long !");
                    }
                }
                Console.WriteLine();
            }
            Message = Convert.ToString(Width * Length);
        }
        //1.  Implement public  auto-implement properties for start position (point position)
        //auto-implement properties for width and height of the box
        //and auto-implement properties for a symbol of a given set of valid characters (*, + ,.) to be used for the border 
        //and a message inside the box

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message

        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary

    }
}
