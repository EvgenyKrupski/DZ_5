// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
        array[i] = new Random().Next(1,20);
    }
}
int [] randomArray = new int[8];
FillArray(randomArray);
WriteArray(randomArray);

int sumNechet = 0;
for (int index = 0; index<randomArray.Length; index++)
{
    if (index % 2 != 0)
    {
        sumNechet = sumNechet + randomArray[index];
    }
} 
Console.WriteLine("Сумма чисел массива, стоящих на нечетных позициях - " + sumNechet);