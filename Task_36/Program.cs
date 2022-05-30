// Задайте одномерный массив, заполненный случайными числами.
// найдите сумму элементов, стоящих на нечётных позициях

Console.Write("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
var newRand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = newRand.Next(-100, 100);
    Console.Write(array[i] + " ");
}

Console.WriteLine();

// Этот вариант для тех, кто считает элементы массива с 0
/*
for (int i = 1; i < array.Length; i = i + 2) 
{
    sum = sum + array[i];
}
*/

for (int i = 0; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Сумма нечётных элементов в массиве -> {sum}");

