void Example010()
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
{
    /* Random rand = new Random();
    int number = rand.Next(100,1000);
    Console.WriteLine(number); */
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);

    if (number < 100)
        Console.WriteLine("Введите трехзначное число");
    else
    {
        int two = number % 100 / 10;
        Console.WriteLine(two);
    }
}

void Example013()
// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    
    if (number < 100)
        Console.WriteLine("В числе меньше трех цифр");
    else while (number > 999)
        number = number / 10;
    Console.WriteLine(number % 10);
}

void Example015()
// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
{
    Console.Write("Введите номер дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
        
    if (number < 1 || number > 7)
        Console.WriteLine("Число дня недели введено некорректно");
    else if (number == 1)
        Console.WriteLine("Будний день - понедельник");
    else if (number == 2)
        Console.WriteLine("Будний день - вторник");
    else if (number == 3)
        Console.WriteLine("Будний день - среда");
    else if (number == 4)
        Console.WriteLine("Будний день - четверг");
    else if (number == 5)
        Console.WriteLine("Будний день - пятница");
    else if (number == 6)
        Console.WriteLine("ВЫХОДНОЙ - суббота");
    else
        Console.WriteLine("ВЫХОДНОЙ - воскресенье");
}

Example010();
Example013();
Example015();