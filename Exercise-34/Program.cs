Console.WriteLine(" Введите размер массива ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int count = 0;
Random rnd = new Random();
int[] FillArray(int[] arr)
        {
             for(int i = 0; i<arr.Length;i++)
             {
                arr[i] = rnd.Next(100,1000);
             }   
             return arr;
        }  
int NumberofEvenNum(int[] arr)
    {
        for (int i = 0; i<arr.Length;i++)
        {
            if (arr[i]%2==0)
            {
                count++;
            }
        }
        return count;
    }
FillArray(array);
Console.WriteLine(string.Join(",",array));
int result = NumberofEvenNum(array);
Console.WriteLine($"Количество чётных элементов равно {result} ");
