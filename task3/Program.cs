// Найдите максимальное значение в матрице по каждой строке,
// получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) 
// вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[] CreateArray(int length)
{
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int SearchMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];

    }
    return max;
}
int[] CreateNewArr(int[] arr1, int[] arr2)
{
    int[] arr3 = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] < arr2[i])
        {
            arr3[i] = arr1[i];
        }
        else
        {
            arr3[i] = arr2[i];
        }
    }
    return arr3;
}

int SumMin(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];

    }
    return sum;
}

int[] array1 = CreateArray(5);
int[] array2 = CreateArray(5);
PrintArray(array1);
PrintArray(array2);
int[] array3 = CreateNewArr(array1, array2);
int max1 = SearchMax(array1);
int max2 = SearchMax(array2);

int answer=(max1+max2)-SumMin(array3);
System.Console.WriteLine($"Искомое значение {answer}");
