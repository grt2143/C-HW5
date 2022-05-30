// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

Console.Write("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Массив:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    min = array[i];
}

double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    max = array[i];
}
Console.WriteLine($"\nРазность между максимальным и минимальным элементом равна {max - min}");