Console.Clear();









System.Console.WriteLine("введите координату X1:");
double X1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("введите координату Y1:");
double Y1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("введите координату Z1");
double Z1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("введите координату X2");
double X2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("введите координату Y2");
double Y2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("введите координату Z2");
double Z2 = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1));
System.Console.WriteLine(res);