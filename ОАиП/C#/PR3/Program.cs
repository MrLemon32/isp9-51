using System.Reflection.Metadata;

Console.WriteLine("Введите имя: ");
string name = Console.ReadLine();
Console.WriteLine("Введите ваш счет: ");
double money = Convert.ToDouble(Console.ReadLine());

BankAccount bk = new BankAccount(name, money);
while (true)
{
    Console.WriteLine("Введите номер действия:\n" +
    "1 — пополнить счёт\n" +
    "2 — снять деньги;\n" +
    "3 — вывести информацию о счёте\n" +
    "0 — выход из программы\n");

    bool e = false;
    switch (Console.ReadLine())
    {
        case "0":
            e = true;
            break;
        case "1":
        Console.WriteLine("Введите значение: ");
            bk.Deposit(Convert.ToDouble(Console.ReadLine()));
            break;
        case "2":
        Console.WriteLine("Введите значение: ");
            bk.Withdraw(Convert.ToDouble(Console.ReadLine()));
            break;
        case "3":
            bk.Print();
            break;
    }
    if (e)
        break;
}
class BankAccount
{
    public string owner = "Bob";
    public double balance;

    public BankAccount(string owner, double balance)
    {
        this.balance = balance;
        this.owner = owner;
    }

    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Введена отрицательная сумма");
        }
        else
        {
            balance += amount;
            Console.Write("Теперь ");
            Print();
        }
    }


    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Введена сумма, превышающая ваш баланс");
        }
        else
        {
            balance -= amount;
            Console.Write("Теперь ");
            Print();
        }
    }


    public void Print()
    {
        Console.WriteLine($"{owner}, ваш счет равен {balance} кредитам");
    }
}
