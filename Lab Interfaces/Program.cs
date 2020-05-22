using System;

namespace Lab_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);
            Console.WriteLine("Enter width: ");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height); 
           


           
          
            circle.Draw();
            rect.Draw();
           
            Console.ReadKey();
        }
    }
}
