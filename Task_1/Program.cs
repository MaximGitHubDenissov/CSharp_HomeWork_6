// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите числа через запятую");

int[] Num = Array.ConvertAll(Console.ReadLine()!.Split(','), int.Parse);
NumAboveZero (Num);

void NumAboveZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0) count++;
    }
    Console.WriteLine ($"Вы ввели {count} числа больше нуля");
}










