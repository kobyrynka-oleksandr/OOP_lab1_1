namespace OOP_lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle = triangle.Input();

            Console.WriteLine("a side: " + triangle[0]);
            Console.WriteLine("b side: " + triangle[1]);
            Console.WriteLine("c side: " + triangle[2]);
            triangle.Output();
        }
    }
}
