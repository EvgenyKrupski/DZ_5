// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void WriteArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}
void FillArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
int [] randomArray = new int[20];
FillArray(randomArray);
WriteArray(randomArray);
int count = 0;
for (int index = 0; index<randomArray.Length; index++)
{
    if( randomArray[index] % 2 == 0)
    count++;
}
Console.WriteLine("Количество четных чисел в массиве - " + count);