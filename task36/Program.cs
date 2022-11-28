/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите число A: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
        sum += array[i];
}
Console.Write("[");
Console.Write(string.Join("," , array));
Console.Write("] => ");
Console.WriteLine($"Сумма  чисел на нечетных позициях = {sum}");