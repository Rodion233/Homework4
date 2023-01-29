/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
Не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16   
*/
int Prompt(string message)
{
    System.Console.Write($"{message}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int num1 = Prompt("Enter number A");
int num2 = Prompt("Enter number B");
int Exponation(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}
int exp = Exponation(num1, num2);
System.Console.WriteLine($"Число {num1} в степени {num2} равно {exp}");