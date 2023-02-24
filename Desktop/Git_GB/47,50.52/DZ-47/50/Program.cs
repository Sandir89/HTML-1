	/*
	Задача 47. 
	Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
	m = 3, n = 4.
	0,5 7 -2 -0,2
	1 -3,3 8 -9,9
	8 7,8 -7,1 9
		
	int rows = ReadInt("Введите количество строк: ");
	int colums = ReadInt("Введите количество столбцов: ");
	double[,] numbers = new double[rows, colums];
	FillArray2D(numbers);
	PrintArray2D(numbers);
	
		void FillArray2D(double[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            array[i, j] = new Random().Next(-99, 99) / 10.0;
	        }
	    }
	}
	
	void PrintArray2D(double[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write(array[i, j] + " ");
	        }
	        Console.WriteLine();
	    }
	    Console.WriteLine();
	}
	
	int ReadInt(string message)
	{
	    Console.Write(message);
	    return Convert.ToInt32(Console.ReadLine());
	}
	
	 Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
	 значение этого элемента или же указание, что такого элемента нет.
	 Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
	 Например, задан массив:
	 1 4 7 2
	 5 9 2 3
	 8 4 2 4
	
	 17 -> такого числа в массиве нет

	int rows = ReadInt("Введите индекс строки: ");
	int colums = ReadInt("Введите индекс столбца: ");
	int[,] numbers = new int[6, 8];
	FillArray2D(numbers);
	PrintArray2D(numbers);
	
	if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
	else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

	// Заполнение массива рандомными числами от 1 до 9
	void FillArray2D(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            array[i, j] = new Random().Next(1, 10);
	        }
	    }
	}
	

	//  Функция вывода массива в терминал
	void PrintArray2D(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write(array[i, j] + " ");
	        }
	        Console.WriteLine();
	    }
	    Console.WriteLine();
	}
	

	// Функция ввода 
	int ReadInt(string message)
	{
	    Console.Write(message);
	    return Convert.ToInt32(Console.ReadLine());
	}
	

	*/

	//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
	//Например, задан массив:
	//1 4 7 2
	//5 9 2 3
	//8 4 2 4
	//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

	// int rows = ReadInt("Введите номер строки: ");
	// int colums = ReadInt("Введите номер столбца: ");
	
	int rows = 3;
	int colums = 4;
	int[,] numbers = new int[rows, colums];
	FillArray2D(numbers);
	PrintArray2D(numbers);
	

	double[] avgNumbers = new double[numbers.GetLength(1)];
	

	for (int i = 0; i < numbers.GetLength(1); i++)
	{
	    double result = 0.0;
	    for (int j = 0; j < numbers.GetLength(0); j++)
	    {
	        result += numbers[j, i];
	    }
	    avgNumbers[i] = result / numbers.GetLength(0);
	}
	PrintArray(avgNumbers);

	// Заполнение массива рандомными вещественными числами
	void FillArray2D(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            array[i, j] = new Random().Next(1, 10);
	        }
	    }
	}
	
	//  Функция вывода двумерного массива в терминал
	void PrintArray2D(int[,] array)
	{
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
	        for (int j = 0; j < array.GetLength(1); j++)
	        {
	            Console.Write(array[i, j] + " ");
	        }
	        Console.WriteLine();
	    }
	    Console.WriteLine();
	}

	// Функция вывода массива в терминал 
	void PrintArray(double[] array)
	{
	    for (int i = 0; i < array.Length; i++)
	    {
	        Console.Write(array[i] + " ");
	    }
	    Console.WriteLine();
	}

	// Функция ввода 
	int ReadInt(string message)
	{
	    Console.Write(message);
	    return Convert.ToInt32(Console.ReadLine());
	}