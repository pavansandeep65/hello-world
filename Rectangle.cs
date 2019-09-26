using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _8040_Assinment_1
{
   public class Rectangle
    {
        private int length;
        private int Width;

        public Rectangle()
        {
            length = 1;
            Width = 1;
        }

        public Rectangle(int length, int Width)
        {
            this.length = length;
            this.Width = Width;
        }

        public int Getlength()
        {
            return length;
        }

        public int GetLength()
        {
            throw new NotImplementedException();
        }

        public int Setlength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int SetWidth(int Width)
        {
            this.Width = Width;
            return this.Width;
        }

        public int GetPerimeter()
        {
            return (Width * 2) + (length * 2);
        }

        public int GetArea()
        {
            return length * Width;
        }

        public int SetWidth()
        {
            throw new NotImplementedException();
        }
    }
}
