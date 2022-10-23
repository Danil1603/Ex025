/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.WriteLine("Введите число А:");
var numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
var numB = int.Parse(Console.ReadLine());

var stepen = numA;

for (int i = 1; i <= numB; i++)
{
    stepen = stepen * numA;
}

Console.WriteLine($"Число А ({numA}) в натуральной степени В ({numB}) = {stepen}");

