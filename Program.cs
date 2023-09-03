class Program
{
	static void Main()
	{
		int numzadan = Convert.ToInt32(Console.ReadLine());
		switch (numzadan)
		{
			case 1://Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
				{
					
					int raxmer = Convert.ToInt32(Console.ReadLine());
					int[] array = new int[raxmer];
					int nums = 0;
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = Convert.ToInt32(Console.ReadLine());
						if (array[i] > 0)
						{
							nums++;
						}
					}
					Console.WriteLine(nums);
				}
				break;
			case 2: //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
				{
					Console.WriteLine("Введите переменную b1: ");
					double b1 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Введите переменную b2: ");
					double b2 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Введите переменную k1: ");
					double k1 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Введите переменную k2: ");
					double k2 = Convert.ToInt32(Console.ReadLine());
					double x = -(b1-b2)/(k1-k2);
					double y = k1 * x + b1;
					Console.WriteLine($"Точка пересечения двух прямых: [{ x},{ y}]") ;
				}
				break;
		}

	}
}
