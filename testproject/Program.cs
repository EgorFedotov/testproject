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



float money;
int years;
int percent;

Console.WriteLine("Введите деньги, внесенных на вклад");
money = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("На сколько лет открыть вклад ?");
years = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Под какой процнт");
percent = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < years; i++)
{
    money += money / 100 * percent;
    Console.WriteLine($"В этом году у вас {money}");
    Console.ReadKey();
}
