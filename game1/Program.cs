// игра -  интерактивный терминал

System.Console.WriteLine("Здравствуй, Друг! Предлагаю тебе сыграть в игру");
System.Console.WriteLine("Введи имя игрока: ");
string username = Console.ReadLine();
System.Console.WriteLine($"Добро пожаловать, {username}! Начнинаем. ");

System.Console.WriteLine("Level 1");
System.Console.WriteLine("Сложи 35 и 14");

int aa = 35;
int bb = 14;
int result = aa + bb;
int answer1 = Convert.ToInt32(Console.ReadLine());
if (result == answer1)
{
    System.Console.WriteLine("Решено верно, идем дальше ");
}
else
{
    System.Console.WriteLine("ОШИБКА!");
    System.Console.WriteLine("начинай все сначала. введи команду: dotnet run или стрелку вверх");
    return;
}
System.Console.WriteLine();
System.Console.WriteLine("Level 2");
System.Console.WriteLine("Сможешь умножить в уме 18 на 23?");
int answer2 = Convert.ToInt32(Console.ReadLine());
if (answer2 == 414)    
{
    System.Console.WriteLine("Решено верно, идем дальше ");
}
else
{
    System.Console.WriteLine("ОШИБКА!");
    System.Console.WriteLine("начинай все сначала. введи команду: dotnet run или стрелку вверх");
    return; 
}

System.Console.WriteLine();
System.Console.WriteLine("Level 3");
System.Console.WriteLine("Справишься с дробными числами?");
System.Console.WriteLine("Сколько получится если вычесть из 32.34 число 18.26?");
System.Console.WriteLine();
System.Console.WriteLine("1. = 10.24");
System.Console.WriteLine("2. = 14.08");
System.Console.WriteLine("3. = 12.36");
System.Console.WriteLine();
int result1 = 2;
int answer3 = Convert.ToInt32(Console.ReadLine());

if (answer3 == result1)
{
     System.Console.WriteLine("Точно");
}

else
{
    System.Console.WriteLine("НЕТ, ошибся! Правильный ответ 14.08");
    System.Console.WriteLine("начинай все сначала. введи команду: dotnet run или стрелку вверх");
    return;
}


System.Console.WriteLine();
System.Console.WriteLine("Теперь и мне захотелось поиграть! Загадай мне 2 числа, а я их сравню");
System.Console.WriteLine();
System.Console.WriteLine("Введи первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


if (firstNumber < secondNumber)
    Console.WriteLine ($"Первое число {firstNumber} меньше чем второе число {secondNumber}");
if (firstNumber > secondNumber)
    Console.WriteLine ($"Первое число {firstNumber} больше чем второе число {secondNumber}");
System.Console.WriteLine();


System.Console.WriteLine("Давай еще! введи числа, а я их буду умножать");
System.Console.WriteLine();
System.Console.WriteLine("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int resultlt = num1 * num2 * num3;
Console.WriteLine(resultlt);
System.Console.WriteLine("Мне нравится с тобой играть!!");

System.Console.WriteLine();
System.Console.WriteLine("Как у тебя с английским? Напиши слово 'Любовь' латинскими буквами");
Console.ReadLine(); 
System.Console.WriteLine(); 
System.Console.WriteLine("ПРАВИЛЬНО"); 
System.Console.WriteLine($"На этом все, {username}. Надеюсь, тебе понравилось так же как и мне!");

int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
    {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0}, 
    {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0)
                Console.Write($"   ");
            else Console.Write($" + ");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
} 

FillImage(3, 5);
PrintImage(pic); 
System.Console.WriteLine("Спасибо за игру!");