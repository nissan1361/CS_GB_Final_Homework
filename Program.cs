// My final CS GeekBrains Work

Console.Write("Введите количество строк массива:");

int maxArray = 0;
try
{
    maxArray = int.Parse(Console.ReadLine());
}
catch(Exception)
{
    Console.WriteLine("Введенные данные не является целым числом.");
}

string[] programmArray = CreateArray(maxArray);

string[] newArray = ChangeArray(programmArray, maxArray);
PrintArray(newArray);

static string[] CreateArray(int maxLines)
{
    string[] array = new string[maxLines];
    for (int i = 0; i < maxLines; i++)
    {
        Console.WriteLine("Введите строку " + (i+1) + ": ");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("");
    return array;
}

static void PrintArray(string[] arr)
{
    Console.WriteLine("Новый массив: ");
    Console.WriteLine("");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

static string[] ChangeArray(string[] arr, int maxA, int maxWord = 3)
{
    string[] cArr = new string[maxA];
    int cArrIndex = 0;
    for (int i = 0; i < maxA; i++)
    {
        if (arr[i].Length <= 3)
        {
            cArr[cArrIndex++] = arr[i];
        }
    }
    Array.Resize(ref cArr, cArrIndex);
    return cArr;
}