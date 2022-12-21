// Задача 38: Задайте массив случайных вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введиет размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] mass = CreateArray(size);
CreateArray(size);
MaxMinArray(mass);

double[] CreateArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(10, 100);
    return array;
}
void MaxMinArray(double[] mass)
{
    double max = 0;
    double min = 0;
    for (int i = 0; i < mass.Length; i++)
        if (mass[i] > max) max = mass[i];
    min = max;
    for (int j = 0; j < mass.Length; j++)
    {
        if (mass[j] < min) min = mass[j];
    }

    double result = max - min;
    string Diff = string.Join(",", mass);
    Console.Write($"[{Diff}] Разница макс и мин элемента массива равна [{result}]");
}