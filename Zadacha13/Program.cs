// Задача № 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

using static System.Console;
Clear();
WriteLine("Введите число");
int number = Convert.ToInt32(ReadLine());
if(number > 99)
{
    string result = Convert.ToString(number);
    WriteLine($"Третья цифра: {result[2]}");
}
else
{
    WriteLine("Третьей цифры не существует");
}