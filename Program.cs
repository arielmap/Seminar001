// int string bool float double
// int a = 10;
// string = "hello"
// bool = true // false
// flat d = 15.3   ==== 10 млн значений
// double e = 15.4f; === 100 млн значений
// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ваш ответ");
// Console.WriteLine(number1 + number2);



// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите оператор +/-/*/:");
// string Operator = Console.ReadLine();
// if(Operator == "+")
// {
//     Console.WriteLine(number1 + number2);
// }
// else if(Operator == "-")
// {
//     Console.WriteLine(number1 - number2);
// }
// else if(Operator == "*")
// {
//     Console.WriteLine(number1 * number2);
// }
// else if(Operator == ":")
// {
//     Console.WriteLine(number1 / number2);
// }


// while (true)
// {
//     Console.WriteLine("Введите первое число");
//     int number1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите второе число");
//     int number2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите оператор +/-/*/:");
//     string Operator = Console.ReadLine();
//     if (Operator == "+")
//     {
//         Console.WriteLine(number1 + number2);
//     }
//     else if (Operator == "-")
//     {
//         Console.WriteLine(number1 - number2);
//     }
//     else if (Operator == "*")
//    {
//         Console.WriteLine(number1 * number2);
//     }
//     else if (Operator == ":")
//     {
//        Console.WriteLine(number1 / number2);
//     }
//     else if (Operator == "end")
//     {
//         break;
//         }
// }



// Homework
// Первая задача

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine(number1);
}
else if (number1 < number2)
{
    Console.WriteLine(number2);
}

// Вторая задача

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    Console.WriteLine(number1);
}
if (number2 > number1 && number2 > number3)
{
    Console.WriteLine(number2);
}
if (number3 > number1 && number3 > number2)
{
    Console.WriteLine(number3);
}

// Третья задача

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else 
{
    Console.WriteLine("Число является нечетным");
}

// Четвертая задача(не могу понять как ее написать)

