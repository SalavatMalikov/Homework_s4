// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Веедите число");
string num = (Console.ReadLine());

int SumNum()
{
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        sum = sum + (num[i] - '0');
    }
    return sum;
}
Console.WriteLine(SumNum());
