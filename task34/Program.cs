/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Write("Введите число A: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i] % 2 == 0)
        sum += array[i];
}
Console.Write("[");
Console.Write(string.Join("," , array));
Console.Write("] => ");
Console.WriteLine($"Сумма чётных чисел в массиве = {sum}");