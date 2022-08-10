// Задача № 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

using static System.Console;
Clear();

int DifinOfTheSecondNumber(int number1) // функция определения второго числа
{
    int secondnumber = (number1 % 100) / 10;
    return secondnumber;
}

WriteLine("Введите трехзначное чиcло");
int number = Convert.ToInt32(ReadLine());
if(number > 99 && number < 1000)
{
    int secondnumberresult = DifinOfTheSecondNumber(number);
    WriteLine(secondnumberresult);
}
else
{
    WriteLine("Введенное число не является трехзначным");
}