// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27    5 -> 1, 8, 27, 64, 125
// массив

int num = InputIntNumberTryParse(); //ввели данные
int [] cubesTable = GetTableOfCubes(num); // посчитали кубы
PrintArray (cubesTable); // вывели массив на печать

int InputIntNumberTryParse ()
{
    Console.WriteLine("Enter number, please.");
    bool isParsed = int.TryParse(Console.ReadLine(), out int Num);

    if (!isParsed)
    {
        Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
        return -1;
    }
    else
    {
        return Num;
    }
}

int [] GetTableOfCubes (int num)
{
    int [] arr = new int [num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (int)(Math.Pow(i+1, 3));
    }
    return arr;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}