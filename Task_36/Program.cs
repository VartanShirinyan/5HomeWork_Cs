// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Задайте размер массива");
OneMas();
void OneMas()
{
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 50);
        if (i % 2 != 0)
            sum += array[i];
    }
    string SumNega = string.Join(",", array);
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях [{SumNega}] равна [{sum}]");
}