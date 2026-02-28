


string num;
List<string> Obj = new List<string>();
while(true)
{
    Console.WriteLine(
"Введите команду:\n" +
"1 — добавить товар\n" + 
"2 — вывести список товаров (с номерами)\n" +
"3 — удалить товар по номеру\n" +
"4 — проверить, есть ли товар в списке (по названию)\n"+
"5 — очистить список\n" +
"0 — выход");
num = Console.ReadLine();

switch(num)
    {
                case "1":
                Console.Write("Введите товар для добавления его в список: ");
                Obj.Add(Console.ReadLine());
        break;
                case "2":
                Console.WriteLine("Список товаров: ");
                for(int i = 0; i < Obj.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + Obj[i]);
            }
        break;
                case "3":
                Console.Write("Введите номер товара для удаления: ");
                num = Console.ReadLine();
                if(Convert.ToInt32(num) > Obj.Count || Convert.ToInt32(num) <= 0)
            {
                 Console.WriteLine("Неправильный номер");
                break;
            }
                Obj.RemoveAt(Convert.ToInt32(num) - 1);
                Console.WriteLine("Товар удален");
        break;
                case "4":
                Console.Write("Введите товар для его поиска: ");
                if(Obj.Contains(Console.ReadLine()))
            {
                Console.WriteLine("Ваш товар есть в списке");
            } else
            {
                Console.WriteLine("Вашего товара нету в списке");
            }
        break;
                case "5":
                Console.WriteLine("Список очищен");
                Obj.Clear();
        break;
                case "0":
                goto exit;
    }
        continue;
        exit:
        break;
}
