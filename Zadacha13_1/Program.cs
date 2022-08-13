// Задача № 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
using static System.Console;
Clear();
WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(ReadLine());
if(n > 99 && n < 100000)
{
    int result = (n % 1000) / 100;
    WriteLine("Третья цифра = " + (result));
}
else
{
    WriteLine("Третьей цифры нет");
}