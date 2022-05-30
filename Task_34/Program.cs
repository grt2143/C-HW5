// Задать массив заполненный случайными положительными трёхзначными числами. 
// Написать программу, которая покажет количество чётных чисел в массиве

Console.Write("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int count = 0;
var newRand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = newRand.Next(100, 1000);
    Console.Write(array[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        count += 1;
}
Console.WriteLine($"Количество чётных элементов в массиве -> {count}");

