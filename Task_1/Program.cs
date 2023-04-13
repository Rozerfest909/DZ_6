// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadInt(string message)
{
    System.Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] ReadDigit(string message, int digit)
{
    int[] num = new int [digit];
    for(int i = 0; i < digit; i++)
    {
        System.Console.Write(message + $". {i+1}: ");
        num[i] = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int Count (int[] mas, int digit)
{
    int count = 0;
    for( int i = 0; i < digit; i++)
    {
        if(mas[i] > 0) 
        {
            count += 1;
        }
    }
    return count;
}

int qu = ReadInt("Введите количество значений массива: ");
int[] massive = ReadDigit("Введите элемент массива", qu);
PrintArray(massive);
Console.Write($"Количество числе больше нуля = {Count(massive, qu)}");