Console.WriteLine(" Введите размер массива ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.WriteLine(" Введите нижний предел массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите верхний предел массива ");
int max = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Random rnd = new Random();
int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}
int SumofUnevenNum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}
FillArray(array);
Console.WriteLine(string.Join(",", array));
int result = SumofUnevenNum(array);
Console.WriteLine($"Сумма элементов с нечётным индексом равна {sum}");