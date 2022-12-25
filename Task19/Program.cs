// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.Write("Введите число: ");
string str = Console.ReadLine();

if(str.Length > 5 || str.Length < 5) Console.WriteLine("Введите 5-значное число");

else if(str[0]==str[4] && str[1]==str[3])
   {
    Console.WriteLine("Да");
   } 
else 
  {
    Console.WriteLine("Нет");
  }
  
