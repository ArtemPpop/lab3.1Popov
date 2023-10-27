try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    double Q = 1;

    for (int k = 1; k <= n; k++)
    {
        if (Q == Math.Pow(-1, k) * (k - 7) / (2 * (n - k)));
        
    }

    Console.WriteLine($"Q={Q:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
