using System;

namespace Main // Пространство имен
{
    class Program // Класс программы
    {
        static void Main(string[] args) // Метод Main - точка входа
        {
            Console.WriteLine("Hello, World!");
Console.WriteLine("Выберите функцию");
string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    WR1();
                    break;
                case "2":
                    WR2();
                    break;
                case "3":
                    WR3();
                    break;
                case "4":
                    WR4();
                    break;
                case "5":
                    WR5();
                    break;
                case "6":
                    WR6();
                    break;
                case "7":
                    WR7();
                    break;
                case "8":
                    WR8();
                    break;
                case "9":
                    WR9();
                    break;
                case "10":
                    WR10();
                    break;
                case "11":
                    WR11();
                    break;
                case "12":
                    WR12();
                    break;
                case "13":
                    WR13();
                    break;
                case "14":
                    WR14();
                    break;
                case "15":
                    WR15();
                    break;
                case "+1":
                    SM1();
                    break;
                case "+2":
                    SM2();
                    break;
                case "+3":
                    SM3();
                    break;
                case "+4":
                    SM4();
                    break;
                case "+5":
                    SM5();
                    break;
                case "+6":
                    SM6();
                    break;
            }



static void WR1()
{
    Console.WriteLine("Hello, World!");
}

static void WR2()
{
    Console.Write("Введите свое имя: ");
    var name = Console.ReadLine(); // вводим имя
    Console.WriteLine($"Привет {name}"); // выводим имя на консоль
    Console.WriteLine("Ваше имя" + name + ".");
}

static void WR3()
{
    string hello = "Привет мир";
    Console.WriteLine(hello);
    Console.WriteLine("Добро пожаловать в C#!");
    Console.WriteLine("Пока мир...");
    Console.WriteLine(24.5);
}

static void WR4()
{
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м");
}

static void WR5()
{
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}м", name, height, age);
}

static void WR6()
{
    string name = "Tom";
    int age = 34;
    double height = 1.7;
    Console.Write($"Имя: {name} Возраст: {age} Рост: {height}м");
}

static void WR7()
{
    Console.Write("Введите свое имя: ");
    string? name = Console.ReadLine();
    Console.WriteLine($"Привет {name}");
}

static void WR8()
{
    Console.Write("Введите имя: ");
    string? name = Console.ReadLine();
    Console.Write("Введите возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите рост: ");
    double height = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите размер зарплаты: ");
    decimal salary = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}м Зарплата: {salary}$");
}

static void WR9()
{
    int num1 = 8;
    int num2 = 6;
    if (num1 > num2)
    {
        Console.WriteLine($"Число {num1} больше числа {num2}");
    }
}

static void WR10()
{
    int num1 = 8;
    int num2 = 6;
    if (num1 > num2)
        Console.WriteLine($"Число {num1} больше числа {num2}");
    // или так
    if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");
}

static void WR11()
{
    int num1 = 8;
    int num2 = 6;
    if (num1 > num2 && num1 == 8) 
    {
        Console.WriteLine($"Число {num1} больше числа {num2}");
    }
}

static void WR12()
{
    int num1 = 8;
    int num2 = 6;
    if (num1 > num2)
    {
        Console.WriteLine($"Число {num1} больше числа {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} меньше или равно числу {num2}");
    }
}

static void WR13()
{
    int num1 = 8;
    int num2 = 6;
    if (num1 > num2)
        Console.WriteLine($"Число {num1} больше числа {num2}");
    else
        Console.WriteLine($"Число {num1} меньше или равно числу {num2}");
}

static void WR14()
{
    int num1 = 8;
    int num2 = 6;
    if (num1 > num2)
    {
        Console.WriteLine($"Число {num1} больше числа {num2}");
    }
    else if (num1 < num2)
    {
        Console.WriteLine($"Число {num1} меньше числа {num2}");
    }
    else
    {
        Console.WriteLine("Число num1 равно числу num2");
    }
}

static void WR15()
{
    string name = "Alex";
    if (name == "Tom")
        Console.WriteLine("Вас зовут Tomas");
    else if (name == "Bob")
        Console.WriteLine("Вас зовут Robert");
    else if (name == "Mike")
        Console.WriteLine("Вас зовут Michael");
    else
        Console.WriteLine("Неизвестное имя");
}

static void SM1()
{
    Console.Write("Ваше имя:");
    string name = Console.ReadLine();
    Console.Write($"Приветствую, тебя зовут {name}\nРад знакомству!");
}

static void SM2()
{
    Console.Write("Введите два числа:");
    string[] name = Console.ReadLine().Split(", ");
    int[] num = new int[2];
    for (int i = 0; i < 2; i++)
    {
        num[i] = Convert.ToInt32(name[i]);
    }
    Console.Write($"Сумма: {num[0]} + {num[1]} = {num[0] + num[1]}; Разность: {num[0]} - {num[1]} = {num[0] - num[1]}; Произведение: {num[0]} * {num[1]} = {num[0] * num[1]}.");
}

static void SM3()
{
    Console.Write("Ваш возвраст:");
    int name = Convert.ToInt32(Console.ReadLine());
    if (name < 18)
        Console.Write("Несовершеннолетний");
    else
        Console.Write("Совершеннолетний");
}

static void SM4()
{
    while (true)
    {
        bool a = false;
        Console.Write("Введите два числа:");
        try
        {
            string[] name = Console.ReadLine().Split(" ");
            int[] num = new int[2];
            for (int i = 0; i < 2; i++)
            {
                num[i] = Convert.ToInt32(name[i * 2]);
            }
            switch (name[1])
            {
                case "+":
                    Console.Write($"{num[0]} + {num[1]} = {num[0] + num[1]}");
                    break;
                case "-":
                    Console.Write($"{num[0]} - {num[1]} = {num[0] - num[1]}");
                    break;
                case "/":
                    Console.Write($"{num[0]} / {num[1]} = {num[0] / num[1]}");
                    break;
                case "*":
                    Console.Write($"{num[0]} * {num[1]} = {num[0] * num[1]}");
                    break;
            }
            if (name[1] == "/" && num[1] == 0)
                a = true;
        }
        catch
        {
            Console.WriteLine("Ошибка");
            a = true;
        }
        if (a)
            continue;
        break;
    }
}

static void SM5()
{
    while (true)
    {
        Console.Write("Введите ваше имя");
        string name = Console.ReadLine();
        Console.Write("Введите ваше имя");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите ваше имя");
        double height = Convert.ToDouble(Console.ReadLine());
        if (age <= 0 || height <= 0)
        {
            Console.Write("Ошибка Возроста или Роста");
            continue;
        }
        Console.Write($"Имя: {name} Возраст: {age} Рост: {height}м");
        break;
    }
}
static void SM6()
            {
                while (true)
                {
                    Console.Write("Ваш балл:");
                    int name = Convert.ToInt32(Console.ReadLine());
                    if (name < 1 || name > 10)
                        continue;
                    if (name < 4)
                        Console.Write("Неудовлетворительно");
                    else if (name < 6)
                        Console.Write("Удовлетворительно");
                    else if (name < 6)
                        Console.Write("Хорошо");
                    else
                        Console.Write("Отлично");
                    break;
                }
            }

        }
    }
}
