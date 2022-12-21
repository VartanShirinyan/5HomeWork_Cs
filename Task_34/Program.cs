// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Count();
void Count()
{
    Console.WriteLine("Задайте размер массива");
    int num = Convert.ToInt32(Console.ReadLine());
    Random ran = new Random();
    int count = 0;
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ran.Next(100, 1000);
        Console.Write($"{array[i]} ");
        if (array[i] % 2 == 0)
        { count++; }
    }
    Console.WriteLine($"Колл-во четных чисел в массиве = {count}");
}
