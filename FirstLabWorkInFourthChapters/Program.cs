﻿/*
Упражнение 4.1 Написать программу, которая читает с экрана число от 1 
до 365(номер дня в году), переводит этот число в месяц и день месяца. 
Например, число 40 соответствует 9 февраля (високосный год не учитывать).

Упражнение 4.2 Добавить к задаче из предыдущего упражнения 
проверку числа введенного пользователем. Если число меньше 1 или больше 
366, программа должна вырабатывать исключение, и выдавать на экран 
сообщение. 

Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так,
чтобы она учитывала год (високосный или нет). Год вводится с экрана. (Год 
високосный, если он делится на четыре без остатка, но если он делится на 100 
без остатка, это не високосный год. Однако, если он делится без остатка на 400,
это високосный год.
*/

using FirstLabWorkInFourthChapters;

Console.Write("Введите день года, чтобы выяснить месяц и день в нем: Day = ");
var programm = new DayAndMonthInYear(Console.ReadLine());
Console.WriteLine(programm);
Console.Write("Введите год, чтобы выяснить высокосный он или нет:"); 
var leapYear = new LeapYear(Console.ReadLine());
Console.WriteLine(leapYear);
