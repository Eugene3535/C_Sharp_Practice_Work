using System;                                                                   // Task 1

namespace CurrentTask
{
    class Task
    {
        static int Main()
        {
            Console.WriteLine("Текущая время и дата: " + DateTime.Now);

            OperatingSystem os = Environment.OSVersion;
            Console.WriteLine("Платформа: " + os.Platform.ToString());

            Console.Write("Введите х: ");

            double x = double.Parse(Console.ReadLine());
            double y = Math.Sqrt(Math.Log(4.0 / 3.0 + x) + 9.0 / 7.0) - Math.Pow(Math.E, -Math.Sin(1.3 * x - 0.7));

            Console.WriteLine("y = {0:F4}", y);

            return 0;
        }
    }
}