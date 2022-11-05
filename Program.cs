// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите элементы(через пробел): );                        
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);     чужой пример решения
// int count = 0;
//  for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
//  Console.WriteLine($"Кол-во элементов > 0: {count}");


// Console.Clear();
// Console.WriteLine("Введите цифру размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] arrey=new int [size];
// int count = 0;
// for (int i=0; i<arrey.Length; i++)
// {
//     Console.WriteLine("Введите цифру");
//     arrey [i]=Convert.ToInt32(Console.ReadLine());
// }
// for (int i=0; i<arrey.Length; i++)
// {
//     Console.Write ($"{arrey[i]}  ");
// }
// for (int i=0; i<arrey.Length; i++)
// {
//     if (arrey[i]>0)
//     {
//         count++;
//     }
// }
// Console.WriteLine ($"Количество элементов > 0 = {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.WriteLine("Введите значение b1");   
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b2-b1)/(k1-k2);                     //k1 * x + b1=k2 * x + b2;   k1 * x-k2 * x=b2-b1; x*(k1-k2)=b2-b1
double y = k1 * x + b1;
Console.WriteLine ($"Координаты точки пересечения: {x}, {y}"); 

// Проверить вариант, если прямые параллельны????