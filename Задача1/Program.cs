/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;
void Test(string number){
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"{number}: палиндромное.");
  }
  else Console.WriteLine($"{number}: не палиндромное.");
}
if (number.Length == 5){
  Test(number);
}
else Console.WriteLine($"Введи правильное число");*/

int num1,num2,num3,num4,num5;
Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out num2);
Console.Write($"Введите третье число: ");
int.TryParse(Console.ReadLine()!, out num3);
Console.Write($"Введите четвертое число: ");
int.TryParse(Console.ReadLine()!, out num4);
Console.Write($"Введите пятое число: ");
int.TryParse(Console.ReadLine()!, out num5);
if (num1==num5&&num2==num4)
    Console.Write($"Число палиндромное");
else if (num1>10||num2>10||num3>10||num4>10||num5>10)
    Console.Write($"нужно 5-ти значное число");
else
    Console.Write($"Число НЕ палиндромное");