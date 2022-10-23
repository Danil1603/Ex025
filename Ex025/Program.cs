/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.WriteLine("Введите число А:");
var numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
var numB = int.Parse(Console.ReadLine());

if(numB > 0) // Я понял, что натуральное число (1, 2, 3 и тд) - именно относится к числу В, а число А может быть любым
{
    var result = Math.Pow(numA, numB);
    Console.WriteLine($"Число А ({numA}) в степени В ({numB}) = {result}");
}
else
{
    Console.WriteLine("Введено не правильное число (меньше или равно 0). Попробуй еще");
}
 
