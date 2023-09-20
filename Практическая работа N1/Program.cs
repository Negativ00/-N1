int a, b, c, d;
string text1, text2, text3;

Console.WriteLine("Введите номер операции:");
Console.WriteLine("1. Сложить числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");
text3 = Console.ReadLine();

if (int.TryParse(text3, out c))
{
    c = Convert.ToInt32(text3);
    while (c != 9)
    {
        if (c == 1)
        {
            Console.WriteLine("Введите первое число");
            text1 = Console.ReadLine();
            if (int.TryParse(text1, out a))
            {
                a = Convert.ToInt32(text1);
                Console.WriteLine("Введите второе число");
                text2 = Console.ReadLine();
                if (int.TryParse(text2, out b))
                {
                    b = Convert.ToInt32(text2);
                    d = a + b;
                    Console.WriteLine("Результат:" + d);
                    Console.WriteLine("Введите новую операцию");
                }
            }
        }
        else if (c == 2)
        {
            Console.WriteLine("Введите первое число");
            text1 = Console.ReadLine();
            if (int.TryParse(text1, out a))
            {
                a = Convert.ToInt32(text1);
                Console.WriteLine("Введите второе число");
                text2 = Console.ReadLine();
                if (int.TryParse(text2, out b))
                {
                    b = Convert.ToInt32(text2);
                    d = b - a;
                    Console.WriteLine("Результат:" + d);
                    Console.WriteLine("Введите новую операцию");
                }
            }
        }
        else if (c == 3)
        {
            Console.WriteLine("Введите первое число");
            text1 = Console.ReadLine();
            if (int.TryParse(text1, out a))
            {
                a = Convert.ToInt32(text1);
                Console.WriteLine("Введите второе число");
                text2 = Console.ReadLine();
                if (int.TryParse(text2, out b))
                {
                    b = Convert.ToInt32(text2);
                    d = a * b;
                    Console.WriteLine("Результат:" + d);
                    Console.WriteLine("Введите новую операцию");
                }
            }
        }
        else if (c==4)
        {
            Console.WriteLine("Введите первое число");
            text1 = Console.ReadLine();
            if (int.TryParse(text1, out a))
            {
                a = Convert.ToInt32(text1);
                Console.WriteLine("Введите второе число");
                text2 = Console.ReadLine();
                if (int.TryParse(text2, out b))
                {
                    b = Convert.ToInt32(text2);
                    d = a / b;
                    Console.WriteLine("Результат:" + d);
                    Console.WriteLine("Введите новую операцию");
                }
            }
        }
        else if (c==5)
        {
            Console.WriteLine("Введите первое число");
            text1 = Console.ReadLine();
            if (int.TryParse(text1, out a))
            {
                a = Convert.ToInt32(text1);
                Console.WriteLine("Введите второе число");
                text2 = Console.ReadLine();
                if (int.TryParse(text2, out b))
                {
                    b = Convert.ToInt32(text2);
                    double f = Math.Pow(a,b);
                    Console.WriteLine("Результат:" + f);
                    Console.WriteLine("Введите новую операцию");
                }
            }
        }
        else if (c==6)
        {
            Console.WriteLine("Введите число");
            text1 = Console.ReadLine();
            if (int.TryParse(text1, out a))
            {
                a = Convert.ToInt32(text1);
                double f = Math.Sqrt(a);
                Console.WriteLine("Результат:" + f);
                Console.WriteLine("Введите новую операцию");
            }
        }
        else if (c==7)
        {
            Console.WriteLine("Введите число");
            text1 = Console.ReadLine();
            if (int.TryParse(text1, out a))
            {
                a = Convert.ToInt32(text1);
                double f = a / 100.0;
                Console.WriteLine("Результат:" + f);
                Console.WriteLine("Введите новую операцию");
            }
        }
        else if (c == 8)
        {
            Console.WriteLine("Введите число");
            text1 = Console.ReadLine();
            if (int.TryParse(text1, out a))
            {
                double g, n;
                g = 1;
                n = Convert.ToDouble(text1);
                for (int i = 1; i<=n; i++)
                {
                    g = g * i;
                }
                Console.WriteLine("Результат:" + g);
                Console.WriteLine("Введите новую операцию");
            }
        }
        else 
        {
            Console.WriteLine("Это уже не смешно");
        }
        text3 = Console.ReadLine();
        if (int.TryParse(text3, out c))
        {
            c = Convert.ToInt32(text3);
        }
        else
        {
            Console.WriteLine("И это тоже не число, а чухня какая-то");
        }
    }
}
else
{
    Console.WriteLine("Это не число");
}