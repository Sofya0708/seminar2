//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и показывает вторую цифру этого числа.

/* Console.WriteLine("Your number: ");
int number = int.Parse(Console.ReadLine()!);

int a = number/10;
int b = a%10;

if ((number>=100) && (number<=999))
{
    Console.WriteLine($"{b} - вторая цифра числа {number}");
}
else
{
    Console.WriteLine("Число не является трёхзначным");
}*/



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/* Console.WriteLine("Введите число от 1 до 99999");
int number = int.Parse(Console.ReadLine()!);
int a = 0;

if ((number > 9999) && (number < 99999))
{
    a = number / 100;
    a = a % 10;
    Console.WriteLine($"{a} - является третьей цифрой числа {number}");
}
else if ((number > 999) && (number < 9999))
{
    number = a / 10;
    a = a % 10;
    Console.WriteLine($"{a} - является третьей цифрой числа {number}");
}
else if ((number > 99) && (number < 999))
{
    a = number % 10;
    Console.WriteLine($"{a} - является третьей цифрой числа {number}");
}
if (number < 100){
    Console.WriteLine("Третьей цифры в этом числе нет");
}
if (number > 99999)
{
    Console.WriteLine("Не подходит условию. Пожалуйста, введите число от 1 до 99999");
}*/



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
//Обязательно сделать проверку на ввод чисел меньше 1 и больше 7


/* Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine()!);

switch (a)
{
    case 1:
        Console.WriteLine("Понедельник - рабочий день");
        break;
    case 2:
        Console.WriteLine("Вторник - рабочий день");
        break;
    case 3:
        Console.WriteLine("Среда - рабочий день");
        break;
    case 4:
        Console.WriteLine("Четверг - рабочий день");
        break;
    case 5:
        Console.WriteLine("Пятница - рабочий день");
        break;
    case 6:
        Console.WriteLine("Суббота - выходной день");
        break;
    case 7:
        Console.WriteLine("Воскресенье - выходной день");
        break;
    default: Console.WriteLine("Неверно указан день недели");
    break;
}*/
