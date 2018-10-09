using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float width, length, height = 0;
            Console.WriteLine("Hello Welcome to the Dimension Calculator!");
            Console.WriteLine("Please Enter a Width");
            string input = Console.ReadLine();
             width = float.Parse(input);

            Console.WriteLine("Please Enter a Length");
             length = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter a Height");
             height = float.Parse(Console.ReadLine());

            float perimeter = CalcPerimeter(width,length);
            Console.WriteLine("The Perimeter of the room is " + perimeter);

            float area = length * width;
            Console.WriteLine("The Area of the Room is " + area);

            float volume = length * width * height;
            Console.WriteLine("The Volume of the Room is " + volume);
        }

        public static float CalcPerimeter(float width, float length)
        {
            float perimeter = (width * 2 ) + (2 *  length);
            return perimeter; 
        }

        public static void PrintPerimeter(float perimeter)
        {
            Console.WriteLine("The Perimeter of the room is " + perimeter);
        }

    }
}