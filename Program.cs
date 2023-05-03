// My final CS GeekBrains Work

Console.Write("Введите количество строк массива:");

try
{
    int maxArray = int.Parse(Console.ReadLine());
}
catch(Exception)
{
    Console.WriteLine("Введенные данные не является целым числом.");
}

static string[] CreateArray(int maxLines = 20)
{
    string[] array = new string[maxLines];
    return array;
}