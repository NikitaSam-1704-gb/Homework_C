﻿// Программа 1, вывод степени числа введеного с консоли
//int number = Convert.ToInt32(Console.ReadLine());
//int sq = (int)Math.Pow(number, 3) ;
//Console.WriteLine(sq) ;


// Программа 2 Вывод результата сравнения двух чисел, если первое равно квадрату второго, выводи "Да", если не равно  то "Нет"
//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (number1==(int)Math.Pow(number2, 2)) 
//  {
//   Console.WriteLine(" да ") ;
//  } 
//   else
//   {
//    Console.WriteLine(" нет ") ;
//   }
  
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите первое число ");
int num1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число ");
int num2=Convert.ToInt32(Console.ReadLine());
if (num1>num2)
  Console.WriteLine($" max {num1}");
else 
  Console.WriteLine($" max {num2}");

