namespace практическая_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление, 5 - возведение в степень, 6 - нахождение корня, 7 - нахождение 1% от числа, 8 - нахождение факториала, 9 - выход из программы");
                int operation_num;
                Console.WriteLine("Введите номер операции");
                operation_num = Convert.ToInt32(Console.ReadLine());
                int a, b, res;
                if (operation_num == 1)
                {
                    Console.WriteLine("Введите первое число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    res = a + b;
                    Console.WriteLine("Ответ: " + res);
                }
                else if (operation_num == 2)
                {
                    Console.WriteLine("Введите первое число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    res = a - b;
                    Console.WriteLine("Ответ: " + res);
                }
                else if (operation_num == 3)
                {
                    Console.WriteLine("Введите первое число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    res = a * b;
                    Console.WriteLine("Ответ: " + res);
                }
                else if (operation_num == 4)
                {
                    Console.WriteLine("Введите первое число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    res = a / b;
                    Console.WriteLine("Ответ: " + res);
                }
                else if (operation_num == 5)
                {
                    Console.WriteLine("Введите число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите степень: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    int num = 1;
                    for (int i = 1; i <= b; i++)
                    {
                        num *= a;
                    }
                    Console.WriteLine("Ответ: " + num);

                }
                else if (operation_num == 6)
                {
                    Console.WriteLine("Введите число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ответ: " + Math.Sqrt(a));
                }
                else if (operation_num == 7)
                {
                    float c;
                    Console.WriteLine("Введите число: ");
                    c = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Ответ: " + c / 100);
                }
                else if (operation_num == 8)
                {
                    Console.WriteLine("Введите число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    int n = 1;
                    for (int i = 1; i <= a; i++)
                    {
                        n = n * i;
                    }
                    Console.WriteLine("Ответ: " + n);
                }
                if (operation_num == 9)
                {
                    break;
                }
            }
            while (true);

        }
    }
}