int[] TotalArray(int col)
{
    int[] array = new int[col];
    int i = 0;
    while (i < array.Length)
    {
        Random rand = new Random();
        array[i] = rand.Next(1, 100);
        Console.WriteLine(Convert.ToString(array[i]) + ", ");
        i++;
    }
    return array;
}


Console.WriteLine("Введите длинну массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = TotalArray(m);
int i = 0;
while (i < array.Length)
{

    if (i != array.Length - 1)
    {
        Console.Write(Convert.ToString(array[i]) + ", ");
    }
    else
    {
        Console.Write(array[i]);
    }
    i++;
}
