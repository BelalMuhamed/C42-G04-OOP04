namespace C42_G04_OOP04
{
    internal class Point3D : IComparable,ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D() { }
        //override operators == and !=
        public static bool operator ==(Point3D a, Point3D b)
        {
            if(a.X==b.X && a.Y == b.Y && a.Z==b.Z) return true;
            else return false;
        }
        public static bool operator !=(Point3D a, Point3D b)
        {
            if (a.X != b.X && a.Y != b.Y && a.Z != b.Z) return true;
            else return false;
        }
        //icomparefunction 
        public int CompareTo(object? obj)
        {
            Point3D point =(Point3D)obj;
            if(this.X>point.X)return 1;
            else if (this.X < point.X) return -1;
            else 
            {
                if (this.Y > point.Y) return 1;
                else if (this.Y < point.Y) return -1;
                else
                {
                    return 0;
                }

            }
        }
        public override string ToString()
        {
            return $"Point cordinates is:({X},{Y},{Z})";
        }

        public object Clone()
        {
           return new Point3D(X=this.X,Y=this.Y,Z=this.Z);  
        }
    }

    class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }
    }

    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }   
        public Duration(int TotalSeconds) 
        {
            Hours = TotalSeconds / 3600;
            Minutes = (TotalSeconds % 3600) / 60;
            Seconds = TotalSeconds % 60;
        }
    }
    internal class Program
    {

        static double TkeCoordinate()
        {
            double coordinate;
           
            while (true)
            {
                bool flag = double.TryParse(Console.ReadLine(), out coordinate);
                if (flag)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid value ");
                }
            }
            return coordinate;
        }
        static Point3D readpoint (Point3D point)
        {
            Console.WriteLine("enter coordinate x ");
            point.X = TkeCoordinate();
            Console.WriteLine("enter coordinate y");
            point.Y = TkeCoordinate();
            Console.WriteLine("enter coordinate z");

            point.Z = TkeCoordinate();
            return point;
        }
    static void Main(string[] args)
        {
            Point3D point3D = new Point3D(10, 10, 10);
            Console.WriteLine(point3D);
            Point3D p01 = new Point3D();
            Point3D p02 = new Point3D();
            readpoint(p01);
            readpoint(p02);
            Console.WriteLine(p01);
            Console.WriteLine(p02);
            Console.WriteLine(p01==p02);//override the operator to can compare between two points
            Point3D[] points = new Point3D[]
        {
            new Point3D(3, 2, 7),
            new Point3D(1, 3, 6),
            new Point3D(7, 2, 5),
            new Point3D(0, 0, 0),
            p01,
            p02
        };
            Array.Sort(points);
            foreach (Point3D item in points)
            {
                Console.WriteLine(item);
            }
           Point3D p03= (Point3D)p02.Clone();
            Console.WriteLine(p03);

            #region SecondProject
            int a = 10;
            int b = 5;

            Console.WriteLine("Addition: " + Maths.Add(a, b));
            Console.WriteLine("Subtraction: " + Maths.Subtract(a, b));
            Console.WriteLine("Multiplication: " + Maths.Multiply(a, b));
            Console.WriteLine("Division: " + Maths.Divide(a, b));
            #endregion

            Duration duration = new Duration(10, 5, 3);
            Console.WriteLine(duration);

            Duration duratio = new Duration(7800);
            Console.WriteLine(duratio);

        }
    }
}
