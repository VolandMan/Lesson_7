using System;

namespace CalcSquare
{
    class Program
    {
        class Circle
        {
            public string name = "Circle";
            private string[] SetColor = { "Черный", "Зеленый", "Синий", "Красный"};
            private string color;
            private double square;
            private double perimeter;

            public void GetInfo()  // вывод инфы
            {
                Console.WriteLine("\nЦвет: " + color);
                Console.WriteLine("Периметр: " + perimeter);
                Console.WriteLine("Площадь: " + square);
            }

            public void SetParameters(int radius)
            {
                    Random rnd = new Random();

                    color = SetColor[rnd.Next(SetColor.Length - 1)];
                    perimeter = Math.Round((radius * 2 * Math.PI), 2);
                    square = Math.Round((Math.Pow(radius, 2) * Math.PI), 2);
                    GetInfo();
            }
        }
        class Square
        {
            public string name = "Square";
            private string[] SetColor = { "Черный", "Зеленый", "Синий", "Красный" };
            private string color;
            private double perimeter;
            private double square;

            public void GetInfo() // вывод инфы
            {
                Console.WriteLine("\nЦвет: " + color);
                Console.WriteLine("Периметр: " + perimeter);
                Console.WriteLine("Площадь: " + square);
            }
            public void setParameters(int side)
            {
                    Random rnd = new Random();

                    color = SetColor[rnd.Next(SetColor.Length - 1)];
                    perimeter = Math.Round(Convert.ToDouble(side * 4), 2);
                    square = Math.Round(Convert.ToDouble(Math.Pow(side, 2)), 2);
                    GetInfo();
            }
        }
        class Triangle
        {
            public string name = "Triangle";
            private string[] SetColor = { "Черный", "Зеленый", "Синий", "Красный" };
            private string color;
            private double perimeter;
            private double square;

            public void GetInfo()  // вывод инфы
            {
                Console.WriteLine("\nЦвет: " + color);
                Console.WriteLine("Периметр: " + perimeter);
                Console.WriteLine("Площадь: " + square);
            }
            public void setParameters(int side1, int side2, int side3)
            {
                    Random rnd = new Random();

                    color = SetColor[rnd.Next(SetColor.Length - 1)];
                    perimeter = Math.Round(Convert.ToDouble(side1 + side2 + side3), 2);
                    square = Math.Round(Convert.ToDouble(Math.Sqrt(perimeter / 2 * (perimeter / 2 - side1) * (perimeter / 2 - side2) * (perimeter / 2 - side3))), 2);
                    GetInfo();
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
           
            int button;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("********Выбрать фигуру*********");
                Console.WriteLine("1 - Круг ");
                Console.WriteLine("2 - Квадрат ");
                Console.WriteLine("3 - Треугольник ");
                Console.WriteLine("0 - Выход ");
                Console.WriteLine("*******************************");
                Console.Write("Выбор: ");
                button = Convert.ToInt32(Console.ReadLine());

                 switch (button)
                {
                     //КРУГ
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Circle circle = new Circle();
                        Console.WriteLine("Вы выбрали Круг"+ "\nВведите радиус и нажмите Ввод:");
                        circle.SetParameters(Convert.ToInt32(Console.ReadLine().ToString().Trim()));
                        break;
                    //КВАДРАТ
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Square square = new Square();
                        Console.WriteLine("Вы выбрвли Квадрат"+ "\nВведите длинну стороны и нажмите Ввод:");
                        square.setParameters(Convert.ToInt32(Console.ReadLine().ToString().Trim()));
                        break;
                    //ТРЕУГОЛЬНИК
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Triangle triangle = new Triangle();
                        Console.WriteLine("Вы выбрали Треугольник"+"\n Введите, длинну трех сторон через пробел и нажмите Ввод");
                       
                            String[] arr = Console.ReadLine().ToString().TrimStart().TrimEnd().Split(' '); // парисим введенные цифры по пробелу
                            triangle.setParameters(Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2]));
                        break;
                    case 0:
                    Environment.Exit(0);
                     break;
                                     
                }
            } while (button != 0);
             Console.ReadKey();
        }
    }
}
    

