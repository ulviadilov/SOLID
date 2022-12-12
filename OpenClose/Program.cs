namespace OpenClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.Side1 = 4;
            triangle.Side2 = 5;
            triangle.Side3 = 6;

            Rectangle rectangle = new Rectangle();  
            rectangle.Wigth = 4;
            rectangle.Heigth = 8;

            Circle circle = new Circle();
            circle.Radius = 4;

            Console.WriteLine("Triangle perimeter is => " + triangle.Perimeter());
            Console.WriteLine("Rectangle perimeter is => " + rectangle.Perimeter());
            Console.WriteLine("Circle perimeter is => " + circle.Perimeter());
        }
    }
}