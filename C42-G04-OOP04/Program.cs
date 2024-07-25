namespace C42_G04_OOP04
{
    internal class Complex
    {
        public int real { get; set; }
        public int imaginary { get; set; }
        public static Complex operator+(Complex left, Complex right)
            {
            return new Complex {real=left.real + right.real , imaginary=left.imaginary+right.imaginary};
            }
           
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Rectangler rectangler = new Rectangler();
            rectangler.Width= 10;
            rectangler.height= 10;
            Console.WriteLine(rectangler.GetArea());
            Console.WriteLine(rectangler.perimeter);
            Complex c01 = new Complex() { real = 3,imaginary = 3};
            Complex c02 = new Complex() {real = 4,imaginary = 4};
            Complex c03 = new Complex();
            c03 = c01 + c02;
            Console.WriteLine(c03);
        }
    }
}
