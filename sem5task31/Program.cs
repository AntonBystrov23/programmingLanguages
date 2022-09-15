// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
int GetData(string line)
{
    Console.Write(line);
    int count = int.Parse(Console.ReadLine() ?? "0");
    return count;
}

int[] FillArray(int count, int downBorder, int topBorder)
{
    int[] numbers = new int[count];
    Random random = new Random();
    if (downBorder < topBorder)
    {
        for (byte i = 0; i < numbers.Length; i++)
            numbers[i] = random.Next(downBorder, topBorder + 1);
    }
    return numbers;
}

int[] SumNegativPositiv(int[] array)
{
    int[] sums = new int[2];
    for (byte i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sums[0] = sums[0] + array[i];
        else
            sums[1] = sums[1] + array[i];
    }
    return sums;
}

void Print1DArray(int[] nums, string line)
{
    Console.Write(line);
    for (byte i = 0; i < nums.Length - 1; i++)
    {
        Console.Write(nums[i] + ", ");
    }
    Console.WriteLine(nums[nums.Length - 1] + "!");
}
int topBorder = GetData("Введите верхний диапазон: ");
int downBorder = GetData("Введите нижний диапазон: ");
int[] arrayNumbers = FillArray(GetData("Введите длинну массива: "), downBorder, topBorder);
Print1DArray(arrayNumbers, "Массив: ");
Print1DArray(SumNegativPositiv(arrayNumbers), "Сумма отрицательных чисел и сумма положительных чисел равна ");

