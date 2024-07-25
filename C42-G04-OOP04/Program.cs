namespace C42_G04_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Rectangler rectangler = new Rectangler();
            rectangler.Width= 10;
            rectangler.height= 10;
            Console.WriteLine(rectangler.GetArea());
            Console.WriteLine(rectangler.perimeter);
        }
    }
}
