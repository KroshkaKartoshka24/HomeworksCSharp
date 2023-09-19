// try 
// {
//     Console.WriteLine("Введите первое число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите второе число: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     if (a > b)
//     {
//         Console.WriteLine($"max = {a}, min = {b}");
//     }
//     else if (a < b)
//     {
//         Console.WriteLine($"max = {b}, min = {a}");
//     }
//     else 
//     {
//         Console.WriteLine("Первое число равно второму");
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Введен неверный тип данных: " + ex.Message);
// }

using System;
using System.Linq;

try 
{
    double[] nums = new double[3];
    Console.WriteLine("Введите первое число: ");
    nums[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    nums[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    nums[2] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Максимальное число = " + nums.Max());
}
catch (Exception ex)
{
    Console.WriteLine("Введен неверный тип данных: " + ex.Message);
}

