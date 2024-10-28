namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine($"Cirkel 1: {circle1.GetArea()}\n" +
                $"Cirkel 2: {circle2.GetArea()}");
        }
    }

    class Circle
    {
        public float _pi = 3.141f;
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }
        public float GetArea()
        {
            return Radius * Radius * _pi;
        }
    }
}
