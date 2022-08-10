// Задача № 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using static System.Console;
Clear();

int determiningthedayoftheweek(int number1)
{
    if(number1 <= 5)
     {
        WriteLine("Cегодня явно не выходной");
     }
     if(number1 > 5 && number1 <= 7)
     {
        WriteLine("Сегодня выходной");
     } 
     return number1;
}

WriteLine("Введите цифру, обозначающую день недели =)");
int number = Convert.ToInt32(ReadLine());

if(number <= 7)
{
 int thatday = determiningthedayoftheweek(number);
}
else
{
    WriteLine("Такого дня недели нет, постаратесь вести цифру, обозначающую день недели, заново");
}
