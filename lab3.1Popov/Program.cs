try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    double Q = 1;

    for (int k = 1; k <= n; k++)
    {
        double fact = 1;
        for (int i = 1; i <= 2*(n - k); i++)
        {
            fact *= i;
        }

         Q = Math.Pow(-1, k) * (k - 7) /  fact;

      
    }

    Console.WriteLine($"Q={Q:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
