using System.Text;
{
    Console.WriteLine("Привет");
    Console.WriteLine("Введите день недели");
}
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
string dayOfWeek = Console.ReadLine();

switch (dayOfWeek)
{
    case "понедельник":
        Console.WriteLine("Monday");
        break;
    case "вторник":
        Console.WriteLine("Tuesday");
        break;
    case "среда":
        Console.WriteLine("Wednesday");
        break;
    case "четверг":
        Console.WriteLine("Thursday");
        break;
    case "пятница":
        Console.WriteLine("Friday");
        break;
    case "суббота":
        Console.WriteLine("Saturday");
        break;
    case "воскреенье":
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Не верный день недели!");
        break;
}

string password = "P4tmnCpm";
string userInput;
Console.Write("Введите пароль:");
userInput = Console.ReadLine();

if(userInput == password)
{
    Console.WriteLine("success");
}
else
{
    Console.WriteLine("incorrect password");
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


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}