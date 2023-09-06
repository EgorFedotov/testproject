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
string userInputt;
Console.Write("Введите пароль:");
userInputt = Console.ReadLine();

if (userInputt == password)
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


int playHealth = 100;
int enemyHealth = 100;
Random randPlayer = new Random();
int playerDamage;

Random randEnemy = new Random();
int enemyDamage;

while (playHealth > 0 && enemyHealth > 0)
{
    playerDamage = randPlayer.Next(0, 15);
    enemyDamage = randEnemy.Next(0, 15);
    playHealth -= enemyDamage;
    enemyHealth -= playerDamage;

    Console.WriteLine($"{playHealth} Игрок");
    Console.WriteLine($"{enemyHealth} Враг");
}

if (playHealth <= 0 && enemyHealth <= 0)
{
    Console.WriteLine("Ничья!");
}
else if (enemyHealth <= 0) { Console.WriteLine("Победа игрокка"); }
else if (playHealth <= 0) { Console.WriteLine("Победа врага"); }


int number;
int lower, higher;
int triesCount = 5;
int userInput;
Random rand = new Random();

number = rand.Next(1, 101);
lower = rand.Next(number - 10, number);
higher = rand.Next(number + 1, number + 10);

Console.WriteLine($"Чисто от 10 до 100, оно больше чем {lower}, но меньше чем {higher}");
Console.WriteLine($"Что это за число ? у вас {triesCount} попыток");

while (triesCount-- > 0)
{
    Console.Write("Вам отвт:");
    userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput == number)
    {
        Console.WriteLine($"Угадал это число: {number}");
        break;
    }
    else
    {
        Console.WriteLine("Не угодал, попробуйте еще раз");
    }
}

if (triesCount < 0)
{
    Console.WriteLine($"Вы проиграли, число было {number}");
}

Random random = new Random();
float health1 = random.Next(90, 100);
int damage1 = random.Next(5, 20);
int armor1 = random.Next(25, 65);

float health2 = random.Next(80, 150);
int armor2 = random.Next(20, 40);
int damage2 = random.Next(65, 100);

Console.WriteLine($"Гладиатор 1 - {health1} здоровье, {damage1} урон, {armor1} броня");
Console.WriteLine($"Гладиатор 2 - {health2} здоровье, {damage2} урон, {armor2} броня");

while (health1 > 0 && health2 > 0)
{
    health1 -= Convert.ToSingle(random.Next(0, damage2 + 1)) / 100 * armor1;
    health2 -= Convert.ToSingle(random.Next(0, damage1 + 1)) / 100 * armor2;

    Console.WriteLine("Здоровье гладиатора 1 :" + health1);
    Console.WriteLine("Здоровье гладиатора 2 :" + health2);

}