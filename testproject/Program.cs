using System.Text;
{
    Console.WriteLine("Привет");
    Console.WriteLine("Введите день недели");
}
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
string dayOfWeek = Console.ReadLine();

if (dayOfWeek == "понедельник")
{
    Console.WriteLine("Начало рабочей недели");
}    
else if (dayOfWeek == "вторник")
{
    Console.WriteLine("Tuesday");
}
else if (dayOfWeek == "среда")
{
    Console.WriteLine("Wednesday");
}

Console.Write("Введите баланс");
string money = Console.ReadLine();
Console.Write("Введите уровень");
string level = Console.ReadLine();

if(Convert.ToInt32(money) >= 500 || Convert.ToInt32(level) >= 10)
{
    Console.WriteLine("Вы приняты!");
}
else
{
    Console.WriteLine("Тикай!");
}