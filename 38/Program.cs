// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void WriteArray(double[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}
void FillArray(double[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(-20,20);
    }
}
double [] randomArray = new double[8];
FillArray(randomArray);
WriteArray(randomArray);

double min = randomArray[0];
for (int index = 0; index<randomArray.Length; index++)
{
    if (randomArray[index] < min)
    {
        min = randomArray[index];
    }
} 

double max = randomArray[0];
for (int index = 0; index<randomArray.Length; index++)
{
    if (randomArray[index] > max)
    {
        max = randomArray[index];
    }
} 
double result = max - min;

Console.WriteLine("Разница между максимальным и минимальным элементом массива - " + result);
