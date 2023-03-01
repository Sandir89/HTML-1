	 /* Задача 64: Задайте значения N. 
     Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
	 N = 5. -> "5, 4, 3, 2, 1"
	 N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
	 
	Console.Write("Введите число: ");
	int number = Convert.ToInt32(Console.ReadLine());
	int count = 1;
	NaturalToLow(number, count);
	
	void NaturalToLow(int n, int count)
	{
	    if (count > n)
	    {
	        return;
	    }
	    else
	    {
	        NaturalToLow(n, count + 1);
	        Console.Write(count + " ");
	    }
	}

	 Задача 66: Задайте значения M и N. 
     Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
	 M = 1; N = 15 -> 120
	 M = 4; N = 8. -> 30

	 
	Console.Write("Введите число M: ");
	int m = Convert.ToInt32(Console.ReadLine());

	Console.Write("Введите число N: ");
	int n = Convert.ToInt32(Console.ReadLine());

	SumFromMToN(m, n);
	
	// вызов функции "сумма чисел от M до N"
	void SumFromMToN(int m, int n)
	{
	    Console.Write(SumMN(m - 1, n));
	}

	// функция сумма чисел от M до N
	int SumMN(int m, int n)
	{
	    int res = m;
	    if (m == n)
	        return 0;
	    else
	    {
	        m++;
	        res = m + SumMN(m, n);
	        return res;
	    }
	}
	
	 Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
     Даны два неотрицательных числа m и n.
	 m = 2, n = 3 -> A(m,n) = 9
	 m = 3, n = 2 -> A(m,n) = 29
	 */
	 
	Console.Write("Введите число M: ");
	int m = Convert.ToInt32(Console.ReadLine());

	Console.Write("Введите число N: ");
	int n = Convert.ToInt32(Console.ReadLine());

	AkkermanFunction(m,n);
	
	// вызов функции Аккермана
	void AkkermanFunction(int m, int n)
	{
	    Console.Write(Akkerman(m, n)); 
	}
	
	// функция Аккермана
	int Akkerman(int m, int n)
	{
	    if (m == 0)
	    {
	        return n + 1;
	    }
	    else if (n == 0 && m > 0)
	    {
	        return Akkerman(m - 1, 1);
	    }
	    else
	    {
	        return (Akkerman(m - 1, Akkerman(m, n - 1)));
	    }
	}