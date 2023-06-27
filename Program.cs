/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int PowerOfNumber(int num1, int num2)
{
    int count = 1;
    for (int i = 1; i <= num2; i++) count *= num1;
    return count;

}

int num1 = InputNum("Введите основание: ");
int num2 = InputNum("Введите степень: ");
int res = PowerOfNumber(num1, num2);
Console.WriteLine($"{num2} степень числа {num1} равена : {res}");
*/






/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Number(int num)
{
    int res = 0;
    while (num != 0)
    {
        res = res + num % 10;
        num /= 10;
    }
    return res;
}

int number = InputNum("Введите число: ");
int result = Number(number);
Console.WriteLine($"Сумма цифр числа: {result}");
*/



/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] ArrayRand(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

void PrintArray (int[] array)
{
   int size = array.Length;
Console.Write("[" + array[0] + ", ");
   for (int i = 1; i < size - 1; i++) 
        Console.Write(array[i] + ", ");
Console.Write(array[size - 1] + "] ");
}

int len = InputNum("Введите длину массива: ");
//int len = 8;
int[] arr = ArrayRand(len);
PrintArray(arr);


