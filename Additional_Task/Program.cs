// Доп.Задача (Если вдруг не можете решить 43, либо хотите решить для интереса)

// Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.


Console.WriteLine("Введите число от 50 до 100");
int N = int.Parse(Console.ReadLine()!);
int[] array = GetArray(10, 50, 100);
Console.WriteLine(String.Join("  ", array));
NumMulti(N, array);
void NumMulti(int num, int[] arr)
{
    int result = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < num) result = result * arr[i];
               
    }
    if (result ==1) Console.WriteLine ("В массиве нет чисел меньше введенного числа");
    else Console.WriteLine($"Произведение чисел меньше {num} равно {result}");
};

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}