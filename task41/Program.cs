﻿/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Console.Clear();
Console.WriteLine("Введите три числа через пробел: ");
string input = Console.ReadLine()!;
int[] Array = GetArrayFromString(input);
int countNum = CountPositiv(Array);
int[] GetArrayFromString(string stringArray)
{
    
}
Console.WriteLine($"Сумма чётных чисел в массиве = {sum}");