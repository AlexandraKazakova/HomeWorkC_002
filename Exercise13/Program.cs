// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число -> ");
string number = Console.ReadLine();
int lenght = number.Length;
if (number.Length <= 2) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine(number[2]);