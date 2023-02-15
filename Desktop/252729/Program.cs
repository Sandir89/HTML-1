/*
Задача 25: (branch task_1)
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);
	
    void ToDegree(int a, int b)
	{
	    int result = 1;
	    for (int i = 1; i <= b; i++)
	    {
	        result = result * a;
	    }
	    Console.WriteLine(result);
	}
	
	// Функция ввода
	int ReadInt(string message)
	{
	    Console.WriteLine(message);
	    return Convert.ToInt32(Console.ReadLine());
	}
	
/*
Задача 27: (branch task_2)
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
	
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);
	
	// Функция ввода
	int ReadInt(string message)
	{
	    Console.Write(message);
	    return Convert.ToInt32(Console.ReadLine());
	}
	

	// Функция подсчета цифр в числе
	int NumberLen(int a)
	{
	    int index = 0;
	    while (a > 0)
	    {
	        a /= 10;
	        index++;
	    }
	    return index;
	}
	

	// Функция вывода суммы цифр в числе
	void SumNumbers(int n, int len)
	{
	    int sum = 0;
	    for (int i = 1; i <= len; i++)
	    {
	        sum += n % 10;
	        n /= 10;
	    }
	    Console.WriteLine(sum);
	}
	
Задача 29: (branch task_3)
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
	*/
	

	int lenArray = ReadInt("Введите длинну массива: ");
	

	int[] randomArray = new int[lenArray];
	for (int i = 0; i < randomArray.Length; i++)
	{
	    randomArray[i] = new Random().Next(1,9);
	    Console.Write(randomArray[i] + " ");
	}
	

	

	// Функция ввода
	int ReadInt(string message)
	{
	    Console.Write(message);
	    return Convert.ToInt32(Console.ReadLine());
	}