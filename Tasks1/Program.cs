using System;
using System.Data.SqlClient;
using System.Linq;

namespace Learn
{
	public static class Program
	{
	
        


			
		static double Lenth(double x1, double y1, double x2, double y2)

		{
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));



		}

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }


        public static void Main()

		{
			string name;
			string lastName;
			int age;
			int growth;
			int weight;

			Console.Title ="Задача 1: Анкетные данные";

			Console.Write("введите имя: ");
			name = Console.ReadLine();
			Console.Write("введите фамилию: ");
			lastName = Console.ReadLine();
			Console.Write("введите возраст(числовое значение): ");
			age = Convert.ToInt32(Console.ReadLine());
			Console.Write("введите рост(числовое значение): ");
			growth = Convert.ToInt32(Console.ReadLine());
			Console.Write("введите вес(числовое значение): ");
			weight = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Имя: " + name+ ", фамилия: " + lastName + ", возраст: "+age + ", рост: "+ growth+ ", вес: " + weight+ ".");
			Console.WriteLine("Имя: {0}, фамилия: {1}, возраст: {2}, рост: {3}, вес: {4}.", name, lastName, age,growth,weight);
			Console.WriteLine($"Имя: {name}, фамилия: {lastName}, возраст: {age}, рост: {growth}, вес: {weight}.");
			Console.Write("для продолжения нажмите клавищу ENTER;");
			Console.ReadLine();


            


            Console.Title = "Задача 2: Вычисление индекса массы тела";
			Console.Clear();
			
			double m;
			double h;
			
		    Console.Write("Введите вес в киллограммах: ");
			m = Convert.ToDouble(Console.ReadLine());
			Console.Write("введите рост в метрах: ");
			h = Convert.ToDouble(Console.ReadLine());
			double i = m/(h*h);

			Console.WriteLine("индекс массы тела равен: {0:F2}",i);
			Console.Write("для продолжения нажмите клавишу ENTER");
			Console.ReadLine();


            Console.Title = "Задача 5: Вычисление расстояния между двумя точками";
			Console.Clear();
			
			Console.Write("введите x1: ");
			double x1 = Double.Parse(Console.ReadLine());
			Console.Write("введите y1: ");
			double y1 = Double.Parse(Console.ReadLine());
			Console.Write("введите x2 : ");
			double x2 = Double.Parse(Console.ReadLine());
			Console.Write("введите y2 : ");
			double y2 = Double.Parse(Console.ReadLine());
			

			Console.WriteLine( "Расстояние между точками (x1,y1) и (x2,y2)  равна : {0:F2}", Lenth(x1,y1,x2,y2));
			Console.ReadLine();
			Console.Write("для продолжения нажмите клавишу ENTER");
			Console.ReadLine();

			Console.Title = "Задача 5: Вывод сведений на экран";
			Console.Clear();




            Print("Меня зовут Станислав Строков. Я живу в городе Таллине", 30, 15);
            Print("И снова здравствуйте, я Станислав :)))", ConsoleColor.Green);
            Console.ReadLine();





        }
	}
}
