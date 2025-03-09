namespace HW1
{
    abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract bool IsValid();
    }

    class Rectangle : Shape
    {
        public double Length;
        public double Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            if (!IsValid())
            {
                return 0;
            }
            return Length * Width;
        }

        public override bool IsValid()
        {
            return Length > 0 && Width > 0;
        }
    }

    class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public override double CalculateArea()
        {
            if (!IsValid())
            {
                return 0;
            }
            return Side * Side;
        }
        public override bool IsValid()
        {
            return Side > 0;
        }
    }

    class Triangle : Shape
    {
        public double SideA;
        public double SideB;
        public double SideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            if (!IsValid())
            {
                return 0;
            }

            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override bool IsValid()
        {
            return SideA > 0 && SideB > 0 && SideC > 0 &&
                   SideA + SideB > SideC &&
                   SideA + SideC > SideB &&
                   SideB + SideC > SideA;
        }
    }
    class Circle : Shape
    {
        public double R;

        public Circle(double r)
        {
            R = r;
        }

        public override double CalculateArea()
        {
            if (!IsValid())
            {
                return 0;
            }

            return 3.14*R*R;
        }

        public override bool IsValid()
        {
            return R > 0;
        }
    }
    class ShapeFactory
    {
        private static Random random = new Random();

        public static Shape CreateShape()
        {
            // 随机生成形状类型
            int shapeType = random.Next(0, 4); 

            switch (shapeType)
            {
                case 0:
                    double length = random.Next(1, 10);
                    double width = random.Next(1, 10);
                    return new Rectangle(length, width);

                case 1:
                    double side = random.Next(1, 10);
                    return new Square(side);

                case 2:
                    double sideA = random.Next(1, 10);
                    double sideB = random.Next(1, 10);
                    double sideC = random.Next(1, 10);
                    return new Triangle(sideA, sideB, sideC);
                case 3:
                    double R = random.Next(1, 10);
                    return new Circle(R);
                default:
                    throw new InvalidOperationException("unknown type.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < 10; i++)
            {
                Shape shape = ShapeFactory.CreateShape();
                shapes.Add(shape);
                Console.WriteLine($"创建：{shape.GetType().Name},面积：{shape.CalculateArea()}");
            }
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }

            Console.WriteLine($"面积之和： {totalArea}");
        }
    }
}