using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab_Interfaces
{
    public class Rectangle : IDrawable
    {
        private int height;
        private int width;

        public Rectangle(int width,int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width
        {
            get
            {
                return this.width;
            }
           private set
            {
                this.width = value;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.height = value;
            }
        }
        public void Draw()
        {
            DrawLine(this.Width,'*','*');
            for (int i = 1; i<this.Height-1; i++)
            {
                DrawLine(this.Width,' ','*');
            }

            DrawLine(this.Width,'*','*');
        }


        public void DrawLine(int width, char end, char mid)
        {
            Console.WriteLine(end);
            for (int i = 1; i<width - 1; i++)
            {
                Console.WriteLine(mid);
            }
            Console.WriteLine(end);
        }
    }
}
