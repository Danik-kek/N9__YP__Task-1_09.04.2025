namespace N9__YP__Task_1_09._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество чисел (n): ");
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];
            Console.WriteLine("Введите числа:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            File.WriteAllLines("numbers.txt", Array.ConvertAll(numbers, x => x.ToString()));
            Console.WriteLine("Числа успешно записаны в файл numbers.txt.");
        }
    }
}
