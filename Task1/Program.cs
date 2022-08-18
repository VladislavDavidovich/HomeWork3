// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
string count = Convert.ToString(number);

if(count[0]==count[4] || count[1]==count[3])
{
     Console.WriteLine("число - палиндром.");
}
else
{
    Console.WriteLine("число - не палиндром.");
}