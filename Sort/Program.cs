IndexOfTheFirstOccurance();

 void SumEvenNumbers()
{
    int sum = 0;
    for (int i = 7; i <= 21; i++ )
    {
        if (i % 2 == 0)
        {
            sum += i; 
        }
    }
    Console.WriteLine(sum);
}

 void SumEvenNumbersInMass()
{
    int sum = 0;
    Random random = new Random();
    int n = random.Next();
    int[] mas = new int[n];

    for (int i = 0; i<n; i++)
    {
        mas[i] = random.Next();
        if (mas[i] % 2 == 0)
        {
            sum += mas[i];
        }
    }
    Console.WriteLine(sum);
}

 void IndexOfTheFirstOccurance()
{
    Random random = new Random();
    int n = random.Next(5,10);
    int[] mas = new int[n];
    int count = Convert.ToInt32(Console.ReadLine());
    for (int i = 0;i<n;i++)
    {
        mas[i] = random.Next(0, 10);
        Console.Write(mas[i] + " ");
    }
    for (int i = 0; i < n; i++)
    {
        if (count == mas[i])
        {
            Console.WriteLine("\n" + i); //первое вхождение
            break;
        }
        if (i == n - 1)
        {
            Console.WriteLine("\n-1");
        }
    }
}
