Console.WriteLine(" Введите размер массива ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
Random rnd = new Random();
double maxim = 0;
double minim = 0;
double[] FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble(),5);
    }
    return arr;
}

double FindMax (double[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]>arr[i+1])
                {
                    maxim = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1]=maxim;
                    
                }
                else
                {
                     maxim = arr[i+1]; 
                }
            }
        Console.WriteLine($"Максимальный элемент равен {maxim}");
        return maxim;
        }

double FindMin (double[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]<arr[i+1])
                {
                    minim = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1]=minim;
                }
                else
                {
                     minim = arr[i+1]; 
                }
            }
        Console.WriteLine($"Минимальный элемент равен {minim}");
        return minim;
        }
    
FillArray(array);
Console.WriteLine(string.Join(",  ",array ));

double result = FindMax(array) - FindMin(array);
Console.WriteLine($" Разница между макс и мин элементами равна {result}");


