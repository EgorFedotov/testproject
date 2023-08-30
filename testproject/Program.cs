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