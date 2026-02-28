while(true)
{
    Console.WriteLine("Введите номер задания");
    string names = Console.ReadLine();
    bool e = false;
    switch (names)
    {
        case "1":
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            break;
        case "2":
            Console.Write("Введите Число:");
    int name = Convert.ToInt32(Console.ReadLine());
while(name > 0)
            {
                Console.WriteLine(name);
                name--;
            }
            break;
        case "3":
            string name_ = "Hello, World!";
            foreach(char n in name_)
            {
                Console.WriteLine(n);
            }
            break;
        case "4":
        Console.Write($"| ");
        for(int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write($"{i * j}{new String(' ', (3 - Convert.ToString(i * j).Length))} | ");
                }
                Console.Write("\n| ");
            }
            break;
        default:
            e = true;
            break;
    }
    if (e)
        break;
    Console.WriteLine("\nПрограмма завершена, нажмите любую кнопку");
    ConsoleKeyInfo na = Console.ReadKey();
}
